using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorService_WindowsClient
{
    public partial class Form1 : Form
    {
        WindowsCalculator.CalculatorServiceClient winclient;
        public Form1()
        {
            InitializeComponent();
             winclient =
                new WindowsCalculator.CalculatorServiceClient("NetTcpBinding_ICalculatorService");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = winclient.Add(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = winclient.GetMessage(textBox3.Text);
        }
    }
}
