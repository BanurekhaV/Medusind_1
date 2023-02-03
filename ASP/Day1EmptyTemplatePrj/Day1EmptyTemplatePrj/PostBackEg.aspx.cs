using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day1EmptyTemplatePrj
{
    public partial class PostBackEg : System.Web.UI.Page
    {
        int ClicksCount = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
           if(!IsPostBack)
            {
                TextBox1.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*Step 1
            ClicksCount = ClicksCount + 1;
            TextBox1.Text = ClicksCount.ToString();*/

            //step2  using ViewState Variable
            /* if(ViewState["Clicks"]!=null)
             {
                 ClicksCount = (int)ViewState["Clicks"] + 1;
             }
             TextBox1.Text = ClicksCount.ToString();
             ViewState["Clicks"] = ClicksCount;*/

            //step 3 : without viewstate explicitly declared
            //since all asp controls have a viewstate variable to maintain the state
            ClicksCount = Convert.ToInt32(TextBox1.Text) + 1;
            TextBox1.Text = ClicksCount.ToString();

        }
    }
}