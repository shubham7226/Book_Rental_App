using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab5_task2
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (Session["username"] != null)
            {
                Label1.Text = "Wellcome, " + Session["username"].ToString();


            }

        }
        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedIndex == 0)
            {
                ListBox3.Items.Clear();
                ListItem e1 = new ListItem("Laptop ", "46999");
                ListItem e2 = new ListItem("Asus rog 2", "33999");
                ListItem e3 = new ListItem("MI note 5", "13699");
                ListItem e4 = new ListItem("PenDrive", "999");
                ListItem e5 = new ListItem("Memory card", "799");
                ListBox3.Items.Add(e1);
                ListBox3.Items.Add(e2);
                ListBox3.Items.Add(e3);
                ListBox3.Items.Add(e4);
                ListBox3.Items.Add(e5);

            }
            if (RadioButtonList1.SelectedIndex == 1)
            {
                ListBox3.Items.Clear();
                ListItem b1 = new ListItem("Invisible Man", "555");
                ListItem b2 = new ListItem("Wing of fire", "655");
                ListItem b3 = new ListItem("Nirmala", "754");
                ListItem b4 = new ListItem("To Kill a Mockingbird", "111");
                ListItem b5 = new ListItem("Don Quixote", "986");
                ListBox3.Items.Add(b1);
                ListBox3.Items.Add(b2);
                ListBox3.Items.Add(b3);
                ListBox3.Items.Add(b4);
                ListBox3.Items.Add(b5);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ListItem add = new ListItem();
            add = ListBox3.SelectedItem;
            ListBox4.Items.Add(add);

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ListItem remove = new ListItem();
            remove = ListBox4.SelectedItem;
            ListBox4.Items.Remove(remove);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int total = 0, i = 1;
            String string1 = "";
            foreach (ListItem item in ListBox4.Items)
            {
                int price = Int32.Parse(item.Value.ToString());
                total += price;
                string1 += i + ")" + item.Text + ", " + item.Value.ToString() + "   ";
                i++;
            }
            HttpCookie cookie = new HttpCookie("order");
            cookie["list"] = string1;
            cookie["price"] = total.ToString();
            Response.Cookies.Add(cookie);
            Response.Redirect("~/Order.aspx");
        }

        protected void ListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}