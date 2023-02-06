using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagement
{
    public partial class ApplicationState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnClick_Click(object sender, EventArgs e)
        {
            int count = 0;
            if(Application["Visits"]!=null)
            {
                count = Convert.ToInt32(Application["Visits"].ToString());
            }
            count = count + 1;
            Application["Visits"] = count;

            //to clear any deadlock situations
            //Application.UnLock();
            lblstatus.Text = "Total Visits =" + count.ToString();
        }
    }
}