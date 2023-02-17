using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace WindowsWishes_Client
{
    public partial class Form1 : Form
    {
        WishesRemotingSevices.IWisherService client;
        public Form1()
        {
            InitializeComponent();
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel);
            client = (WishesRemotingSevices.IWisherService)Activator.GetObject(
                typeof(WishesRemotingSevices.IWisherService), "tcp://localhost:8084/ShowWishes");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = client.ShowWishes(textBox2.Text);
        }
    }
}
