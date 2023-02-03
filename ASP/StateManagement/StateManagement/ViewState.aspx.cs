using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
   
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }                    

        protected void btnStore_Click(object sender, EventArgs e)
        {
            ViewState["uname"] = txtuname.Text;
            ViewState["upass"] = txtpass.Text;
            //clear the textboxes 
            txtuname.Text = "";
            txtpass.Text = string.Empty;
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
              Label1.Text = ViewState["uname"].ToString() + ViewState["upass"].ToString();
           // Response.Redirect("checkform.aspx");
        }
    }
}