using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjCalendar_v3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static List<string> lstNames = new List<string>();
        static List<DateTime> lstDates = new List<DateTime>();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtDate.Text = Calendar1.SelectedDate.ToShortDateString();
        }

        protected void btnCheck_Click(object sender, EventArgs e)
        {
            lstDates.Add(Convert.ToDateTime(Calendar1.SelectedDate.ToShortDateString()));

            DateTime today = DateTime.Today;

            txtDate.Text = "";

            for (int a = 0; a < lstNames.Count; a++)
            {
                int year = today.Year - lstDates[a].Year + 1;
                DateTime bday = lstDates[a].AddYears(year);
                int days = (bday - today).Days;

                lblResult.Text = "In " + bday.ToShortDateString() + " will be his/her next birthday! He/she will be" + year + " year(s). " + days + " to go.";
            }
        }
       
    }
}