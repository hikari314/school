using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjLogin
{
    public partial class Insert_Coordenador : System.Web.UI.Page
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

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            con = new ClasseConexao();

            String a = txtNumped.Text;
            String b = txtCodcli.Text;
            String c = txtCodfun.Text;
            String d = txtDataped.Text;
            String f = txtDataentrega.Text;
            String g = txtFrete.Text;

            string sql1 = string.Format("exec usp_InsertCoo {0}, '{1}', {2}, '{3}', '{4}', {5}", a, b, c, d, f, g);

            dt = con.executarSQL(sql1);

            if (dt.Rows.Count > 0)
            {
                con = new ClasseConexao();
                dt = con.executarSQL("select * from Pedidos");
                gvC.DataSource = dt.DefaultView;
                gvC.DataBind();
            }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login_Coordenador.aspx");
        }
    }
}