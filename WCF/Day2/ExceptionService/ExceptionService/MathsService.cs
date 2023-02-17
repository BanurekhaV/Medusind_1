using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ExceptionService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MathsService" in both code and config file together.
    public class MathsService : IMathsService
    {
        public int Divide(int numerator, int denominator)
        {
            return numerator / denominator;
        }
    }
}
