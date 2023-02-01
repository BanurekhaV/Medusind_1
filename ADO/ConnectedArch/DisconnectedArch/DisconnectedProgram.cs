using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DisconnectedArch
{
    class DisconnectedProgram
    {
        static void Main(string[] args)
        {
            SqlConnection con;
            SqlDataAdapter da;
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-TJJ7D977;Initial Catalog=Northwind;" +
                "Trusted_Connection=true;");
                da = new SqlDataAdapter("select * from Region", con);
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "NorthwindRegion");
                DataTable dt = ds.Tables["NorthwindRegion"];

                //to access the data in the datatable of the Dataset
                foreach(DataRow drow in dt.Rows)
                {
                    foreach(DataColumn dcol in dt.Columns)
                    {
                        Console.Write(drow[dcol]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }

                //Adding one more table to the dataset
                Console.WriteLine("---------------");
                da = new SqlDataAdapter("select * from shippers", con);
                da.Fill(ds, "NorthwindShipper");

                dt = ds.Tables["NorthwindShipper"];

                foreach (DataRow drow in dt.Rows)
                {
                    foreach (DataColumn dcol in dt.Columns)
                    {
                        Console.Write(drow[dcol]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }

                //calling a stored procedure
                Console.WriteLine("------------------");
                SqlDataAdapter da1 = new SqlDataAdapter("[ten most expensive products]", con);

                da1.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataTable dt1 = new DataTable();
                da1.Fill(dt1);

                foreach(DataRow r in dt1.Rows)
                {
                    foreach(DataColumn c in dt1.Columns)
                    {
                        Console.Write(r[c]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                //da.Fill(ds); //refresh the data

                ////create a new row for a datatable in the dataset
                //DataRow row = ds.Tables["NorthwindRegion"].NewRow();

                ////give values to the newly created row 
                //row["RegionID"] = 7;
                //row["RegionDescription"] = "SampleRegion";

                ////adding the row to the datatable
                //ds.Tables["NorthwindRegion"].Rows.Add(row);

                //SqlCommandBuilder scb = new SqlCommandBuilder(da);
                ////  da.UpdateCommand = scb.GetUpdateCommand();
                //da.InsertCommand = scb.GetInsertCommand();
                //da.Update(ds,"NorthwindRegion");
                //Console.WriteLine("--------after insertion--------");
                //da.Fill(ds);  //to refresh after inserting a record
                //dt = ds.Tables["NorthwindRegion"]; // to point to the beginning of the datatable

                //foreach (DataRow drow1 in dt.Rows)
                //{
                //    foreach (DataColumn dcol1 in dt.Columns)
                //    {
                //        Console.Write(drow1[dcol1]);
                //        Console.Write(" ");
                //    }
                //    Console.WriteLine();
                //}

            }
            catch(SqlException se)
            {
                Console.WriteLine(se);
            }

            //to add a record to the region table
            Console.Read();

           
        }
    }
}
