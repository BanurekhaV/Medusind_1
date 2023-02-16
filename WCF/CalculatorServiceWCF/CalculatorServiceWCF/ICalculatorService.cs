using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalculatorServiceWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculatorService" in both code and config file together.
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        int Add(int x, int y);

        [OperationContract]
        string GetMessage(string name);

        [OperationContract]
        Employee GetEmployee(int id);

        [OperationContract]
        void SaveEmployee(Employee employee);
    }
}
