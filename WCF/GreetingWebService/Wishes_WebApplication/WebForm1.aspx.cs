using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Wishes_WebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        WishesWeb.WishesServiceSoapClient client = new WishesWeb.WishesServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            
            Lbl1.Text = client.HelloWorld();
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            Lbl1.Text = client.Add2Nos(Convert.ToInt32(Txtbox1.Text), Convert.ToInt32(Txtbox2.Text)).ToString();
        }
    }
}