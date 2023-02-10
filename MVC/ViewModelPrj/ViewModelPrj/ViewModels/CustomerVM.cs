using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ViewModelPrj.ViewModels
{
    public class CustomerVM
    {
        [Key]
        //from customer.cs
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        //from Orders.cs
        public int OrderID { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
    }
}