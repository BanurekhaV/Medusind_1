using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WishesRemotingSevices;

namespace WisherService
{
    public class WisherServicecls : MarshalByRefObject ,IWisherService
    {
        public string ShowWishes(string name)
        {
            return "Welcome" + " " + name;
        }
    }
}
