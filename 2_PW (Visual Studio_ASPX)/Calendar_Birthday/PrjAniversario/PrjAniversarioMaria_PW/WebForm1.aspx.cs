using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjAniversarioMaria_PW
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static List<string> lstName = new List<string>();
        static List<string> lstNextB = new List<string>();
        static List<string> lstAge = new List<string>();
        static List<int> lstDays = new List<int>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnC_Click(object sender, EventArgs e)
        {
            DateTime a = Convert.ToDateTime(C1.SelectedDate.ToShortDateString());
            DateTime b = DateTime.Today;
            DateTime c = (a.AddYears((DateTime.Now.Year - a.Year)));

            if (c <= b)
            {
                DateTime d = c.AddYears(1);
                string name = txtNome.Text + "";
                string next = d.ToShortDateString();
                string age = ((b.Year - a.Year) + 1).ToString();
                int days = (d - b).Days;


                lstName.Add(name);
                lstNextB.Add(next);
                lstAge.Add(age);
                lstDays.Add(days);

                txtNome.Text = "";
            }
            else
            {
                string name = txtNome.Text + "";
                string next = c.ToShortDateString();
                string age = ((b.Year - a.Year) + 1).ToString();
                int days = (c - b).Days;


                lstName.Add(name);
                lstNextB.Add(next);
                lstAge.Add(age);
                lstDays.Add(days);

                txtNome.Text = "";
            }
        }

        protected void btnM_Click(object sender, EventArgs e)
        {
            lblMostar.Text = "";
            string f = "";

            for (int i = 0; i < lstName.Count; i++)
            {
                f = lblMostar.Text + lstName.ElementAt(i) + " irá fazer: " + lstAge.ElementAt(i) + " anos " + " no dia: " + lstNextB.ElementAt(i) + ". Faltam: " + lstDays.ElementAt(i) + " dias.";
                lblMostar.Text = f + "</br>";
            }
        }
    }
}