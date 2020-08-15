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
    public partial class Insert : System.Web.UI.Page
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            string constring = WebConfigurationManager.ConnectionStrings["Connection1"].ConnectionString;
            SqlConnection conn = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Student";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            ds = new DataSet();
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            conn.Open();
            da.Fill(ds, "Student");
            conn.Close();
            DataTable dt = ds.Tables["Student"];
            DataRow dr = dt.NewRow();
            dr["Name"] = TextBox2.Text;
            dr["Sem"] = TextBox3.Text;
            dr["Mob_No"] = TextBox4.Text;
            dr["Email_Id"] = TextBox5.Text;
            dt.Rows.Add(dr);
            da.Update(ds, "Student");

        }
    }
}