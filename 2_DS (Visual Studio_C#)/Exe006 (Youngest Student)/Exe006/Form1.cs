using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe006
{
    public partial class FrmExe006 : Form
    {
        string name1 = "";
        string name2 = "";
        byte age1 = 0;
        byte age2 = 0;


        public FrmExe006()
        {
            InitializeComponent();
        }

        private void LblDay_Click(object sender, EventArgs e)
        {

        }

        private void FrmExe006_Load(object sender, EventArgs e)
        {
            LblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            LblDay.Text = DateTime.Now.ToString("dddd").ToUpper();
            LblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LblTime.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void BtnYoungPerson_Click(object sender, EventArgs e)
        {
            if ((TxtName1.Text == "") ||
                (TxtAge1.Text == "") ||
                (TxtName2.Text == "") ||
                (TxtAge2.Text == ""))
            {
                MessageBox.Show("Prencha TODOS os campos!", "ATENÇÃO!");
                TxtName1.SelectAll();
                TxtName1.Focus();
            }
            else
            {
                name1 = TxtName1.Text;
                age1 = Convert.ToByte(TxtAge1.Text);

                name2 = TxtName2.Text;
                age2 = Convert.ToByte(TxtAge2.Text);

                if (age1 == age2)
                {
                    MessageBox.Show("Alunos com a mesma idade!", "ATENÇÃO!");
                    BtnYoungPerson.Enabled = false;
                    BtnClean.Enabled = true;
                }
                else if (age1 < age2){
                    LblNameYoung.Text = name1;
                    LblAgeYoung.Text = age1.ToString();
                    BtnYoungPerson.Enabled = false;
                    BtnClean.Enabled = true;
                }
                else
                {
                    LblNameYoung.Text = name2;
                    LblAgeYoung.Text = age2.ToString();
                    BtnYoungPerson.Enabled = false;
                    BtnClean.Enabled = true; 
                }

            }
        }

        private void TxtAge1_KeyPress(object sender, KeyPressEventArgs e) //esse "e' é a var que contem o codigo da tecla que a pessoa digitou (ASCII - por isso tá escrito de 48 a 57 no if)
        {
            // não importa qual tecla voce pressiona, sempre vai rodar - aceita de 0 a 9 (48 a 57), além do backspace (que é código 08)
            if (e.KeyChar != 08 && (e.KeyChar < 48 || e.KeyChar > 57)) //o codigo é da tecla, então se pressionar 1 e 0, vai ser 10 
            {
                e.KeyChar = (char)0;
                //anula a tecla que foi digitada - nem aparece na caixa de texto
            }
        }

        private void TxtAge2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 08 && (e.KeyChar < 48 || e.KeyChar > 57))
            {
                e.KeyChar = (char)0;
            }
        }
    }

}
