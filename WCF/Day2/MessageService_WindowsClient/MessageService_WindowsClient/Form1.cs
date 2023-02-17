using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageService_WindowsClient
{
    [CallbackBehavior(UseSynchronizationContext =false)]
    public partial class Form1 : Form, ServiceMessage.IReportServiceCallback
    {
       // ServiceMessage.SimpleService1Client client;
        public Form1()
        {
            InitializeComponent();
            // client = new ServiceMessage.ReportServiceClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add("Request Method 2 Started @"
                    + DateTime.Now.ToString());
               // client.RequestMethod2("Method2");
                listBox1.Items.Add("Request Method 2 completed @"
                    + DateTime.Now.ToString());
                listBox1.Items.Add("");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add("Request -Reply Method Started @"
                    + DateTime.Now.ToString());
                button1.Enabled = false;
              //  listBox1.Items.Add(client.RequestReplyMethod());
                button1.Enabled = true;
                listBox1.Items.Add("Request -Reply Method Completed @"
                    + DateTime.Now.ToString());
                listBox1.Items.Add("");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add("Request Method 2 Started @"
                    + DateTime.Now.ToString());
              //  client.OneWayMethod2("Method2");
                listBox1.Items.Add("Request Method 2 completed @"
                    + DateTime.Now.ToString());
                listBox1.Items.Add("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void OneWay_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add("Request -Reply Method Started @"
                    + DateTime.Now.ToString());
                OneWay.Enabled = false;
               // client.OneWayMethod();
               OneWay.Enabled = true;
                listBox1.Items.Add("Request -Reply Method Completed @"
                    + DateTime.Now.ToString());
                listBox1.Items.Add("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_processreport_Click(object sender, EventArgs e)
        {
            InstanceContext icontext = new InstanceContext(this);
            ServiceMessage.ReportServiceClient rclient = new ServiceMessage.ReportServiceClient(icontext);
            rclient.ProcessReport();
        }

        public void ShowStatus(int percentCompletion)
        {
            textBox1.Text = percentCompletion.ToString() + " % Completed";
        }
    }
 }

