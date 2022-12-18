using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjLogin
{
    public partial class Login : System.Web.UI.Page
    {
        ClasseConexao con;
        DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            String n = txtUser.Text;
            String p = txtPass.Text;

            con = new ClasseConexao();
            dt = new DataTable();

            dt = con.executarSQL("select * from contatos where nome = '" + n + "' and fone = '" + p + "'");
            //n usa like porque ele n destingue maiuscula de miniscula (burlar, again hehe -> só na do Roberto ;-;)

            //aqui é pra conectar com o banco de dados
            if (dt.Rows.Count > 0)
            //if (n.Equals("1") && p.Equals("1")) //login == 1 e senha == 1
            {
                //pra n deixar burlar (escrever arearestita no navegador hehe)
                Session["login"] = 1;
                Response.Redirect("MostrarBanco.aspx");
            }
            else
            {
                lblMessage.Text = "Invalid login";
            }
        }
    }
}