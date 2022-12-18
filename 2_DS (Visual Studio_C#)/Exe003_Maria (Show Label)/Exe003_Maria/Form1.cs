using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe003_Maria
{
    public partial class FrmExe003 : Form
    {
        public FrmExe003()
        {
            InitializeComponent();
        }

        private void BtnShowName_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "")
            {
                MessageBox.Show("You didn't write your name!", "Warning!");
                TxtName.Focus();
            }

            else
            {
                LblAnswer.Text = TxtName.Text; //funciona da direita para esquerda //
                BtnClean.Enabled = true;
                BtnShowName.Visible = false; // o visible é para o botao desaparecer
            }
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            TxtName.Text = "";
            LblAnswer.Text = "";
            BtnShowName.Enabled = true;
            BtnClean.Enabled = false;
            TxtName.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You!!", "Always Come Back"); //o primeiro é dentro do botao e o segundo é o titulo //
            Application.Exit();
        }

    }
}
