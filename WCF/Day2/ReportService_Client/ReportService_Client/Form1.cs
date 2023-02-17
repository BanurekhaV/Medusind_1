using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;

namespace ReportService_Client
{
   // [CallbackBehavior(UseSynchronizationContext =false)]
    public partial class Form1 : Form, ServiceReference1.IReportServiceCallback
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ShowStatus(int percentagecompletion)
        {
             textBox1.Text = percentagecompletion.ToString() + "% completed";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InstanceContext ic = new InstanceContext(this);
            ServiceReference1.ReportServiceClient client = new ServiceReference1.ReportServiceClient(ic);
            client.ProcessReport();
        }
    }
}
