using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ValidationLibrary;

namespace ValidationPrj
{
    public partial class Validate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnregister_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Name = Textname.Text;
            reg.Password = Textpassword.Text;
            reg.ComparePassword = Textcpassword.Text;
            reg.Age = Convert.ToInt32(Textage.Text);
            reg.Email = Textemail.Text;
            var c = new ValidationContext(reg);
            var r = new List<ValidationResult>();
            //Validating the given object, withon the context, giving away the results, and
            //validating all properties (if set to false, will validate only the first property
            var isValid = Validator.TryValidateObject(reg, c, r, true);
            if (!isValid)
            {
                foreach (var errlist in r)
                {
                    Response.Write(errlist.ErrorMessage.ToString());
                    Response.Write("<br/>");
                }
                return;
            }
            //Session["email"] = Textemail.Text.ToString();
            //Session["name"] = Textname.Text.ToString();
            //Response.Redirect("CustomValidation.aspx");
        }
    }
}