using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CalculatorServiceWCF
{
    [DataContract]
    public class Employee
    {
        //private fields
        public int id;        
        string name;
        string gender;
        DateTime dob;

        //public properties included for serialization by marking them as DataMember
        [DataMember(Order =1)]
        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        [DataMember(Order = 2)]
        public string _name
        {
            get { return name; }
            set { name = value; }
        }
        [DataMember(Order = 4)]
        public string  _gender
        {
            get { return gender; }
            set { gender = value; }
        }
        [DataMember(Order = 3)]
        public DateTime _dob
        {
            get { return dob; }
            set { dob = value; }
        }
    }
}
