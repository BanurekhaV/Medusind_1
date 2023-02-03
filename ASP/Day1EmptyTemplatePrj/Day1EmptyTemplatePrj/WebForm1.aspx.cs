using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day1EmptyTemplatePrj
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Welcome to ASP.Net..");
        }

        
        protected void BtnClick_Click(object sender, EventArgs e)
        {
            TxtName.Text = "Banurekha";
            TxtPassword.Text = "Admin";
        }
    }
}