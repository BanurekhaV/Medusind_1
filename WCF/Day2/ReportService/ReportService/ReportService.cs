using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace ReportService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ReportService" in both code and config file together.
 //  [ServiceBehavior(IncludeExceptionDetailInFaults =true)]
  //[ServiceBehavior(ConcurrencyMode =ConcurrencyMode.Reentrant)]
    public class ReportService : IReportService
    {
        public void ProcessReport()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(100);

                //get the callback channel to send status to the client
                OperationContext.Current.GetCallbackChannel<IReportServiceCallBack>().ShowStatus(i);
            }
        }
    }
}
