using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjQuiz
{
    public partial class Start : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnNext_Click(object sender, EventArgs e)
        {
            String result = ""; //string maisuculo ou minusculo, tanto faz, mas em outras linguagens é só maiusculo
            //usa string pq só interessa uma resposta

            if (RdoOpt1.Checked)
                result = "n";
            if (RdoOpt2.Checked)
                result = "y"; 
            if (RdoOpt3.Checked)
                result = "n";
            if (RdoOpt4.Checked)
                result = "n";
            Session["question1"] = result; //é uma sessão, que equivale a declarar uma variavel, mas todo mundo "enxerga", em todos os formularios - para resgatar os valores para contar quantos errou e quantos acertou
            //pra ir pra prox pagina:
            Response.Redirect("Q2.aspx");
        }
    }
}