using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjLogin
{
    public partial class Mostrar_Gerente : System.Web.UI.Page
    {
        ClasseConexao con;
        DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {
            /*if (Session["login"] == null || (int)Session["login"] != 1)
            {
                Response.Redirect("Login_1.aspx");
            }*/
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login_Gerente.aspx");
        }

        protected void txtResposta_TextChanged(object sender, EventArgs e)
        {
           
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            string a = txtResposta.Text;

                con = new ClasseConexao();
                dt = new DataTable();
                dt = con.executarSQL("exec usp_PesquisaGere '" + a + "'");
                if (dt.Rows.Count > 0)
                {
                    gvGM.DataSource = dt.DefaultView;
                    gvGM.DataBind();
                }
                else
                {
                string myStringVariable = "Nenhum dado à retornar.";
                //txtSenha.Text = "Usuário ou senha errado";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + myStringVariable + "');", true);
                }
        }
    }
}