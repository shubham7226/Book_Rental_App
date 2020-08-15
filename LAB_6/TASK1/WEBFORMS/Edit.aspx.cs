using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace WebApplication3
{
    public partial class Edit : System.Web.UI.Page
    {
        DataSet ds;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        string constring;
        SqlCommandBuilder builder;
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Visible = false;
        }
        void db_init()
        {
            constring = WebConfigurationManager.
            ConnectionStrings["Connection1"].ConnectionString;
            con = new SqlConnection(constring);
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Student where Id='" + TextBox1.Text + "'";
            da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            builder = new SqlCommandBuilder(da);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            db_init();
            string filter = @"id=" + TextBox1.Text; 
            con.Open();
            da.Fill(ds, "Student");
            con.Close();
            DataTable dt = ds.Tables["Student"];
            DataRow row = dt.Rows[0];
            TextBox2.Text = row["Name"].ToString(); 
            TextBox3.Text = row["Sem"].ToString();
            TextBox4.Text = row["Mob_No"].ToString();
            TextBox5.Text = row["Email_Id"].ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            db_init();
            con.Open();
            da.Fill(ds, "Student");
            con.Close();
            DataTable dt = ds.Tables["Student"];
            DataRow row = dt.Rows[0];
            row["Name"] = TextBox2.Text;
            row["Sem"] = TextBox3.Text;
            row["Mob_No"] = TextBox4.Text;
            row["Email_Id"] = TextBox5.Text;
            da.Update(ds, "Student");
        }
    }
}