using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebExceptionClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnDivide_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(TextBox1.Text);
            int num2= Convert.ToInt32(TextBox2.Text);
            ProxyService.MathsServiceClient client = new ProxyService.MathsServiceClient();
            Label1.Text = client.Divide(num1, num2).ToString();
        }
    }
}