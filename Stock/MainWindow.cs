using Supervisor.InterBank;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.ServiceModel;
using System.Windows.Forms;

namespace Supervisor
{
    public partial class MainWindow : Form
    {
        ServiceHost host = new ServiceHost(typeof(SupervisorOps));
        private SQLiteConnection conn;

        public MainWindow()
        {
            host.Open();


            InitializeComponent();


            UpdateOrdersList();

        }

        private void exit(object sender, FormClosingEventArgs e)
        {
            host.Close();
        }

        private void MainWindow_Load(object sender, System.EventArgs e)
        {

        }

        private void ordersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var row = ordersList.Rows[e.RowIndex];

                var order_id = row.Cells[0].Value;
                var value = row.Cells[6].Value;
                var status = row.Cells[7].Value;
                var date = DateTime.Now;

                SetOrderStatus(row, Convert.ToInt16(order_id), value.ToString(), status.ToString(), date);
            }
        }

        private void SetOrderStatus(DataGridViewRow row, int order_id, string value, string status, DateTime date)
        {
            conn = new SQLiteConnection("data source=eBanking.db");
            SQLiteDataReader reader;

            try
            {
                conn.Open();

                InterBankOpsClient op = new InterBankOpsClient();
                op.UpdateOrder(order_id, date, status, value);


                string sqlcmd = "delete from orders where id = " + order_id +";";
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

                while (reader.Read())
                {
                    var combobox = new DataGridViewComboBoxCell();
                    /*combobox.Items.Insert(0, reader["execution_status"].ToString());
                    combobox.Items.Insert(1, "Accepted");
                    combobox.Items.Insert(2, "Refused");*/
                    // combobox.Value = combobox.ValueMember;

                    ordersList.Rows.Add(reader["id"].ToString(), reader["client_id"].ToString(), reader["order_type"].ToString(), reader["quantity"].ToString(), reader["company_name"].ToString(), reader["request_date"].ToString(), "0", reader["execution_status"].ToString(), "Submit");
                }
            }
            finally
            {
                ordersList.Update();
                conn.Close();
            }
        }

        private void refreshTable(object sender, EventArgs e)
        {
            UpdateOrdersList();
        }
    }
}
