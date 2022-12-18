using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace forcaweb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtletra.Text = txtletra.Text.ToUpper();

            txtletra.Focus();
        }

        protected void btnconfere_Click(object sender, EventArgs e)
        {
            if (lbl1.Text != "" &&
                lbl2.Text != "" &&
                lbl3.Text != "" &&
                lbl4.Text != "" &&
                lbl5.Text != "" &&
                lbl6.Text != "")
            {
                Random amazing = new Random();
                int palavra = amazing.Next(1, 6);

                if (palavra == 1)
                {
                    letra1.Text = "B";
                    letra2.Text = "A";
                    letra3.Text = "N";
                    letra4.Text = "A";
                    letra5.Text = "N";
                    letra6.Text = "A";
                    lbldica.Text = "Fruta";
                }
                if (palavra == 2)
                {
                    letra1.Text = "P";
                    letra2.Text = "A";
                    letra3.Text = "R";
                    letra4.Text = "A";
                    letra5.Text = "N";
                    letra6.Text = "A";
                    lbldica.Text = "Estado";
                }
                if (palavra == 3)
                {
                    letra1.Text = "T";
                    letra2.Text = "A";
                    letra3.Text = "P";
                    letra4.Text = "E";
                    letra5.Text = "T";
                    letra6.Text = "E";
                    lbldica.Text = "Sala de estar";
                }
                if (palavra == 4)
                {
                    letra1.Text = "G";
                    letra2.Text = "A";
                    letra3.Text = "V";
                    letra4.Text = "E";
                    letra5.Text = "T";
                    letra6.Text = "A";
                    lbldica.Text = "Guardar";
                }
                if (palavra == 5)
                {
                    letra1.Text = "G";
                    letra2.Text = "I";
                    letra3.Text = "R";
                    letra4.Text = "A";
                    letra5.Text = "F";
                    letra6.Text = "A";
                    lbldica.Text = "Animal";
                }

                img1.Visible = false;
                img2.Visible = false;
                img3.Visible = false;
                img4.Visible = false;
                img5.Visible = false;
                img6.Visible = false;


                qerros.Text = "0";

                erros.Text = "";

                txtletra.Text = "";

                lbl1.Text = "";
                lbl2.Text = "";
                lbl3.Text = "";
                lbl4.Text = "";
                lbl5.Text = "";
                lbl6.Text = "";

            }
            if (String.IsNullOrEmpty(txtletra.Text))
            {


            }
            else
            {
                if (txtletra.Text == letra1.Text )
                {
                    lbl1.Text = letra1.Text;
                }
                if (txtletra.Text == letra2.Text)
                {
                    lbl2.Text = letra2.Text;                 
                }
                if (txtletra.Text == letra3.Text)
                {
                    lbl3.Text = letra3.Text;                 
                }
                if (txtletra.Text == letra4.Text)
                {
                    lbl4.Text = letra4.Text;
                }
                if (txtletra.Text == letra5.Text)
                {
                    lbl5.Text = letra5.Text;
                }
                if (txtletra.Text == letra6.Text)
                {
                    lbl6.Text = letra6.Text;
                }
                if (txtletra.Text != letra1.Text &&
                    txtletra.Text != letra2.Text &&
                    txtletra.Text != letra3.Text &&
                    txtletra.Text != letra4.Text &&
                    txtletra.Text != letra5.Text &&
                    txtletra.Text != letra6.Text)
                {
                    erros.Text = erros.Text + "-" + txtletra.Text + " ";

                    Double ponto = int.Parse(qerros.Text);
                    qerros.Text = (ponto + 1).ToString();
                }

            }

            if ( qerros.Text == "1" )
            {
                img1.Visible = true;
            }
            if (qerros.Text == "2")
            {
                img2.Visible = true;
            }
            if (qerros.Text == "3")
            {
                img3.Visible = true;
            }
            if (qerros.Text == "4")
            {
                img4.Visible = true;
            }
            if (qerros.Text == "5")
            {
                img5.Visible = true;
            }
            if (qerros.Text == "6")
            {
                img6.Visible = true;
            }
            if (qerros.Text == "7")
            {
                img1.Visible = false;
                img2.Visible = false;
                img3.Visible = false;
                img4.Visible = false;
                img5.Visible = false;
                img6.Visible = false;

                qerros.Text = "0";

                erros.Text = "";

                txtletra.Text = "";

                lbl1.Text = "";             
                lbl2.Text = "";
                lbl3.Text = "";
                lbl4.Text = "";
                lbl5.Text = "";;
                lbl6.Text = "";;
            }
            txtletra.Text = "";
            txtletra.Focus();
        }

        protected void btnlimpar_Click(object sender, EventArgs e)
        {
            img1.Visible = false;
            img2.Visible = false;
            img3.Visible = false;
            img4.Visible = false;
            img5.Visible = false;
            img6.Visible = false;

            qerros.Text = "0";

            erros.Text = "";

            txtletra.Text = "";

            lbl1.Text = "";
            lbl2.Text = "";
            lbl3.Text = "";
            lbl4.Text = "";
            lbl5.Text = ""; 
            lbl6.Text = "";

            txtletra.Focus();
        }

        protected void btnSortaar_Click(object sender, EventArgs e)
        {
            img1.Visible = false;
            img2.Visible = false;
            img3.Visible = false;
            img4.Visible = false;
            img5.Visible = false;
            img6.Visible = false;

            qerros.Text = "0";

            erros.Text = "";

            txtletra.Text = "";

            lbl1.Text = "";
            lbl2.Text = "";
            lbl3.Text = "";
            lbl4.Text = "";
            lbl5.Text = "";
            lbl6.Text = "";

            Random amazing = new Random();
            int palavra = amazing.Next(1, 6);

            if (palavra == 1)
            {
                letra1.Text = "B";
                letra2.Text = "A";
                letra3.Text = "N";
                letra4.Text = "A";
                letra5.Text = "N";
                letra6.Text = "A";
                lbldica.Text = "Fruta";
            }
            if (palavra == 2)
            {
                letra1.Text = "P";
                letra2.Text = "A";
                letra3.Text = "R";
                letra4.Text = "A";
                letra5.Text = "N";
                letra6.Text = "A";
                lbldica.Text = "Estado";
            }
            if (palavra == 3)
            {
                letra1.Text = "T";
                letra2.Text = "A";
                letra3.Text = "P";
                letra4.Text = "E";
                letra5.Text = "T";
                letra6.Text = "E";
                lbldica.Text = "Sala de estar";
            }
            if (palavra == 4)
            {
                letra1.Text = "G";
                letra2.Text = "A";
                letra3.Text = "V";
                letra4.Text = "E";
                letra5.Text = "T";
                letra6.Text = "A";
                lbldica.Text = "Guardar";
            }
            if (palavra == 5)
            {
                letra1.Text = "G";
                letra2.Text = "I";
                letra3.Text = "R";
                letra4.Text = "A";
                letra5.Text = "F";
                letra6.Text = "A";
                lbldica.Text = "Animal";
            }

            txtletra.Focus();
        }

    }
}
 