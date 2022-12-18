using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe010
{
    public partial class FrmExe010 : Form
    {
        public FrmExe010()
        {
            InitializeComponent();
            //quando coloca a propriedade "AcceptButton" o botão fica em destaque e aciona o obtão de ENTER para ser ativado em qualquer lugar
            //já a propriedade "CancelButton", quando aperta o botão pode ser ativo com o ESC
            //a "ToolTip" tem que pegar na caixa de ferramentas e colocar no formulário, depois aparece nas propriedades (serve para colcoar um texto de ajuda quando o mouse fica emcima do btn/lbl...)
        }

        private void LblHour_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TxtName.Text = "";
            DtpBirth.Text = DateTime.Now.ToString("dd/MM/yyyy");
            RbF.Checked = true;
            ComBSchooling.Text = "Select...";
            ChkRead.Checked = false;
            ChkWalk.Checked = false;
            ChkTravel.Checked = false;
            ChkDance.Checked = false;
            ChkSwin.Checked = false;
            ChkSing.Checked = false;
            LstAnswer.Items.Clear();
            TxtName.Focus();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void FrmExe010_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            LblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            LblDay.Text = DateTime.Now.ToString("dddd").ToUpper();
            LblHour.Text = DateTime.Now.ToString("HH:mm:ss");

            //combobox:
            ComBSchooling.Items.Add("Incomplete Middle School");
            ComBSchooling.Items.Add("Complete Middle School");
            ComBSchooling.Items.Add("Incomplete High School");
            ComBSchooling.Items.Add("Complete High School");
            ComBSchooling.Items.Add("Incomplete Higher Education");
            ComBSchooling.Items.Add("Complete Higher Education");
            ComBSchooling.Items.Add("Postgraduate");
        }

        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            LblHour.Text = DateTime.Now.ToString("HH:mm:ss");
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //BtnListar:
            LstAnswer.Items.Clear();

            if(TxtName.Text == "")
            {
                MessageBox.Show("Write a name!", "Atention");
                TxtName.Focus();
                return; // usa para "ignorar" o resto do que tá embaixo e "finalizar" com o programa
            }
            LstAnswer.Items.Add(TxtName.Text);

            //ve se a data de nascimento é >= do que a atual:
            DateTime nowDate = Convert.ToDateTime(LblDate.Text);
            DateTime birthDate = Convert.ToDateTime(DtpBirth.Text);

            if(birthDate >= nowDate)
            {
                MessageBox.Show("Incorret birth date!", "Atention!");
                DtpBirth.Focus();
                return;
            }
            LstAnswer.Items.Add(DtpBirth.Text);

            //schooling:
            if (ComBSchooling.Text == "Select...")
            {
                MessageBox.Show("Select your level of schooling!", "Atention");
                ComBSchooling.Focus();
                return;
            }
            LstAnswer.Items.Add(ComBSchooling.Text);

            //birth gender:
            if (RbF.Checked == true)
                LstAnswer.Items.Add("Feminine");
            else
                LstAnswer.Items.Add("Masculine");

            //preferences:
            LstAnswer.Items.Add("Personal Preferences:");

            if (ChkRead.Checked == true)
                LstAnswer.Items.Add("Read");
            if (ChkWalk.Checked == true)
                LstAnswer.Items.Add("Walk");
            if (ChkTravel.Checked == true)
                LstAnswer.Items.Add("Travel");
            if (ChkDance.Checked == true)
                LstAnswer.Items.Add("Dance");
            if (ChkSwin.Checked == true)
                LstAnswer.Items.Add("Swim");
            if (ChkSing.Checked == true)
                LstAnswer.Items.Add("Sing");
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ComBSchooling_KeyPress(object sender, KeyPressEventArgs e)
        {
            //impede que digitem na caixa de texto:
            e.KeyChar = (char)0; //anula a tecla digitada -> 0 = nulo
        }
    }
}
