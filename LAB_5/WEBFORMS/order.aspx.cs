using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab5_task2
{
    public partial class order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["order"];
            if (cookie == null)
            {
                Label1.Text = "Data not stored";
            }
            else
            {
                Label1.Text = "List: " + cookie["list"];
                Label2.Text = "Total price: " + cookie["price"];
            }
        }
    }
}