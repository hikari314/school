using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjCalendar__BDay_v2_
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            txtBDAY.Text = Calendar1.SelectedDate.ToShortDateString();
        }

        protected void btnCheck_Click(object sender, EventArgs e)
        {
            //DateTime b = DateTime.Parse(txtBDAY.Text);
            //DateTime b1 = b.AddYears(1);
            //DateTime a = DateTime.Today;

            //var year = (b1.Year - a.Year);
            //var days = (b1.DayOfYear - a.DayOfYear);
                
            //lblResult.Text = "This person will have" + (year-1) + "in " + days + "days" ;

            var a = DateTime.Parse(txtBDAY.Text);
            var b = a.AddYears(1);
            var c = DateTime.Parse(DateTime.Now.ToShortDateString());
            var years = (b.Year - c.Year);
            var days = (b.DayOfYear - c.DayOfYear);

            lblResult.Text = (years + 1) + "faltam " + (-1 * days);
        }
    }
}