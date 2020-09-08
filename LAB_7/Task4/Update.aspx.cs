using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel1.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dtContext = new DataClasses1DataContext())
            {
                int sid = Int32.Parse(TextBox1.Text.ToString());
                student sdetails = dtContext.students.SingleOrDefault(x => x.id == sid);

                sdetails.name = TextBox2.Text.ToString();
                sdetails.sem = TextBox3.Text.ToString();
                sdetails.cpi = TextBox4.Text.ToString();
                sdetails.contactno = TextBox5.Text.ToString();
                sdetails.emailid = TextBox6.Text.ToString();
                
                dtContext.SubmitChanges();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Panel1.Visible = true;
            using (DataClasses1DataContext dtContext = new DataClasses1DataContext())
            {
                int id = Int32.Parse(TextBox1.Text.ToString());
                student sdetails = dtContext.students.SingleOrDefault(x => x.id == id);

                TextBox2.Text = sdetails.name.ToString();
                TextBox3.Text = sdetails.sem.ToString();
                TextBox4.Text = sdetails.cpi.ToString();
                TextBox5.Text = sdetails.contactno.ToString();
                TextBox6.Text = sdetails.emailid.ToString();


                dtContext.SubmitChanges();
            }
        }
    }
}