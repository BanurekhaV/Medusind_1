using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MessageService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISimpleService1" in both code and config file together.
    //[ServiceContract]
    //public interface ISimpleService1
    //{
    //    [OperationContract]
    //    string RequestReplyMethod(); //will be a request-reply pattern

    //    [OperationContract(IsOneWay = false)]
    //    void RequestMethod2(string s); //will be a request-reply pattern

    //    [OperationContract(IsOneWay =true)]
    //    void OneWayMethod(); //will be a one-way pattern

    //    [OperationContract(IsOneWay = true)]
    //    void OneWayMethod2(string s); //will be a one way pattern
    //}

    [ServiceContract(CallbackContract =typeof(IReportServiceCallBack))]
    public interface IReportService
    {
        [OperationContract]
        void ProcessReport();
    }

    //callback Interface
    public interface IReportServiceCallBack
    {
        [OperationContract]
        void ShowStatus(int percentCompletion);
    }
}
