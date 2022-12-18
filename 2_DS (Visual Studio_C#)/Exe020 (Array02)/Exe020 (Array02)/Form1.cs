using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe020__Array02_
{
    public partial class FrmExe020 : Form
    {
        int[] classifiedList = new int[10];

        public FrmExe020()
        {
            InitializeComponent();
        }

        private void FrmExe020_Load(object sender, EventArgs e)
        {
            classifiedList[0] = 10514;
            classifiedList[1] = 30343;
            classifiedList[2] = 8240;
            classifiedList[3] = 3125;
            classifiedList[4] = 50525;
            classifiedList[5] = 23289;
            classifiedList[6] = 7310;
            classifiedList[7] = 9281;
            classifiedList[8] = 49524;
            classifiedList[9] = 33001;
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

        private void BtnArray_Click(object sender, EventArgs e)
        {
            //solucao array utilziando "for"
            try
            {
                int registrationNumber = Convert.ToInt32(txtNumber.Text);

                for(int x = 0; x<= 9; x++)
                {
                    if (classifiedList[x] == registrationNumber)
                    {
                        x++;
                        lblResult.Text = "Congratulations! You are classified in the " + x.ToString() + "° position!";
                        return;
                    }
                }

                lblResult.Text = "Wait for the next registration!";
            }
            catch
            {
                MessageBox.Show("Write only number!!", "Atention!");
                txtNumber.Text = "";
                txtNumber.Focus();
            }
        }

        private void BtnIndexOf_Click(object sender, EventArgs e)
        {
            //IndexOf
            try
            {
                int regisNumber = Convert.ToInt32(txtNumber.Text);

                //localiza a posicao do candidato no array
                int position = Array.IndexOf(classifiedList, regisNumber); //(onde pesquisar, o que pesquisar)
                //indexof é uma função, que vai pesquisar se o numero esta no array

                if (position < 0) //nao achou a inscricao
                {
                    lblResult.Text = "You are on the waiting list!";
                }
                else
                {
                    position += 1; //coloca isso porque o array inicia em 0
                    //se quisesse colcoar só se foi aprovado, pdoeria tirar a linha do position
                    lblResult.Text = "Congratulations!! You are classified in the " + position.ToString() + "° position!!";
                }
            }
            catch
            {
                MessageBox.Show("Write only number!!", "ATENTION!!");
                txtNumber.Text = "";
                txtNumber.Focus();
            }
        }
    }
}
