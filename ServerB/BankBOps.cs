using System;
using System.ServiceModel;
using System.Configuration;
using System.Data.SQLite;

namespace BankB
{
    public class BankBOps : IBankBOps
    {
        public static string connString = ConfigurationManager.ConnectionStrings["BankB"].ToString();

        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = false)]
        public void Deposit(int acct, double amount)
        {
            SQLiteConnection conn = new SQLiteConnection(connString);

            int rows;
            try
            {
                conn.Open();
                string sqlcmd = "update Accounts set Balance=Balance+" + amount.ToString("F2") +
                           "where AccNr=" + acct + ";";
                SQLiteCommand cmd = new SQLiteCommand(sqlcmd, conn);
                rows = cmd.ExecuteNonQuery();
                if (rows == 1)
                    OperationContext.Current.SetTransactionComplete();
            }
            finally
            {
                conn.Close();
            }
        }

        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = false)]
        public void Withdraw(int acct, double amount)
        {
            SQLiteConnection conn = new SQLiteConnection(connString);
            int rows;
            try
            {
                conn.Open();
                string sqlcmd = "update Accounts set Balance=Balance-" + amount.ToString("F2") +
                           "where AccNr=" + acct + ";";
                SQLiteCommand cmd = new SQLiteCommand(sqlcmd, conn);
                rows = cmd.ExecuteNonQuery();
                if (rows == 1)
                    OperationContext.Current.SetTransactionComplete();
            }
            finally
            {
                conn.Close();
            }
        }

        public double GetBalance(int acct)
        {
            SQLiteConnection conn = new SQLiteConnection(connString);
            double amount;
            try
            {
                conn.Open();
                string sqlcmd = "select Balance from Accounts where AccNr=" + acct.ToString() + ";" ;
                SQLiteCommand cmd = new SQLiteCommand(sqlcmd, conn);
                amount = Convert.ToDouble((decimal)cmd.ExecuteScalar());
            }
            catch
            {
                amount = -1.0;
            }
            finally
            {
                conn.Close();
            }
            return amount;
        }
    }
}
