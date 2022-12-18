using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe018
{
    public partial class FrmExe018 : Form
    {
        public FrmExe018()
        {
            InitializeComponent();
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            TxtNumber.Text = "";
            LblResult.Text = "";
            TxtNumber.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            LblResult.Text = "";
            int number = Convert.ToInt32(TxtNumber.Text);
            int resto = 0;

            if(number <= 1)
            {
                LblResult.Text = "Number is NOT prime!";
                return;
            }

            for (int divisor = 2; divisor < number; divisor++)
            {
                resto = number % divisor; //devolve o resto da divisao

                if (resto == 0)
                {
                    LblResult.Text = number.ToString() + " is NOT prime!";
                    return;
                }
            }

            LblResult.Text = number.ToString() + " IS a prime number!";
        }

        private void TxtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
