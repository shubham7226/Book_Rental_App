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
    public partial class Delete : System.Web.UI.Page
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
            db_init();
            con.Open();
            da.Fill(ds, "Student");
            con.Close();
            int id = Convert.ToInt32(TextBox1.Text);
            DataRow rowToDelete = ds.Tables["Student"].
            AsEnumerable().FirstOrDefault(row => row.Field<int>("Id") == id);
            if (rowToDelete != null)
            {
                rowToDelete.Delete();
            }
            da.Update(ds, "Student");
            ds.AcceptChanges();
        }
    }
}