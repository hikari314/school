using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjLogin
{
    public partial class Insert_Gerente : System.Web.UI.Page
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

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            con = new ClasseConexao();

            //String a = txtCodprod.Text;
            String b = txtDescr.Text;
            String c = txtCodfor.Text;
            String d = txtCodcategoria.Text;
            String f = txtPreco.Text;
            String g = txtUnidades.Text;
            String h = txtDescontinuado.Text;

            string sql = string.Format("exec usp_InsertGere '{0}', {1}, {2}, {3}, {4}, {5}", b, c, d, f, g, h);

            dt = con.executarSQL(sql);

            if (dt.Rows.Count > 0)
            {
                con = new ClasseConexao();
                dt = con.executarSQL("select * from Produtos");
                gvG.DataSource = dt.DefaultView;
                gvG.DataBind();
            }
        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login_Gerente.aspx");
        }
    }
}