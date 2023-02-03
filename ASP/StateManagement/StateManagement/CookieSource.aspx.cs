using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class CookieSource : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRedirect_Click(object sender, EventArgs e)
        {
            //persistant cookies

            //HttpCookie hc = new HttpCookie("Mycookie");
            //hc["d1"] = txtuname.Text;
            //hc["d2"] = txtpass.Text;
            //Response.Cookies.Add(hc);
            //hc.Expires = DateTime.Now.AddMinutes(5);
            //Response.Redirect("CookieDestination.aspx");

            //non persistant cookie

            Response.Cookies["c1"].Value = txtuname.Text;
            Response.Cookies["c2"].Value = txtpass.Text;
            Response.Redirect("CookieDestination.aspx");
        }
    }
}