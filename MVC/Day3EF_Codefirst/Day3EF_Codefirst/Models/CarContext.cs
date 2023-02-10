using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Day3EF_Codefirst.Models
{
    public class CarContext : DbContext
    {
        public CarContext():base("name=Motors")
        {

        }

        //add the dbsets for the corresponding model classes
        public DbSet<Car> Cars { get; set; }
    }
}