using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ReportService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IReportService" in both code and config file together.
    [ServiceContract(CallbackContract = typeof(IReportServiceCallBack))]
    public interface IReportService
    {
        [OperationContract(IsOneWay =true)]
        void ProcessReport();
    }

    public interface IReportServiceCallBack
    {
        [OperationContract(IsOneWay =true)]

        void ShowStatus(int percentagecompletion);

    }
}
