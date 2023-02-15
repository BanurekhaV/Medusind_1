using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Linq_XmlPrj
{
    class Program
    {
        static void Main(string[] args)
        {
            //add_New_Node();
            //insert_Node();
            //update_Node();
            update_Comment();
           // delete_Node();

            //1. create an XML document hard coded
            //XDocument xmldoc = new XDocument(
            //    new XDeclaration("1.0", "utf-8", "yes"),
            //    new XComment("A Sample XML Tree using LINQ to XML"),
            //    new XElement("Products",
            //    new XElement("Product", new XAttribute("Id", 100),
            //    new XElement("Name", "Pens"),
            //    new XElement("Category", "Stationary"),
            //    new XElement("Price", 20)),
            //    new XElement("Product", new XAttribute("Id", 101),
            //    new XElement("Name", "Pencils"),
            //    new XElement("Category", "Stationary"),
            //    new XElement("Price", 10)),
            //    new XElement("Product", new XAttribute("Id", 102),
            //    new XElement("Name", "Watches"),
            //    new XElement("Category", "Accessories"),
            //    new XElement("Price", 2000)),
            //    new XElement("Product", new XAttribute("Id", 103),
            //    new XElement("Name", "USB"),
            //    new XElement("Category", "Electronics"),
            //    new XElement("Price", 350))));

            //saving the above xml creation into an xml document
            //xmldoc.Save(@"C:\Banu\Medusind\M_B1\LINQToXML\Linq_XmlPrj\Linq_XmlPrj\xmlData\products.xml");

            //2, creating xml document using in-memory collection objet

            //XDocument xmldoc = new XDocument(
            //    new XDeclaration("1.0", "utf-8", "yes"),
            //    new XComment("Creating XML Tree using Linq to Xml"),
            //    new XElement("Products",
            //    from p in Product.GetAllProducts()
            //    select new XElement("Product", new XAttribute("Id", p.Id),
            //    new XElement("Name", p.Name),
            //    new XElement("Category", p.Category),
            //    new XElement("Price", p.Price))
            //    ));

            //saving the above xml creation into an xml document
            //  xmldoc.Save(@"C:\Banu\Medusind\M_B1\LINQToXML\Linq_XmlPrj\Linq_XmlPrj\xmlData\products.xml");
            Console.Read();

        }

        //3. querying an existing xml document using linq to xml descendants

        public static void with_Descendants()
        {
            IEnumerable<string> pname = from product in XDocument
                           .Load(@"C:\Banu\Medusind\M_B1\LINQToXML\Linq_XmlPrj\Linq_XmlPrj\xmlData\products.xml").Descendants("Product")
                                        where (int)product.Element("Price") > 300
                                        orderby (int)product.Element("Price") descending
                                        select product.Element("Name").Value;

            foreach (string p in pname)
            {
                Console.WriteLine(p);
            }
        }


        //4. Without Descendants

        public static void without_Descendants()
        {
            IEnumerable<string> prodname = from product in XDocument
                                    .Load(@"C:\Banu\Medusind\M_B1\LINQToXML\Linq_XmlPrj\Linq_XmlPrj\xmlData\products.xml")
                                    .Element("Products").Elements("Product")
                                           where (int)product.Element("Price") > 300
                                           orderby (int)product.Element("Price") descending
                                           select product.Element("Name").Value;

            foreach (string p in prodname)
            {
                Console.WriteLine(p);
            }

        }
        public static void add_New_Node()
        {
            XDocument xmldoc2 = XDocument.Load(@"C:\Banu\Medusind\M_B1\LINQToXML\Linq_XmlPrj\Linq_XmlPrj\xmlData\products.xml");
            xmldoc2.Element("Products").Add(
                new XElement("Product", new XAttribute("Id", 104),
                new XElement("Name", "Slip-On"),
                new XElement("Category", "Footware"),
                new XElement("price", 5000)
                ));

            xmldoc2.Save(@"C:\Banu\Medusind\M_B1\LINQToXML\Linq_XmlPrj\Linq_XmlPrj\xmlData\products.xml");
        }
        public static void insert_Node()
        {
            XDocument xmldoc2 = XDocument.Load(@"C:\Banu\Medusind\M_B1\LINQToXML\Linq_XmlPrj\Linq_XmlPrj\xmlData\products.xml");
            xmldoc2.Element("Products").Elements("Product")
                .Where(p=>p.Attribute("Id").Value=="100").FirstOrDefault()
                .AddAfterSelf(
                new XElement("Product", new XAttribute("Id", 105),
                new XElement("Name", "Floaters"),
                new XElement("Category", "Footware"),
                new XElement("price", 1700)
                ));

            xmldoc2.Save(@"C:\Banu\Medusind\M_B1\LINQToXML\Linq_XmlPrj\Linq_XmlPrj\xmlData\products.xml");
        }

        // update
        public static void update_Node()
        {
            XDocument xmldoc2 = XDocument.Load(@"C:\Banu\Medusind\M_B1\LINQToXML\Linq_XmlPrj\Linq_XmlPrj\xmlData\products.xml");
            xmldoc2.Element("Products").Elements("Product")
                .Where(p => p.Attribute("Id").Value == "103")
                .Select(p => p.Element("Price")).FirstOrDefault().SetValue(500);

            xmldoc2.Save(@"C:\Banu\Medusind\M_B1\LINQToXML\Linq_XmlPrj\Linq_XmlPrj\xmlData\products.xml");
        }

        //update Comment
        public static void update_Comment()
        {
            XDocument xmldoc2 = XDocument.Load(@"C:\Banu\Medusind\M_B1\LINQToXML\Linq_XmlPrj\Linq_XmlPrj\xmlData\products.xml");
            xmldoc2.Nodes().OfType<XComment>().FirstOrDefault().Value = "This is a XML Document's New Comment";

            xmldoc2.Save(@"C:\Banu\Medusind\M_B1\LINQToXML\Linq_XmlPrj\Linq_XmlPrj\xmlData\products.xml");
        }
        //delete a node
        public static void delete_Node()
        {
            XDocument xmldoc2 = XDocument.Load(@"C:\Banu\Medusind\M_B1\LINQToXML\Linq_XmlPrj\Linq_XmlPrj\xmlData\products.xml");
            //to delete a particular node
            xmldoc2.Root.Elements().Where(p => p.Attribute("Id").Value == "104").Remove();

            //to delete all nodes
            // xmldoc2.Root.Elements().Remove();

            //to delete a comment
            xmldoc2.Nodes().OfType<XComment>().Remove();

            xmldoc2.Save(@"C:\Banu\Medusind\M_B1\LINQToXML\Linq_XmlPrj\Linq_XmlPrj\xmlData\products.xml");
        }
    }
}
