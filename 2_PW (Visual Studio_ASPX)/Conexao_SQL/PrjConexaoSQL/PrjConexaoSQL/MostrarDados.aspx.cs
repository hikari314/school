using System;
using System.Data;

namespace PrjConexaoSQL
{
    public partial class MostrarDados : System.Web.UI.Page
    {

        ClasseConexao con;
        DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {
            //carregar o asp com os dados do SQL
            /*if(!IsPostBack)
            {
                con = new ClasseConexao();
                dt = new DataTable();
                dt = con.executarSQL("select * from Contatos"); //dt é atabela retornada do banco de dados | retorna a tabela dentro do dt
                GridView1.DataSource = dt.DefaultView;
                GridView1.DataBind();
            }*/
        }

        protected void btnS_Click(object sender, EventArgs e)
        {
            /*con = new ClasseConexao();
            dt = new DataTable();

            String a = txtInsert.Text;

            dt = con.executarSQL("select * from contatos where nome like '%"+ a +"%'");

            GridView1.DataSource = dt.DefaultView;
            GridView1.DataBind();*/

            String n = txtNome.Text;
            String f = txtFone.Text;

            con = new ClasseConexao();
            dt = new DataTable();

            dt = con.executarSQL("select * from contatos where nome like '" + n + "' and fone like '" + f + "'");

            GridView1.DataSource = dt.DefaultView;
            GridView1.DataBind();
        }

        /*protected void Button1_Click(object sender, EventArgs e)
        {
            string c = txtSQL.Text;

            con = new ClasseConexao();
            dt = new DataTable();
            dt = con.executarSQL(c);

            //dt = con.executarSQL("select nome from contatos where nome like '%al%'"); //dt é atabela retornada do banco de dados | retorna a tabela dentro do dt
            GridView1.DataSource = dt.DefaultView;
            GridView1.DataBind();
        }*/
    }
}