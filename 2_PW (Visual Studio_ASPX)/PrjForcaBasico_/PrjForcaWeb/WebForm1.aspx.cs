using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjForcaWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void BtnVerificar_Click(object sender, EventArgs e)
        {
            //palavra pré-definida
            string cat =  "cat";
            string rc = cat.ElementAt(0) + "";
            string ra = cat.ElementAt(1) + "";
            string rt = cat.ElementAt(2) + "";
            //resposta do player
            string resp = TxtResposta.Text;
            string resp1 = resp.ElementAt(0)+"";
            string resp2 = resp.ElementAt(1)+"";
            string resp3 = resp.ElementAt(2)+"";


            if (String.Equals(rc , resp1)){
                ImgCabeca.ImageUrl = "";
            }
            else
            {
                ImgCabeca.ImageUrl = "~/imagens/cabeça.png";
            }

            if (String.Equals(ra, resp2))
            {
                ImgTronco.ImageUrl = "";
            }
            else
            {
                ImgTronco.ImageUrl = "~/imagens/tronco.png";
            }

            if (String.Equals(rt , resp3))
            {
                ImgPernas.ImageUrl = "";
            }
            else
            {
                ImgPernas.ImageUrl = "~/imagens/pernas.png";
            }

            if((String.Equals(rt, resp3))&& 
               (String.Equals(ra, resp2))&& 
               (String.Equals(rc, resp1)))
            {
                Lblpalavra.Text = ("Parabéns, você acertou!");
            }
            else
            {
                Lblpalavra.Text = ("Digite uma palavra de três letras!");
            }
        }
    }
}