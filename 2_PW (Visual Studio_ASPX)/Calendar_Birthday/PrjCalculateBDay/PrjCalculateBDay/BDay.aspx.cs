using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjCalculateBDay
{
    public partial class BDay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnCa_Click(object sender, EventArgs e)
        {

        }

        protected void calendarBDay_SelectionChanged(object sender, EventArgs e)
        {
            txtBDay.Text = calendarBDay.SelectedDate.ToShortDateString();
        }

        protected void btnCal_Click(object sender, EventArgs e)
        {
            /*DateTime Data = DateTime.Today;
            DateTime Date = DateTime.Parse(txtBDay.Text);
            lblResult.Text = (Data.Year - Date.Year).ToString();*/

            DateTime a = DateTime.Parse(txtBDay.Text);
            DateTime b = DateTime.Today;
            TimeSpan time = b - a;
            DateTime date = new DateTime(time.Ticks);
            lblResult.Text = ((date.Year-1 + " Year(s) ") + (date.Month-1 + " Month(s) ") + (date.Day-1 + " Day(s)")).ToString();
                
        }

        
    }
}