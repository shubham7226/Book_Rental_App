using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab__7
{
    public partial class allproduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetData();
        }
        private void GetData()
        {
            DataClasses1DataContext dbContext = new DataClasses1DataContext();
            var data = from product in dbContext.products select product;
            GridView1.DataSource = data;
            GridView1.DataBind();
        }
    }
}