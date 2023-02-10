using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day3EF_Codefirst.Models
{
    [Table("tblCar")]
    public class Car
    {
        [Key]
        public int CarNo { get; set; }
        public string CarName { get; set; }
        public string CarModel { get; set; }
        public decimal CarCost { get; set; }
    }
}