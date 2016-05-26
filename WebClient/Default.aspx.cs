using System;

namespace WebClient
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                var InterBank = new InterBankOps();

                var companies = InterBank.GetCompanies();
            }
        }

    }
}