using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Exe009
{
    public partial class FrmExe009 : Form
    {
        int tempo = 0;
        int contaErro = 0;
        SoundPlayer som = new SoundPlayer(Properties.Resources.Palmas);

        public FrmExe009()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            PnlImage.Enabled = true;
            tempo = 0;
            contaErro = 0;
            LblScore.Text = "0";
            LblTime.Text = "0";
            BtnNew.Enabled = true;
            BtnStart.Enabled = false;
            timer1.Enabled = true;
        }

        private void LBLe(object sender, EventArgs e)
        {
            Label labelClick = sender as Label;
            if (labelClick.Text != "")
            {
                MessageBox.Show("Tente localizar outro erro!!", "ATENÇÃO");

            }
            else
            {
                labelClick.Text = "X";
                contaErro += 1;
                LblScore.Text = contaErro.ToString();
            }
            if (contaErro >= 7)
            {
                timer1.Enabled = false;
                som.Play();
                MessageBox.Show("Você localizou os 7 erros", "PARABÉNS");
            }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            tempo += 1;
            LblTime.Text = tempo.ToString();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            tempo = 0;
            contaErro = 0;
            PnlImage.Enabled = false;
            LblScore.Text = "0";
            LblTime.Text = "0";

            LblE1.Text = "";
            LblE2.Text = "";
            LblE3.Text = "";
            LblE4.Text = "";
            LblE5.Text = "";
            LblE6.Text = "";
            LblE7.Text = "";

            timer1.Enabled = false;
            BtnStart.Enabled = true;
            BtnNew.Enabled = false;
            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
