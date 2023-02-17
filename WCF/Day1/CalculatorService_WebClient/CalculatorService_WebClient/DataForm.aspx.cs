using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorService_WebClient
{
    public partial class DataForm : System.Web.UI.Page
    {
        Employee_CalculatorService.CalculatorServiceClient client;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        
        protected void BtnGetEmployee_Click(object sender, EventArgs e)
        {
            client = new Employee_CalculatorService.CalculatorServiceClient();

            Employee_CalculatorService.Employee serviceemployee = new Employee_CalculatorService.Employee();
            serviceemployee=client.GetEmployee(Convert.ToInt32(Textid.Text));

            Textname.Text = serviceemployee._name;
            Textgender.Text = serviceemployee._gender;
            Textdob.Text = serviceemployee._dob.ToString();
        }
    }
}