using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjCalculadorsaSimples__0223_
{
    public partial class Calculadora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSoma_Click(object sender, EventArgs e)
        {
            String v1 = txtVal1.Text; //soma
            Double val1 = Double.Parse(v1); //converte para double

            String v2 = txtVal2.Text;
            Double val2 = Double.Parse(v2); //converte para double
            
            //Console.WriteLine(val1 + val2);
            Double t = val1 + val2;
            // lblTotal 
            lblTotal.Text = t + "";
        }

        protected void btnSubtrair_Click(object sender, EventArgs e)
        {
            String v1 = txtVal1.Text; //subtracao
            Double val1 = Double.Parse(v1);
            String v2 = txtVal2.Text;
            Double val2 = Double.Parse(v2);
            Double t = val1 - val2;
            lblTotal.Text = t + "";
        }

        protected void btnMultiplicar_Click(object sender, EventArgs e)
        {
            String v1 = txtVal1.Text; //multiplicar
            Double val1 = Double.Parse(v1);
            String v2 = txtVal2.Text;
            Double val2 = Double.Parse(v2);
            Double t = val1 * val2;
            lblTotal.Text = t + "";
        }

        protected void btnDividir_Click(object sender, EventArgs e)
        {
            String v1 = txtVal1.Text; //dividir
            Double val1 = Double.Parse(v1);
            String v2 = txtVal2.Text;
            Double val2 = Double.Parse(v2);
            Double t = val1 / val2;
            lblTotal.Text = t + "";
        }

        protected void btnSeno_Click(object sender, EventArgs e)
        {
            String v1 = txtVal1.Text; //seno
            Double val1 = Double.Parse(v1);

            Double seno = Math.Sin(val1 * (Math.PI / 180)); // nao se calcula angulo direto, tem que passar primeiro o radiano
            lblTotal.Text = seno + "";
        }
    }
}