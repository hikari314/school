using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjLogin
{
    public partial class Login_Gerente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*if (Session["login"] == null || (int)Session["login"] != 1)
            {
                Response.Redirect("Login_1.aspx");
            }*/
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            Response.Redirect("Insert_Gerente.aspx");
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mostrar_Gerente.aspx");
        }
    }
}