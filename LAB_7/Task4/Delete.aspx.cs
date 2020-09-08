using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dtContext = new DataClasses1DataContext())
            {
                int sid = Int32.Parse(TextBox1.Text.ToString());
                student sdetails = dtContext.students.SingleOrDefault(x => x.id == sid);
                dtContext.students.DeleteOnSubmit(sdetails);

                dtContext.SubmitChanges();
            }
        }
    }
}