using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjCalendar
{
    public partial class Calendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCC_Click(object sender, EventArgs e)
        {

        }

        protected void cal1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            TextBox2.Text = Calendar2.SelectedDate.ToShortDateString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var a = Convert.ToDateTime(TextBox1.Text);
            var b = Convert.ToDateTime(TextBox2.Text);

            if (a > b)
            {
                Label1.Text = (a - b).Days.ToString();
            }
            else
            {
                Label1.Text = (b - a).Days.ToString();
            }
        }
    }
}