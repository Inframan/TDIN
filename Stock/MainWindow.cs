using Supervisor.InterBank;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Messaging;
using System.ServiceModel;
using System.Timers;
using System.Windows.Forms;

namespace Supervisor
{
    public partial class MainWindow : Form
    {
        ServiceHost host = new ServiceHost(typeof(SupervisorOps));
        InterBankOpsClient op;
        private SQLiteConnection conn;

        public MainWindow()
        {
            host.Open();
            op = new InterBankOpsClient();

            InitializeComponent();
            op.StockSubscribe();

            ReadMessageQueues();
            UpdateOrdersList();


            //enableTimer();
        }

        private void enableTimer()
        {
            // Create a timer
            var myTimer = new System.Timers.Timer(10);
            // Tell the timer what to do when it elapses
            myTimer.Elapsed += new ElapsedEventHandler(myEvent);
            // Set it to go off every five seconds
            myTimer.Interval = 5000;
            // And start it        
            myTimer.Enabled = true;
        }

        private void myEvent(object source, ElapsedEventArgs e)
        {
            UpdateOrdersList();
        }

        private void exit(object sender, FormClosingEventArgs e)
        {
            op.StockUnsubscribe();
            host.Close();
        }

        private void ordersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var row = ordersList.Rows[e.RowIndex];

                var order_id = row.Cells[0].Value;
                var client_id = row.Cells[1].Value;
                var value = row.Cells[6].Value;
                var status = row.Cells[7].Value;
                var date = DateTime.Now;

                if((status.ToString() == "Accepted" && Convert.ToInt16(value) > 0) || status.ToString() == "Refused")
                    SetOrderStatus(row, Convert.ToInt16(client_id), Convert.ToInt16(order_id), value.ToString(), status.ToString(), date);
                else
                    MessageBox.Show("Value or Status not allowed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SetOrderStatus(DataGridViewRow row, int client_id, int order_id, string value, string status, DateTime date)
        {
            conn = new SQLiteConnection("data source=eBanking.db");
            SQLiteDataReader reader;

            try
            {
                conn.Open();

                op.UpdateOrder(client_id, order_id, date, status, value);


                string sqlcmd = "delete from orders where id = " + order_id + ";";
                SQLiteCommand cmd = new SQLiteCommand(sqlcmd, conn);
                cmd.ExecuteNonQuery();

                ordersList.Rows.Remove(row);

                UpdateOrdersList();
            }
            finally
            {
                conn.Close();
            }
        }

        public void UpdateOrdersList()
        {
            conn = new SQLiteConnection("data source=eBanking.db");
            SQLiteDataReader reader;

            try
            {
                conn.Open();
                string sqlcmd = "select orders.*, company.name as company_name from orders, company where company.id = orders.company_id;";

                SQLiteCommand cmd = new SQLiteCommand(sqlcmd, conn);
                reader = cmd.ExecuteReader();
                ordersList.Rows.Clear();

                while (reader.Read())
                {
                    ordersList.Rows.Add();
                    var i = ordersList.Rows.Count - 1;

                    ordersList.Rows[i].Cells[0].Value = reader["id"].ToString();
                    ordersList.Rows[i].Cells[1].Value = reader["client_id"].ToString();
                    ordersList.Rows[i].Cells[2].Value = reader["order_type"].ToString();
                    ordersList.Rows[i].Cells[3].Value = reader["quantity"].ToString();
                    ordersList.Rows[i].Cells[4].Value = reader["company_name"].ToString();
                    ordersList.Rows[i].Cells[5].Value = reader["request_date"].ToString();
                    ordersList.Rows[i].Cells[6].Value = "0";
                    //(DataGridViewComboBoxCell)ordersList.Rows[i].Cells[7].
                    ordersList.Rows[i].Cells[8].Value = "Submit";
                }
            }
            finally
            {
                ordersList.Update();
                conn.Close();
            }
        }



        private void ReadMessageQueues()
        {
            if (MessageQueue.Exists(@".\Private$\supervisor"))
            {

                MessageQueue messageQueue = new MessageQueue(@".\Private$\supervisor");
                System.Messaging.Message[] messages = messageQueue.GetAllMessages();

                string rec = "";
                string sqlcmd;
                foreach (System.Messaging.Message message in messages)
                {
                    string line;
                    message.Formatter = new System.Messaging.XmlMessageFormatter(new String[] { });
                    StreamReader sr = new StreamReader(message.BodyStream);
                    
                    while (sr.Peek() >= 0)
                    {
                        rec += sr.ReadLine();
                    }

                    string[] splitter1 = new string[] { "<string>" }, splitter2 = new string[] { "</string>" };
                    rec = rec.Split(splitter1, StringSplitOptions.None)[1];
                    sqlcmd = rec.Split(splitter2, StringSplitOptions.None)[0];

                    conn = new SQLiteConnection("data source=eBanking.db");
                    try
                    {
                        conn.Open();
                        SQLiteCommand cmd = new SQLiteCommand(sqlcmd, conn);
                        cmd.ExecuteNonQuery();


                    }
                    finally
                    {
                        conn.Close();
                    }

                    messageQueue.Purge();
                }
            }
        }

        private void refreshTable(object sender, EventArgs e)
        {
            UpdateOrdersList();
        }

        private void ordersList_dataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
