using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day1EmptyTemplatePrj
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write("Init" + "<br/>");
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Page Load" + "<br/>");
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write("Pre Render" + "<br/>");
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write(" Load Complete" + "<br/>");
        }
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write("PreLoad" + "<br/>");
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write("Init Complete" + "<br/>");
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write("Pre Init" + "<br/>");
        }

        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Response.Write("Render Complete" + "<br/>");
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
           // Response.Write("Page UnLoad" + "<br/>");
        }
    }
}