using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjQuiz_Maria_2DS
{
    public partial class FinishWG : System.Web.UI.Page
    {
        int points = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            String GK1 = (String)Session["gk1"];
            String GK2 = (String)Session["gk2"];
            String GK3 = (String)Session["gk3"];
            String GK4 = (String)Session["gk4"];
            String GK5 = (String)Session["gk5"];
            //String nome = (String)Session["name1"];

            if (GK1.Equals("y"))
                points++;
            if (GK2.Equals("y"))
                points++;
            if (GK3.Equals("y"))
                points++;
            if (GK4.Equals("y"))
                points++;
            if (GK5.Equals("y"))
                points++;

            double por = (100 / 5) * points;
            LblAnswer.Text = por.ToString();
            //lblNomeFinish = nome;

            if (por >= 50)
                Image.ImageUrl = "~/images/maior50.gif";
            else if (por < 50)
                Image.ImageUrl = "~/images/menor50.gif";
        }

        protected void btnAgain_Click(object sender, EventArgs e)
        {
            Response.Redirect("OpeningPage.aspx");
        }
    }
}