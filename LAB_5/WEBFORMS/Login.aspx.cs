using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab5_task2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "user1" && TextBox2.Text == "user10702")
            {
                Session["name"] = TextBox1.Text;
                Session["psw"] = TextBox2.Text;
                Response.Redirect("Home.aspx");
            }
            else
            {
                Label1.Text = "Incorrect credentials";
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}