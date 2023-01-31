using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConnectedArch
{
    class Program
    {
        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        static void Main(string[] args)
        {
            SelectData();
            Console.Read();
        }

        static SqlConnection getConnection()
        {
            conn = new SqlConnection("data source=LAPTOP-TJJ7D977;Initial Catalog=MedusindDB;" +
                "Integrated Security=true;");
            conn.Open();
            return conn;
        }
        static void SelectData()
        {
            try
            {
                conn = getConnection();
                cmd = new SqlCommand("select * from Employee", conn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //Console.WriteLine(dr[0] + " | " + dr[1]+ " | " + dr[2] + " | " + dr[3]);
                    //or
                    Console.WriteLine("-------------");
                    Console.WriteLine("Employee Id:" + dr[0]);
                    Console.WriteLine("EmpName :" + dr[1]);
                }
            }
            catch(SqlException se)
            {
                Console.WriteLine("Error Occured in the database.. Contact Admin");
            }
        }
    }
}
