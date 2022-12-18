using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjProcedimento
{
    public partial class Procedimento : System.Web.UI.Page
    {
        ClasseConexao con;
        DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnExecutar_Click(object sender, EventArgs e)
        {
            con = new ClasseConexao();
            String nome = txtUsuario.Text;
            String senha = txtSenha.Text;

            dt = con.executarSQL("Exec usp_login '" + nome + "','" + senha + "'");
            txtNome.Text = dt.Rows[0]["nome"].ToString();
            txtFone.Text = dt.Rows[0]["fone"].ToString();
            //GridView1.DataSource = dt.DefaultView;
            //GridView1.DataBind();
        }
    }
}