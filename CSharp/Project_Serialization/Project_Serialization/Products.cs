using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Project_Serialization
{
    [Serializable]
    class Products
    {
        public int PID { get; set; }
        public string Pname { get; set; }
        [NonSerialized]        
        float PPrice = 60000.50f;

        public string Description = "HP Laptops Inc."; 
        static void Main(string[] args)
        {
            Products product = new Products()
            { PID = 1, Pname = "Laptops" };

            //to do Binary Serialization, we can use either BinaryFormatter class
            //or IFormatter interface
            IFormatter formatter = new BinaryFormatter();
            //or
            // BinaryFormatter bf = new BinaryFormatter();
            Stream stream = new FileStream("c:\\Banu\\OurFirstFile.txt", FileMode.Create, FileAccess.Write);
            //to actually serialise the object

            formatter.Serialize(stream, product);
            stream.Close();

            //let us deserialize the object and read it
            stream = new FileStream(@"c:\Banu\ourfirstfile.txt", FileMode.Open, FileAccess.Read);
            Products readproduct = (Products)formatter.Deserialize(stream);
            Console.WriteLine($"{readproduct.PID}, {readproduct.Pname}, {readproduct.PPrice}, {readproduct.Description}");
            
            //Normal object of products not involved in serialization
            Products p = new Products();
            Console.WriteLine(p.PPrice + " "+ p.Description);
            Console.Read();
        }
    }
}
