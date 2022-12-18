using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjQuiz_Maria_2DS
{
    public partial class OpeningPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnGeneral_Click(object sender, EventArgs e)
        {
            /*String name = "";
            String name1 = "";

            txtName.Text = name.ToString();

            if (name != "")
                Session["name1"] = name1;
            else*/

            Response.Redirect("GeneralK.aspx");
        }

        protected void btnWorld_Click(object sender, EventArgs e)
        {
            Response.Redirect("WorldG.aspx");
        }

        protected void btnArt_Click(object sender, EventArgs e)
        {
            Response.Redirect("Art.aspx");
        }

        protected void btnHistory_Click(object sender, EventArgs e)
        {
            Response.Redirect("History.aspx");
        }

        protected void btnPop_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pop.aspx");
        }
    }
}