using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjInsert
{
    public partial class InserirDados : System.Web.UI.Page
    {
        ClasseConexao con;
        DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            con = new ClasseConexao();
            String n = txtNome.Text;
            String f = txtFone.Text;
            dt=con.executarSQL("exec usp_insert '" + n + "' ,'" + f + "'");

            if(dt.Rows.Count > 0)
            {
                con = new ClasseConexao();
                dt = con.executarSQL("select * from contatos");
                GridView1.DataSource = dt.DefaultView;
                GridView1.DataBind();
            }
        }
    }
}