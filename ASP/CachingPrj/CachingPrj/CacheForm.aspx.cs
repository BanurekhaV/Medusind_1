using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace CachingPrj
{
    public partial class CacheForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // getting all products without any filter
            //string connectionString = "Data Source=Laptop-TJJ7D977; initial catalog=MedusindDB;" +
            //    "integrated security = true; ";
            //SqlConnection con = new SqlConnection(connectionString);
            //SqlDataAdapter sda = new SqlDataAdapter("spGetProducts", con);
            //sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            //DataSet ds = new DataSet();
            //sda.Fill(ds);
            //GridView1.DataSource = ds;
            //GridView1.DataBind();

            //getting either all products or specific product
            if(!IsPostBack)
            {
                GetProductByName("All");
            }
            else
            {
                Response.Cache.SetExpires(DateTime.Now.AddSeconds(30)); //duration
                Response.Cache.VaryByParams["None"] = true;  //specifying if we are caching multiple responses of the page or not
                Response.Cache.SetCacheability(HttpCacheability.ServerAndPrivate); //location
            }

            Label1.Text = "This Page is Cached at :" + DateTime.Now.ToString();
        }

        protected void GetProductByName(string Productname)
        {
            string connectionString = "Data Source=Laptop-TJJ7D977; initial catalog=MedusindDB;" +
                "integrated security = true; ";
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter("spGetProducts", con);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@Pname";
            param.Value = Productname;
            sda.SelectCommand.Parameters.Add(param);

            DataSet ds = new DataSet();
            sda.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProductByName(DropDownList1.SelectedValue);
        }
    }
}