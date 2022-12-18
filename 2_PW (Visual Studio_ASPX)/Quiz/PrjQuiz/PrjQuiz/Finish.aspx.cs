using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjQuiz
{
    public partial class Finish : System.Web.UI.Page
    {
        int points = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            //o resultado não pode ser em botão, tem que ser aqui no load
            /*convertendo em String:
             Type cast = (String)Session["que1"]; - server para filtrar, nem sempre converte
             Concatenação = Session["que1"] + "" ;
             Método (nem sempre funciona) = Session["que1"].ToString();*/

            String q1 = (String)Session["question1"]; //o (String) usa em qualquer uma, e isso tá convertendo
            String q2 = Session["question2"] + "";
            if (q1.Equals("y"))
                points++;
            if (q2.Equals("y"))
                points++;

            double por = (100 / 2) * points; //se for 0, ai for dividir por 100, dá pau no processador | 2 ali é o número de perguntas/páginas
            LblAnswer.Text = por.ToString(); 
        }
    }
}