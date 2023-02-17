using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace CalculatorServiceWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CalculatorService" in both code and config file together.
    public class CalculatorService : ICalculatorService
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public int Add(int x, int y)
        {
            return x + y;
        }

        public string GetMessage(string name)
        {
            return "Hello and Welcome" + " " + name;
        }

        public Employee GetEmployee(int id)
        {
            Employee e = new Employee();
            con = new SqlConnection("Data Source=laptop-tjj7d977; initial catalog=MedusindDb;" +
                "Integrated security=true;");
            con.Open();
            cmd = new SqlCommand("sp_GetEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@id";
            param.Value = id;
            cmd.Parameters.Add(param);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                e._id = Convert.ToInt32(dr["Id"]);
                e._name = dr["EName"].ToString();
                e._gender = dr["Gender"].ToString();
                e._dob = Convert.ToDateTime(dr["DOB"]);
            }
            return e;
        }
              
        public void SaveEmployee(Employee employee)
        {
           // Employee e = new Employee();
            con = new SqlConnection("Data Source=laptop-tjj7d977; initial catalog=MedusindDb;" +
                "Integrated security=true;");
            con.Open();
            cmd = new SqlCommand("sp_SaveEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@id";
            param1.Value = employee._id;
            cmd.Parameters.Add(param1);

            SqlParameter param2 = new SqlParameter();
            param2.ParameterName = "@ename";
            param2.Value = employee._name;
            cmd.Parameters.Add(param2);

            SqlParameter param3 = new SqlParameter();
            param3.ParameterName = "@gender";
            param3.Value = employee._gender;
            cmd.Parameters.Add(param3);

            SqlParameter param4 = new SqlParameter();
            param4.ParameterName = "@dob";
            param4.Value = employee._dob;
            cmd.Parameters.Add(param4);
            cmd.ExecuteNonQuery();
        }
    }
}
