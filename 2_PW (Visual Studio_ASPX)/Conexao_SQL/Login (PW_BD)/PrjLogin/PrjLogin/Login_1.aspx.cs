using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjLogin
{
    public partial class Login_1 : System.Web.UI.Page
    {
        ClasseConexao con;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string a = txtUsuario.Text;
            string b = txtSenha.Text;

            con = new ClasseConexao();
            dt = new DataTable(); //tabela retornada
            dt = con.executarSQL("exec usp_login '" + a + "', '" + b + "'");

            if (dt.Rows.Count == 1)
            {
               if (b.Equals("Gere7098"))
                {
                    Session["login"] = 1;
                    Response.Redirect("Login_Gerente.aspx");
                }
                else if (b.Equals("Coor1314"))
                {
                    Session["login1"] = 1;
                    Response.Redirect("Login_Coordenador.aspx");
            }
                else
                {
                    string myStringVariable = "Sobrenome ou senha não correspondentes";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + myStringVariable + "');", true);
                }
            }
            else
            {
                string myStringVariable = "Sobrenome ou senha não correspondentes";
                //txtSenha.Text = "Usuário ou senha errado";
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + myStringVariable + "');", true);
            }
        }
    }
}