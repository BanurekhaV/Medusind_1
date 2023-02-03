using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class CookieDestination : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReceive_Click(object sender, EventArgs e)
        {
            //persistant cookie

            //HttpCookie rc = Request.Cookies["Mycookie"];
            //lbl1.Text = rc["d1"];
            //lbl2.Text = rc["d2"];

            //non persistant cookie

            lbl1.Text = Request.Cookies["c1"].Value.ToString();
            lbl2.Text = Request.Cookies["c2"].Value.ToString();
        }
    }
}