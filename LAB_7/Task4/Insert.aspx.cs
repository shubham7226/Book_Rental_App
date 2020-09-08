using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dtContext = new DataClasses1DataContext())
            {
                student sdetails = new student {
                    name = TextBox2.Text.ToString(),
                    sem = TextBox3.Text.ToString(),
                    cpi=TextBox4.Text.ToString(),
                    contactno=TextBox5.Text.ToString(),
                    emailid=TextBox6.Text.ToString()
                };
                dtContext.students.InsertOnSubmit(sdetails);
                dtContext.SubmitChanges();
            }
            
        }
    }
}