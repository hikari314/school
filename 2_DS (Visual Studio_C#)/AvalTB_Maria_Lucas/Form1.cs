using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvalTB_Maria_Lucas
{
    public partial class FrmAvaliacao : Form
    {
        public FrmAvaliacao()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnSairB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Continue treinando =)", "Parabéns!");
            Application.Exit();
        }

        private void TxtNomeB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnVerificarB_Click(object sender, EventArgs e)
        {
            //Txtb1
            if (TxtB1.Text == "8")
            {
                LblStatusB1.Text = "Correto";
            }
            else {
                LblStatusB1.Text = "Atenção!";
            }

            //Txtb2
            if (TxtB2.Text == "2")
            {
                LblStatusB2.Text = "Correto";
            }
            else
            {
                LblStatusB2.Text = "Atenção!";
            }

            //Txtb3
            if (TxtB3.Text == "5")
            {
                LblStatusB3.Text = "Correto";
            }
            else
            {
                LblStatusB3.Text = "Atenção!";
            }

            //botões - enable and disable
            BtnLimparB.Enabled = true;
            BtnVerificarB.Enabled = false;

        }

        private void BtnLimparB_Click(object sender, EventArgs e)
        {
            //limpar
            TxtNomeB.Text = "";
            LblStatusB1.Text = "";
            LblStatusB2.Text = "";
            LblStatusB3.Text = "";
            TxtB1.Text = "";
            TxtB2.Text = "";
            TxtB3.Text = "";

            //botões - enable and disable
            BtnLimparB.Enabled = false;
            BtnVerificarB.Enabled = true;

            TxtNomeB.Focus();
        }
    }
}
