using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_XmlPrj
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }

        //method to populate data of product

        public static Product[] GetAllProducts()
        {
            Product[] products = new Product[4];
            products[0] = new Product { Id = 100, Name = "Pens", Category = "Stationary", Price = 20 };
            products[1] = new Product { Id = 101, Name = "Pencils", Category = "Stationary", Price = 10 };
            products[2] = new Product { Id = 102, Name = "Watches", Category = "Accessories", Price = 2000 };
            products[3] = new Product { Id = 103, Name = "USB", Category = "Electronics", Price = 350 };
            return products;
        }
    }
}
