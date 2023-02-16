using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorService_WebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Employee_CalculatorService.CalculatorServiceClient webclient =
            new Employee_CalculatorService.CalculatorServiceClient("BasicHttpBinding_ICalculatorService");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = webclient.Add(int.Parse(TextBox1.Text), int.Parse(TextBox2.Text)).ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = webclient.GetMessage(TextBox3.Text);
        }
    }
}