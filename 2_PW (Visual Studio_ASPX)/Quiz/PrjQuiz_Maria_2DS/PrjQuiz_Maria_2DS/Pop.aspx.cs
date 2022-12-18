using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjQuiz_Maria_2DS
{
    public partial class Pop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSeeResults_Click(object sender, EventArgs e)
        {
            String result = "";

            if (RdoOpt2.Checked)
                result = "y";
            if (RdoOpt1.Checked || RdoOpt3.Checked || RdoOpt4.Checked)
                result = "n";
            Session["gk1"] = result;

            if (RdoOpt5.Checked)
                result = "y";
            if (RdoOpt6.Checked || RdoOpt7.Checked || RdoOpt8.Checked)
                result = "n";
            Session["gk2"] = result;

            if (RdoOpt11.Checked)
                result = "y";
            if (RdoOpt9.Checked || RdoOpt10.Checked || RdoOpt12.Checked)
                result = "n";
            Session["gk3"] = result;

            if (RdoOpt15.Checked)
                result = "y";
            if (RdoOpt13.Checked || RdoOpt14.Checked || RdoOpt16.Checked)
                result = "n";
            Session["gk4"] = result;

            if (RdoOpt20.Checked)
                result = "y";
            if (RdoOpt17.Checked || RdoOpt18.Checked || RdoOpt19.Checked)
                result = "n";
            Session["gk5"] = result;

            Response.Redirect("FinishPop.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("OpeningPage.aspx");
        }
    }
}