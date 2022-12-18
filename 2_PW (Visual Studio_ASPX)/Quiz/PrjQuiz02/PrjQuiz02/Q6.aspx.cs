using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjQuiz02
{
    public partial class Q6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnNext_Click(object sender, EventArgs e)
        {
            String result = "";
            if (RdoOpt1.Checked)
                result = "n";
            if (RdoOpt2.Checked)
                result = "y";
            Session["que6"] = result;
            Response.Redirect("Q7.aspx");
        }
    }
}