using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjQuiz
{
    public partial class Q2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnNext_Click(object sender, EventArgs e)
        {
            String result = "";
            if (RdoOpt1.Checked)
                result = "y";
            if (RdoOpt2.Checked)
                result = "n";
            if (RdoOpt3.Checked)
                result = "n";
            if (RdoOpt4.Checked)
                result = "n";
            Session["question2"] = result;
            Response.Redirect("Finish.aspx");
        }
    }
}