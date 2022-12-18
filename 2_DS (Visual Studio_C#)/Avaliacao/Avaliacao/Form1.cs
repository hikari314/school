using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao
{
    public partial class FrmExeAvaliacao : Form
    {
        public FrmExeAvaliacao()
        {
            InitializeComponent();
        }

        private void BtnVer_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtNumber_Numero.Text);
                lblAnswer_Resposta.Text = Verificar(num); //aqui o programa sabe aonde deve retornar o valor do "return"
            }
            catch
            {
                MessageBox.Show("Only write numbers!", "Atention");
            }
        }

        private string Verificar(int number1)
        {
            int remain = number1 % 2;
            if(remain == 0)
            {
                return "Is an EVEN number!"; //aqui substitui o lblAnswer.Text = ...
            }
            else
            {
                return "Is an ODD number!";
            }
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            txtNumber_Numero.Text = "";
            lblAnswer_Resposta.Text = "";
            txtNumber_Numero.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
