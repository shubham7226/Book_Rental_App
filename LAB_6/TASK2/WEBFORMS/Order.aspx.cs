using System;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Order : System.Web.UI.Page
    {
        DataSet ds;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        string constring;
        SqlCommandBuilder builder;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Welcome " + Session["id"];
            HttpCookie cookie = Request.Cookies["price1"];
            db_init();
            con.Open();
            da.Fill(ds, "Product");
            con.Close();
            DataTable dt = ds.Tables["Product"];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
               
                    Label2.Text += "<li>" + row["pname"].ToString() + "</li>";
                
            }
            Label3.Text = "Total Amount :-" + cookie["price"];

        }
        void db_init()
        {
            constring = WebConfigurationManager.
                ConnectionStrings["Connection"].ConnectionString;
            con = new SqlConnection(constring);
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select pname from Product,[Order] where Product.pid=[Order].pid";
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            builder = new SqlCommandBuilder(da);
        }
    }
}