using Client.InterBank;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Windows.Forms;

namespace Client
{
    public partial class mainWindow : Form
    {
        private static InterBankOpsClient proxy;

        public mainWindow()
        {
            proxy = new InterBankOpsClient();

            InitializeComponent();

            List<string> companies = GetCompanies();
            for (int i = 0; i < companies.Count; i++)
            {
                companies_combobox.Items.Insert(i, companies[i]);
            }
            companies_combobox.SelectedItem = 0;

            order_type_combobox.Items.Insert(0, "Purchase");
            order_type_combobox.Items.Insert(1, "Sell");
            order_type_combobox.SelectedItem = 0;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sendOrderRequest(object sender, EventArgs e)
        {
            loading.Visible = true;

            string company = companies_combobox.SelectedItem.ToString();
            int quantity =  Convert.ToInt16(quantity_number_slider.Value);
            string name = nameInput.Text;
            string email = emailInput.Text;
            string order_type = order_type_combobox.SelectedItem.ToString();
            proxy.PurchaseStock(company, quantity, name, email, DateTime.Now, "", order_type);


            clearForm();
            loading.Visible = false;
        }

        private void clearForm()
        {
            companies_combobox.SelectedItem = 0;
            quantity_number_slider.Value = 1;
            nameInput.Text = "";
            emailInput.Text = "";
            order_type_combobox.SelectedItem = 0;

        }

        private void exit(object sender, FormClosingEventArgs e)
        {

            if (proxy.State == CommunicationState.Opened)
                proxy.Close();
        }


        public List<string> GetCompanies()
        {

            return proxy.GetCompanies();
        }


        public void PurchaseOrder(string company, int quantity, string username, string email, DateTime request_date_time, string execution_value, string order_type)
        {
            //    Console.WriteLine("Before: BankA balance = {0:F2}  BankB balance = {1:F2}",  bankAProxy.GetBalance(acctA), bankBProxy.GetBalance(acctB));
            Console.WriteLine("Purchasing: " + company + " whith: " + quantity.ToString("F2"));
            try
            {
                proxy.PurchaseStock(company, quantity, username, email, request_date_time, execution_value, order_type);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Transaction Aborted: " + ex.Message);
            }
            //Console.WriteLine("After: BankA balance = {0:F2}  BankB balance = {1:F2}",                        bankAProxy.GetBalance(acctA), bankBProxy.GetBalance(acctB));
            if (proxy.State == CommunicationState.Opened)
                proxy.Close();
        }

        public List<string[]> GetOrders(string client_name, string client_email)
        {
            return proxy.GetOrders(client_name, client_email);
        }

        private void getOrdersFromUser(object sender, EventArgs e)
        {
            string name = name_list_input.Text;
            string email = email_list_input.Text;

            var orders = GetOrders(name, email);


            for(int i = 0; i < orders.Count; i++)
            {
                ordersList.Rows.Add(orders[i][5], orders[i][0], orders[i][3], orders[i][6], orders[i][1], orders[i][2], orders[i][4]);                 
            }

            ordersList.Update();
        }
    }
}
