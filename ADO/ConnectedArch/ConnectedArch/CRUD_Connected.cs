using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ConnectedArch
{
    class Region
    {
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }
        DataAccess da = new DataAccess();

        public void GetRegion()
        {
            Console.WriteLine("Enter RegionId ");
            RegionID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Description ");
            RegionDescription = Console.ReadLine();
        }
        public void DisplayRegion()
        {
            da.DisplayRegion();
        }

        public void GetScalar()
        {
            da.GetScalar();
        }

        public SqlDataReader GetProcedure()
        {
            SqlDataReader dr = da.Callprocedure();
            return dr;
        }
    }

    class DataAccess
    {
        //create all required objects
        SqlConnection con = null;
        SqlCommand cmd;

        public SqlConnection GetConnection()
        {
            con = new SqlConnection("Data Source=LAPTOP-TJJ7D977;Initial Catalog=Northwind;" +
                "Integrated Security=true;");
            con.Open();
            return con;
        }

        public void DisplayRegion()
        {
            try
            {
                con = GetConnection();
                SqlDataReader dr;
                string s = "Select * from Region";
                cmd = new SqlCommand(s, con);
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    Console.WriteLine(dr["RegionID"] + "  "+ dr["RegionDescription"]);
                }
            }
            catch(SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //scalar execution
        public void GetScalar()
        {
            con = GetConnection();
            cmd = new SqlCommand("select count(RegionID) from Region", con);
           int count= Convert.ToInt32(cmd.ExecuteScalar());
            Console.WriteLine("Number of Regions :{0}",count);
        }

        public SqlDataReader Callprocedure()
        {
            con = GetConnection();
            Console.WriteLine("Enter Customer ID :");
            string custid = Console.ReadLine();
            cmd = new SqlCommand("CustordersOrders", con);
            cmd.CommandType = CommandType.StoredProcedure;
            // cmd.Parameters.AddWithValue("@cid", custid); //or
            SqlParameter sqlparam = new SqlParameter("@customerid", custid);
            sqlparam.SqlDbType = SqlDbType.VarChar;
            sqlparam.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(sqlparam);
            SqlDataReader sdr;
            sdr = cmd.ExecuteReader();
            return sdr;
            //while(sdr.Read())
            //{
            //    Console.WriteLine(sdr["OrderID"] + " " + sdr["OrderDate"] + " "+ sdr["RequiredDate"]+ " "+ sdr["ShippedDate"]);
            //}

            //con.Close();
        }
    }

    //client class
    class CRUD_Connected
    {
        static void Main()
        {
            Region region = new Region();
            // region.DisplayRegion();
            // region.GetScalar();
            SqlDataReader mydr=region.GetProcedure();
            //region.GetProcedure();
            while (mydr.Read())
            {
                Console.WriteLine("OrderID :" + mydr["OrderID"]);
                Console.WriteLine("Order Date :" + mydr["OrderDate"]);                               
            }
            Console.Read();
        }

    }
}
