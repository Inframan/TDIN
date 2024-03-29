﻿using System;
using System.Data.SQLite;
using System.ServiceModel;

namespace Supervisor
{
    public class SupervisorOps : ISupervisorOps
    {

        SQLiteConnection conn;


        [OperationBehavior(TransactionScopeRequired = true)]
        public void PurchaseStock(int order_id,string company, int company_id, int quantity, string username, int client_id, DateTime request_date_time, string execution_value, string order_type)
        {
            conn = new SQLiteConnection("data source=eBanking.db");

            try
            {
                conn.Open();
                string sqlcmd = "insert into orders(id,quantity, request_date, company_id,order_type,client_id,execution_status) values("+order_id.ToString()+"," + quantity.ToString() + "," +
                        "'" + request_date_time.ToString() + "'" + "," + company_id.ToString() + "," + "'" + order_type + "'," + client_id.ToString() + ",'Request');";

                SQLiteCommand cmd = new SQLiteCommand(sqlcmd, conn);
                cmd.ExecuteNonQuery();               
            }
            finally
            {
                conn.Close();
            }
            Console.WriteLine("Purchasing: " + company + " for: " + quantity);
        }
    }
}
