using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe007
{
    public partial class FrmExe007 : Form
    {
        //declarar variaveis
        double v1 = 0;
        double v2 = 0;
        double result = 0;

        public FrmExe007()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            Txt1stValue.Text = "";
            Txt2ndValue.Text = "";
            LblResult.Text = "";
            v1 = 0;
            v2 = 0;
            result = 0;
            GpValues.Enabled = true;
            GpOperations.Enabled = false;
            Txt1stValue.Focus();
        }

        private void GpBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LblResult_Click(object sender, EventArgs e)
        {

        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            result = v1 * v2;
            LblResult.Text = result.ToString();
        }

        private void FrmExe007_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            result = v1 + v2;
            LblResult.Text = result.ToString();
        }

        private void BtnValidate_Click(object sender, EventArgs e)
        {
            try {
                v1 = Convert.ToDouble(Txt1stValue.Text);
                v2 = Convert.ToDouble(Txt2ndValue.Text);
                MessageBox.Show("Correct values", "Select your operation");
                GpOperations.Enabled = true;
                GpValues.Enabled = false;
            }
            catch {
                MessageBox.Show("Write only numbers!!!", "Error - Atention!");
                Txt1stValue.SelectAll();
                Txt2ndValue.Focus();
            }
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            result = v1 - v2;
            LblResult.Text = result.ToString();
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            if (v2 != 0)
            {
                result = v1 / v2;
                LblResult.Text = result.ToString();
            }
            else
            {
                LblResult.Text = "Error";
            }
        }

        private void BtnPower_Click(object sender, EventArgs e)
        {
            result = Math.Pow(v1, v2);
            LblResult.Text = result.ToString();
        }

        private void LblVersion2_Click(object sender, EventArgs e)
        {
            FrmExe0080427 myForm= new FrmExe0080427();
            myForm.Show();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }
    }

}

