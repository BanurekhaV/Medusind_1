using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserControlsPrj
{
    
    [ToolboxData("<{0}:WebCustomControl1 runat=server></{0}:WebCustomControl1>")]
    public class WebCustomControl1 : CompositeControl
    {
        TextBox textbox;
        ImageButton imgbutton;
        Calendar calendar;

        [Category("Appearance")]
        [Description("To set an Image for the Calandar Image Button")]

        public string imgbuttonUrl
        {
            get
            {
                EnsureChildControls();
                return imgbutton.ImageUrl != null ? imgbutton.ImageUrl : string.Empty;
            }
            set
            {
                EnsureChildControls();
                imgbutton.ImageUrl = value;
            }
        }

        protected override void RecreateChildControls()
        {
            EnsureChildControls();
        }
        protected override void CreateChildControls()
        {
            Controls.Clear();
            textbox = new TextBox();
            textbox.ID = "txtdate";
            textbox.Width = Unit.Pixel(90);

            imgbutton = new ImageButton();
            imgbutton.ID = "imgcalendar";

            //add an event for the imgage button
            imgbutton.Click += new ImageClickEventHandler(imgbutton_Click);

            calendar = new Calendar();
            calendar.ID = "calendarcontrol";
            calendar.Visible = false;
            calendar.SelectionChanged += new EventHandler(calendar_SelectionChanged);

            //add the child controls to the webcustom control 
            this.Controls.Add(textbox);
            this.Controls.Add(imgbutton);
            this.Controls.Add(calendar);           
        }

        private void calendar_SelectionChanged(object sender, EventArgs e)
        {
            textbox.Text = calendar.SelectedDate.ToShortDateString();
            calendar.Visible = false;
        }

        private void imgbutton_Click(object sender, ImageClickEventArgs e)
        {
           if(calendar.Visible)
            {
                calendar.Visible = false;
            }
           else
            {
                calendar.Visible = true;
            }
        }

        protected override void Render(HtmlTextWriter writer)
        {
            textbox.RenderControl(writer);
            imgbutton.RenderControl(writer);
            calendar.RenderControl(writer);
        }
        protected override void RenderContents(HtmlTextWriter output)
        {
            //output.Write(Text);
        }
    }
}
