using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao3BIM
{
    public partial class Form1 : Form
    {
        double nota1 = 0;
        double nota2 = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                Calc ObjResultado = new Calc();

                ObjResultado.Nota1 = Convert.ToDouble(txtNota1.Text);
                ObjResultado.Nota2 = Convert.ToDouble(txtNota2.Text);

                ObjResultado.CalcularResultado();

                lblMedia.Text = ObjResultado.Media.ToString("0.0"); //aqui formata para aparecer 1 casa decimal
                lblShow.Text = ObjResultado.Resultado;

                //ObjResultado.Resultado = "bbbbbb";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro --> " + ex.Message, "Atenção");
                txtNota1.Focus();
               
            }
        }
    }
}
