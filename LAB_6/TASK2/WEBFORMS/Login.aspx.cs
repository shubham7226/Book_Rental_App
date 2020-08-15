using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Login : System.Web.UI.Page
    {
        DataSet ds;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        string constring;
        SqlCommandBuilder builder;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        void db_init()
        {
            constring = WebConfigurationManager.
            ConnectionStrings["Connection"].ConnectionString;
            con = new SqlConnection(constring);
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from [User] where userid='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            builder = new SqlCommandBuilder(da);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            db_init();
            string filter = @"id=" + TextBox1.Text; 
            con.Open();
            da.Fill(ds, "User");
            con.Close();
            DataTable dt = ds.Tables["User"];
            if(dt.Rows.Count > 0)
            {
                Session["id"] = TextBox1.Text.ToString();
                Session["pname"] = TextBox2.Text.ToString();
                Response.Redirect("~/Product.aspx");
            }
            else
            {
                Label1.Text = "Enter correct Credentials";
            }

        }
    }
}