using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjQuiz02
{
    public partial class Finish : System.Web.UI.Page
    {
        int points = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            String q1 = (String)Session["que1"];
            String q2 = Session["que2"] + "";
            String q3 = (String)Session["que3"];
            String q4 = Session["que4"] + "";
            String q5 = (String)Session["que5"];
            String q6 = Session["que6"] + "";
            String q7 = (String)Session["que7"];
            String q8 = Session["que8"] + "";
            String q9 = (String)Session["que9"];
            String q10 = Session["que10"] + "";

            if (q1.Equals("y"))
                points++;
            if (q2.Equals("y"))
                points++;
            if (q3.Equals("y"))
                points++;
            if (q4.Equals("y"))
                points++;
            if (q5.Equals("y"))
                points++;
            if (q6.Equals("y"))
                points++;
            if (q7.Equals("y"))
                points++;
            if (q8.Equals("y"))
                points++;
            if (q9.Equals("y"))
                points++;
            if (q10.Equals("y"))
                points++;

            double por = (100 / 10) * points;
            LblAnswer.Text = por.ToString();

            
            if (por > 50)
            {
                Image.ImageUrl = "~/images/maior50.jpg";
            }
            else
            {
                
            }
        }
    }
}