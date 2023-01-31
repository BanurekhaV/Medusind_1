using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project_Serialization
{
    //Json Serialization
    [Serializable]
    public class Customers
    {
        public string Name = "";
        public string City = "";
        public int Age=0;

        public string ToJson()
        {
            //WriteLine("hi");
            //    return "Using keyword";

            //Make a stream to serialize
            using (MemoryStream stream = new MemoryStream())
            {
                //serialize into the stream
                DataContractJsonSerializer serializer = new
                    DataContractJsonSerializer(typeof(Customers));
                serializer.WriteObject(stream, this);
                stream.Flush();

                //get the result as text
                stream.Seek(0, SeekOrigin.Begin);
                using (StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }

        public static Customers FromJson(string json)
        {
            //Make a stream to read from
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(json);
            writer.Flush();
            stream.Position = 0;

            //deserialize from the stream
            DataContractJsonSerializer serializer =
                new DataContractJsonSerializer(typeof(Customers));
            Customers cust = (Customers)serializer.ReadObject(stream);
            return cust;
        }

        public static void Main()
        {
            Customers customer = new Customers()
            {
                Name = "Marc",
                City = "New Jersey",
                Age = 35
            };
            // WriteLine(customer.Json());

            //calling serialize
            string str = customer.ToJson();
            Console.WriteLine(str);

            //deserialize
            Customers newcust = Customers.FromJson(str);
            Console.WriteLine(newcust.Age + " "+ newcust.City+ " "+ newcust.Name);
            Read();

        }
    }

}