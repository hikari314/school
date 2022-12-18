using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjLogin
{
    public partial class Mostrar_Coordenador : System.Web.UI.Page
    {
        ClasseConexao con;
        DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {
            /*if (Session["login1"] == null || (int)Session["login1"] != 1)
            {
                Response.Redirect("Login_1.aspx");
            }*/
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login_Coordenador.aspx");
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            con = new ClasseConexao();

            String a = txtResposta.Text;

            string sql2 = string.Format("exec usp_PesquisaCoo '{0}-01'", a);

            dt = con.executarSQL(sql2);

                gvCM.DataSource = dt.DefaultView;
                gvCM.DataBind();
            
        }
    }
}