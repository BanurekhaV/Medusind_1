using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ExceptionService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMathsService" in both code and config file together.
    [ServiceContract]
    public interface IMathsService
    {
        [OperationContract]
        int Divide(int numerator, int denominator);
    }
}
