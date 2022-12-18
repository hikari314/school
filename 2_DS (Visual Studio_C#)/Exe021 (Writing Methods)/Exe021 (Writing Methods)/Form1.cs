using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe021__Writing_Methods_
{
    public partial class FrmExe021 : Form
    {
        public FrmExe021()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //private é um método, que é criado "automaticamente" | pode ser private ou public | void executa e não retorna nenhuma informação | o nome indica o que o metodo vai fazer, normalmente é um verbo - letra maiuscula
            //se não declarar como private, o visual studio coloca como private
        {

        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            lblResult.Text = "";
            txtNumber.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnCheck01_Click(object sender, EventArgs e)
        {
            CheckI();
        }

        private void CheckI()
        {
            //throw new NotImplementedException();
            int number = Convert.ToInt32(txtNumber.Text);
            int resto = 0;

            if(number <= 1)
            {
                lblResult.Text = "Número não é primo!!!";
                return;
            }
            for(int divisor = 2; divisor < number; divisor++)
            {
                resto = number % divisor;

                if (resto == 0)
                {
                    lblResult.Text = number.ToString() + "não é primo";
                    return;
                }
            }
            lblResult.Text = number.ToString() + "é um número primo!";
        }

        private void BtnCheck02_Click(object sender, EventArgs e)
        {
            CheckII(Convert.ToInt32(txtNumber.Text));
        }

        private void CheckII(int number)
        {
            //throw new NotImplementedException();
            int resto = 0;

            if (number <= 1)
            {
                lblResult.Text = "Number is not prime!";
                return;
            }

            for (int divisor = 2; divisor < number; divisor++)
            {
                resto = number % divisor;

                if (resto == 0)
                {
                    lblResult.Text = number.ToString() + "is not a prime number";
                    return;
                }
            }

            lblResult.Text = number.ToString() + "is a prime number!";
        }

        private void BtnCheck03_Click(object sender, EventArgs e)
        {
            CheckIII(Convert.ToInt32(txtNumber.Text));
        }

        private string CheckIII(int number)
        {
            //throw new NotImplementedException();
            int resto = 0;

            if(number <= 1)
            {
                return "Number is not prime!";
            }

            for (int divisor = 2; divisor < number; divisor++)
            {
                resto = number % divisor;

                if (resto == 0)
                {
                    return number.ToString() + "is not prime!";
                }
            }
            return number.ToString() + "is a prime number!!";
                

            
        }
    }
}
