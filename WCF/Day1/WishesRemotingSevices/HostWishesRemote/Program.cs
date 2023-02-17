using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace HostWishesRemote
{
    class Program
    {
        static void Main(string[] args)
        {
            WisherService.WisherServicecls remote = new WisherService.WisherServicecls();
            TcpChannel channel = new TcpChannel(8084);
            ChannelServices.RegisterChannel(channel);
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(WisherService.WisherServicecls), "ShowWishes",
                WellKnownObjectMode.Singleton);
            Console.WriteLine("Host Services Started @" + DateTime.Now.ToString());
            Console.Read();
        }
    }
}
