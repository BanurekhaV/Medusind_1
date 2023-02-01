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
            //InsertData();
            DeleteData();
           // SelectData();
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
                    Console.WriteLine("Salary :" + dr[3]);
                    Console.WriteLine("Dept Id :" + dr[5]);
                }
            }
            catch(SqlException se)
            {
                Console.WriteLine("Error Occured in the database.. Contact Admin");
            }
        }

        static void InsertData()
        {
            conn = getConnection();
            //the below is hard coded values, which is not as per prog. std.
            // cmd = new SqlCommand("insert into employee values(501,'Samyuktha','Female',40000,'2020/02/01',2,'00077')");
           
            Console.WriteLine("Enter Employee Details :");
            int eid = Convert.ToInt32(Console.ReadLine());
            string ename = Console.ReadLine();
            string egender = Console.ReadLine();
            float esal = Convert.ToSingle(Console.ReadLine());
            string edoj = Console.ReadLine();
            int edid = Convert.ToInt32(Console.ReadLine());
            string ephone = Console.ReadLine();

            cmd = new SqlCommand("insert into employee values(@ecode,@empname,@egen,@esalary,@empdoj,@depid,@eph)");
            cmd.Parameters.AddWithValue("@ecode", eid);
            cmd.Parameters.AddWithValue("@empname", ename);
            cmd.Parameters.AddWithValue("@egen", egender);
            cmd.Parameters.AddWithValue("@esalary", esal);
            cmd.Parameters.AddWithValue("@empdoj", edoj);
            cmd.Parameters.AddWithValue("@depid", edid);
            cmd.Parameters.AddWithValue("@eph", ephone);
            cmd.Connection = conn;
            int noofrows=cmd.ExecuteNonQuery();
            if(noofrows>0)
            {
                Console.WriteLine("Record Inserted Successfully");
            }
            else
                Console.WriteLine("Insertion Failed..");
        }

        static void DeleteData()
        {
            conn = getConnection();
            Console.WriteLine("Enter Emp Id to Delete:");
            int ecode = Convert.ToInt32(Console.ReadLine());
            SqlCommand cmd1 = new SqlCommand("select * from employee where empid=@ecode", conn);
            cmd1.Parameters.AddWithValue("@ecode", ecode);
            dr=cmd1.ExecuteReader();
            while(dr.Read())
            {
                for(int i=0; i<dr.FieldCount;i++)
                {
                    Console.WriteLine(dr[i]);
                }
            }
            conn.Close();
            Console.WriteLine("Are You sure to delete this Record ? (Y/N)");
            string status = Console.ReadLine();
            if(status=="y" || status=="Y")
            {
                cmd = new SqlCommand("delete from employee where empid=@ecode", conn);
                cmd.Parameters.AddWithValue("@ecode", ecode);
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Record deleted successfully");
            }
        }

        static void UpdateData()
        {

        }
    }
}
