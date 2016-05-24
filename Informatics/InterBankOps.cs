using System;
using System.ServiceModel;
using Server.BankA;
using Server.BankB;
using Server.Supervisor;
using System.Data.SQLite;
using System.Collections.Generic;

namespace InterBank
{
    public class InterBankOps : IInterBankOps
    {
        SupervisorOpsClient supervisor = new SupervisorOpsClient();
        SQLiteConnection conn;

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
                string getcompany_id= "select id from company where name=" + "'"+company + "';";
                string getclient_id = "select id from client where name=" + "'"+username+"'"+ " and email="+ "'" + email +"';";
                SQLiteCommand cmd = new SQLiteCommand(getcompany_id, conn);
                int company_id = Convert.ToInt16(cmd.ExecuteScalar().ToString());
                
                cmd = new SQLiteCommand(getclient_id, conn);
                int client_id = Convert.ToInt16(cmd.ExecuteScalar().ToString());

                if (company_id < 1 || client_id < 1 || quantity <=0)
                    throw new InvalidRequestException();




                string sqlcmd = "insert into orders(quantity, request_date, company_id,order_type,execution_status,client_id) values("+quantity.ToString()+","+
                    "'" + request_date_time.ToString()+ "'" + "," +company_id.ToString()+","+"'"+order_type+"'," + "'" + execution_value + "'" + ","+client_id.ToString()+");";
                Console.WriteLine(sqlcmd);

                cmd = new SQLiteCommand(sqlcmd, conn);
                int rows = Convert.ToInt32(cmd.ExecuteNonQuery().ToString());
                if (rows == 1)
                {
                    Console.WriteLine("Sucucessu!");
                    supervisor.PurchaseStock(company, quantity);
                }
            }
            finally
            {
                conn.Close();
            }
            
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

                while(r.Read())
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

        public class InvalidRequestException : Exception
        {

        }
    }
}
