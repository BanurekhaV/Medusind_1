using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace MessageService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SimpleService1" in both code and config file together.
    [ServiceBehavior(ConcurrencyMode=ConcurrencyMode.Reentrant)]
    public class SimpleService1 : IReportService //,  ISimpleService1
    {
       // public void RequestMethod2(string s)
       // {
       //     throw new NotImplementedException();
       // }

       //// implementation code for request-reply
       // public string RequestReplyMethod()
       // {
       //     DateTime starttime = DateTime.Now;
       //     Thread.Sleep(3000);
       //     DateTime endtime = DateTime.Now;

       //     return endtime.Subtract(starttime).Seconds.ToString();
       // }
       // public void OneWayMethod()
       // {
       //     Thread.Sleep(3000);
           
       // }

       // public void OneWayMethod2(string s)
       // {
       //     throw new NotImplementedException();
       // }

        public void ProcessReport()
        {
            for(int i=0;i<=100;i++)
            {
                Thread.Sleep(100);

                //get the callback channel to send status to the client
                OperationContext.Current.GetCallbackChannel<IReportServiceCallBack>().ShowStatus(i);
            }
        }
    }
}
