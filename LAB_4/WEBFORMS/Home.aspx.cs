using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }
        protected void UserCustomValidate(object source, ServerValidateEventArgs args)
        {
            string str = args.Value;
            args.IsValid = false;
            if ((str[0] == 'A' || str[0] == 'B') && str.Length == 10)
            {
                args.IsValid = true;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex == 1)
            {
                DropDownList2.Items.Clear();
                ListItem city1 = new ListItem("Ahmedabad", "Ahmedabad");
                ListItem city2 = new ListItem("Vadodara", "Vadodara");
                DropDownList2.Items.Add(city1);
                DropDownList2.Items.Add(city2);

            }
            else if (DropDownList1.SelectedIndex == 2)
            {
                DropDownList2.Items.Clear();
                ListItem city1 = new ListItem("Mumbai", "Mumbai");
                ListItem city2 = new ListItem("Pune", "Pune");
                DropDownList2.Items.Add(city1);
                DropDownList2.Items.Add(city2);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Label1.Text = "Full Name: " + TextBox1.Text;
                Label2.Text = "Age: " + TextBox2.Text;
                Label3.Text = "Password: " + TextBox3.Text;
                Label4.Text = "Gender: " + RadioButtonList1.SelectedValue;
                Label5.Text = "Mobile No: " + TextBox5.Text;
                Label6.Text = "Hobbies ";

                foreach (ListItem lst in CheckBoxList1.Items)
                {
                    if (lst.Selected == true)
                    {
                        Label6.Text += lst.Text + ", ";
                    }
                }
                Label7.Text = "State: " + DropDownList1.SelectedValue;
                Label8.Text = "City: " + DropDownList2.SelectedValue;
                Label9.Text = "Pan Number: " + TextBox6.Text;
            }
           
            
        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}