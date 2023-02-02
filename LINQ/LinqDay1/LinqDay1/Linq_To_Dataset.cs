using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LinqDay1
{
    class Linq_To_Dataset
    {
        static void Main()
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-TJJ7D977;Initial Catalog=MedusindDB;" +
                "Integrated Security=true;");
            string sqlstatement = "Select * from Department;" + "Select * from Employee;";

            //create the dataadapter to retrieve the data from the database/source
            SqlDataAdapter da = new SqlDataAdapter(sqlstatement, con);

            //create table mappings
            da.TableMappings.Add("Table", "Department");
            da.TableMappings.Add("Table1", "Employee");

            //create and fill the dataset
            DataSet ds = new DataSet();
            da.Fill(ds);

            //set the relation
            DataRelation relation = ds.Relations.Add(
                ds.Tables["Department"].Columns[0],
                ds.Tables["Employee"].Columns[5]);

            //create data table object
            DataTable dep = ds.Tables["Department"];
            DataTable emp = ds.Tables["Employee"];

            //Linq Query construction
            var queryout = from d in dep.AsEnumerable()
                        join e in emp.AsEnumerable()
                        on d.Field<int>("Deptid") equals
                        e.Field<int?>("Deptid")
                        select new
                        {
                            EmployeeId=e.Field<int>("Empid"),
                            EmployeeName=e.Field<string>("Empname"),
                            DepartmentId=d.Field<int>("Deptid"),
                            DepartmentName=d.Field<string>("Deptname")
                        };

            foreach(var item in queryout)
            {
                Console.WriteLine("Id= {0},\t Name= {1}, \tDept ={2} and \t deptname={3}", item.EmployeeId,
                    item.EmployeeName,item.DepartmentId,item.DepartmentName);
            }
            Console.Read();
        }
    }
}
