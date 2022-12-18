using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjLogin
{
    public partial class MostrarBanco : System.Web.UI.Page
    {
        ClasseConexao con;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                con = new ClasseConexao();
                dt = new DataTable();
                dt = con.executarSQL("select * from Contatos"); //dt é atabela retornada do banco de dados | retorna a tabela dentro do dt
                gdv1.DataSource = dt.DefaultView;
                gdv1.DataBind();
            }
        }
    }
}