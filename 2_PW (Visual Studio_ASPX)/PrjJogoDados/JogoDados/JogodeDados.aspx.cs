using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JogoDados
{
    public partial class JogodeDados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        int dado;

        protected void BtnSortear_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            dado = random.Next(1, 7);

            switch (dado)
            {
                case 1:
                    Image.ImageUrl = "~/image/dado1.png";
                    break;
                case 2:
                    Image.ImageUrl = "~/image/dado2.png";
                    break;
                case 3:
                    Image.ImageUrl = "~/image/dado3.png";
                    break;
                case 4:
                    Image.ImageUrl = "~/image/dado4.png";
                    break;
                case 5:
                    Image.ImageUrl = "~/image/dado5.png";
                    break;
                case 6:
                    Image.ImageUrl = "~/image/dado6.png";
                    break;

            }

            
        }
    }
}