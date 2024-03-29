﻿using System;
using System.ServiceModel;
using Server.Supervisor;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Net.Mail;
using System.Text;
using System.Messaging;

namespace InterBank
{
    public class InterBankOps : IInterBankOps
    {
        SupervisorOpsClient supervisor = new SupervisorOpsClient();
        SQLiteConnection conn;
        public static bool stockOnline = false;


        public InterBankOps()
        {
            conn = new SQLiteConnection("data source=eBanking.db");
        }

        [OperationBehavior(TransactionScopeRequired = true)]
        public void PurchaseStock(string company, int quantity, string username, string email, DateTime request_date_time, string execution_value, string order_type)
        {
            //string message = String.Format("Transfer of {0:F2} from A{1} to B{2}", amount, acctA, acctB);


            try
            {
                conn.Open();
                //string sqlcmd = "update Accounts set Balance=Balance+" + amount.ToString("F2") +
                //           " where AccNr=" + acct + ";";
                string getcompany_id = "select id from company where name=" + "'" + company + "';";
                SQLiteCommand cmd = new SQLiteCommand(getcompany_id, conn);
                int company_id = Convert.ToInt16(cmd.ExecuteScalar().ToString());


                int client_id = getClient(username, email);


                if (quantity <= 0 || client_id < 0)
                    throw new InvalidRequestException();


                string sqlcmd = "insert into orders(quantity, request_date, company_id,order_type,client_id,execution_status) values(" + quantity.ToString() + "," +
                    "'" + request_date_time.ToString() + "'" + "," + company_id.ToString() + "," + "'" + order_type + "'," + client_id.ToString() + ",'Request');";
                Console.WriteLine(sqlcmd);

                cmd = new SQLiteCommand(sqlcmd, conn);
                int rows = Convert.ToInt32(cmd.ExecuteNonQuery());
                if (rows == 1)
                {
                    string get_id = "select id from orders where request_date = '" + request_date_time.ToString() + "';";
                    cmd = new SQLiteCommand(get_id, conn);
                    int id = Convert.ToInt16(cmd.ExecuteScalar());

                    if (stockOnline)
                        supervisor.PurchaseStock(id, company, company_id, quantity, username, client_id, request_date_time, order_type);
                    else
                    {

                        MessageQueue messageQueue = null;
                        if (MessageQueue.Exists(@".\Private$\supervisor"))
                        {
                            messageQueue = new MessageQueue(@".\Private$\supervisor");
                            if (messageQueue.Transactional == true)
                            {
                                using (MessageQueueTransaction trans = new MessageQueueTransaction())
                                {
                                    trans.Begin();
                                    messageQueue.Send("insert into orders(id,quantity, request_date, company_id,order_type,client_id,execution_status, client_name) values(" + id.ToString() + "," + quantity.ToString() + "," +
                        "'" + request_date_time.ToString() + "'" + "," + company_id.ToString() + "," + "'" + order_type + "'," + client_id.ToString() + ",'Request','"+username+"');", order_type + " " + id, trans);
                                    trans.Commit();
                                }
                            }
                        }
                        else
                            messageQueue.Send("First ever Message is sent to MSMQ", order_type + " " + id);
                    }
                }
            }
            finally
            {
                conn.Close();
            }

        }

        public void StockSubscribe()
        {
            stockOnline = true;
        }

        public void StockUnsubscribe()
        {
            stockOnline = false;
        }


        private int getClient(string username, string email)
        {
            int client_id;
            string getclient_id = "select id from client where name=" + "'" + username + "'" + " and email=" + "'" + email + "';";

            SQLiteCommand cmd = new SQLiteCommand(getclient_id, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                client_id = Convert.ToInt16(reader["id"]);
            }
            else
                client_id = storeNewUser(username, email);

            return client_id;
        }

        public List<string> GetCompanies()
        {
            List<string> companies = new List<string>();

            try
            {
                conn.Open();

                string sqlcmd = "select name from company;";

                SQLiteCommand cmd = new SQLiteCommand(sqlcmd, conn);
                SQLiteDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    companies.Add(r["name"].ToString());
                }


            }
            finally
            {
                conn.Close();
            }


            return companies;

        }

        public List<string[]> GetOrders(string client_name, string client_mail)
        {
            List<string[]> orders = new List<string[]>();



            try
            {
                conn.Open();


               int client_id =  getClient(client_name, client_mail);

                string sqlcmd = "select orders.execution_date, orders.execution_value, orders.order_type, orders.quantity, orders.request_date, orders.execution_status, company.name from orders, company where orders.company_id = company.id and orders.client_id ="+client_id+";";

                SQLiteCommand cmd = new SQLiteCommand(sqlcmd, conn);
                SQLiteDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {

                    string[] order = new string[7];
                    order[0] = r["quantity"].ToString();
                    order[1] = Convert.ToString(r["request_date"]);
                    order[2] = r["execution_status"].ToString();
                    if (!r.IsDBNull(1))
                        order[3] = r["execution_value"].ToString();
                    if (!r.IsDBNull(0))
                        order[4] = r["execution_date"].ToString();
                    order[5] = r["order_type"].ToString();
                    order[6] = r["name"].ToString();
                    orders.Add(order);
                }
            }
            finally
            {
                conn.Close();
            }


            return orders;
        }

        public void UpdateOrder(int client_id, int order_id, DateTime execution_date, string execution_status, string execution_value)
        {


            try
            {
                conn.Open();
                string sqlcmd = "update orders set execution_value= '" + execution_value + "', execution_date = '" + execution_date.ToString()
+ "',execution_status='" + execution_status + "' where id = " + order_id + ";";
                SQLiteCommand cmd = new SQLiteCommand(sqlcmd, conn);
                cmd.ExecuteNonQuery();

            

                sendEmail(getClientEmail(client_id), order_id, execution_date, execution_status, execution_value);
            }
            finally
            {
                conn.Close();
            }


        }

        private string getClientEmail(int id)
        {
            string client_email = "";

            
            string getclient_id = "select email from client where id=" + id + ";";

            SQLiteCommand cmd = new SQLiteCommand(getclient_id, conn);
            client_email = (cmd.ExecuteScalar()).ToString();


            return client_email;
        }

        private void sendEmail(string client_email, int order_id, DateTime execution_date, string execution_status, string execution_value)
        {

            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("tdin.informatics@gmail.com", "caca2710");

            MailMessage mm = new MailMessage("tdin.informatics@gmail.com", client_email, "Informatics Department", client_email);
            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            mm.Subject = "Order " + order_id + " updated";
            mm.Body = "Order " + order_id + " updated:\nExecution Date: " + execution_date + "\nExecution Status: " + execution_status + "\nExecution Value: " + execution_value;
            client.Send(mm);
        }

        public int storeNewUser(string username, string email)
        {
            string sqlcmd = "insert into client(name, email) values('" + username + "', '" + email + "');";

            var cmd = new SQLiteCommand(sqlcmd, conn);
            int rows = Convert.ToInt32(cmd.ExecuteNonQuery());
            if (rows == 1)
            {
                string get_id = "select id from client where email = '" + email + "';";
                cmd = new SQLiteCommand(get_id, conn);
                return Convert.ToInt16(cmd.ExecuteScalar());
            }

            return -1;
        }


        public class InvalidRequestException : Exception
        {

        }
    }
}
