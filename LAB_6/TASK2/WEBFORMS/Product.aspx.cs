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
    public partial class Product : System.Web.UI.Page
    {
        DataSet dss;
        string constring;
        SqlCommandBuilder builder;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindListBox();
            }
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            try
            {
                using (con)
                {
                    string command = "Select * from Product";
                    SqlCommand cmd = new SqlCommand(command, con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    GridView1.DataSource = rdr;
                    GridView1.DataBind();
                    con.Close();
                }
            }
            catch (Exception err)
            {
                Label1.Text = "Error reading the datastore: ";
                Label1.Text += err.Message;
            }

        }
        public void BindListBox()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = WebConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            string command = "Select * from Product";
            SqlCommand cmd = new SqlCommand(command, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlConnection conn = new SqlConnection(constring);
            DataSet ds = new DataSet();
            da.Fill(ds, "Product");
            ListBox1.DataSource = ds;
            ListBox1.DataTextField = "pname";
            ListBox1.DataValueField = "cost";
            ListBox1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string constringg = WebConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            SqlConnection conn = new SqlConnection(constringg);
            SqlCommand ccmd = new SqlCommand();
            ccmd.Connection = conn;
            ccmd.CommandText = "select * from [Order]";
            SqlDataAdapter da = new SqlDataAdapter(ccmd);
            dss = new DataSet();
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            conn.Open();
            da.Fill(dss, "Order");
            conn.Close();
            DataTable dt = dss.Tables["Order"];
            
            int total = 0,i=1,j=0;
            Label3.Text = "You have seleceted following items: ";
            foreach (ListItem item in ListBox1.Items)
            {
                
                    if (item.Selected)
                    {
                        int price = Int32.Parse(item.Value.ToString());
                        total += price;
                        DataRow dr = dt.NewRow();
                        dr["userid"] = Int32.Parse(Session["id"].ToString());
                        dr["pid"] = Int32.Parse(i.ToString());
                        dt.Rows.Add(dr);
                        da.Update(dss, "Order");
                    j++;
                    }
                    
                i++;
            }
            HttpCookie cookie = new HttpCookie("price1");
            cookie["price"] = total.ToString();
            Response.Cookies.Add(cookie);
            Response.Redirect("~/Order.aspx");
            

        }
    }
}