using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class HiddenFields : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStore_Click(object sender, EventArgs e)
        {
            HiddenField1.Value = txtuname.Text;
            HiddenField2.Value = txtpass.Text;
            txtpass.Text = "";
            txtuname.Text = "";
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
             Label1.Text = HiddenField1.Value + " " + HiddenField2.Value;
            

        }
    }
}