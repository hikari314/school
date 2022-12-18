using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe012
{
    public partial class FrmExe012 : Form
    {
        double value1 = 0;
        double value2 = 0;
        double result = 0;

        public FrmExe012()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You!", "Always Come Back!");
            Application.Exit();
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            Txt1V.Text = "";
            Txt2V.Text = "";
            LblHigh.Text = "";
            LblMean.Text = "";
            LblLow.Text = "";
            BtnClean.Enabled = false;
            BtnValidate.Enabled = true;
            Txt1V.Focus();
        }

        private void BtnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                value1 = Convert.ToDouble(Txt1V.Text);
                value2 = Convert.ToDouble(Txt2V.Text);
                
                if (value1 == value2)
                {
                    MessageBox.Show("Same numbers!", "Atention!");
                    BtnMean.Enabled = false;
                    BtnClean.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Correct values", "Validation result:");
                    BtnValidate.Enabled = false;
                    BtnMean.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Write numbers!", "Error - Atention!");
                Txt1V.SelectAll();
                Txt2V.Focus();
            }
        }

        private void BtnMean_Click(object sender, EventArgs e)
        {
            value1 = Convert.ToDouble(Txt1V.Text);
            value2 = Convert.ToDouble(Txt2V.Text);
            result = (value1 + value2)/ 2;

                if (value1 < value2)
                {
                    LblHigh.Text = value2.ToString();
                    LblMean.Text = result.ToString();
                    LblLow.Text = value1.ToString();
                    BtnMean.Enabled = false;
                    BtnClean.Enabled = true;
                }
                else
                {
                    LblLow.Text = value2.ToString();
                    LblMean.Text = result.ToString();
                    LblHigh.Text = value1.ToString();
                    BtnMean.Enabled = false;
                    BtnClean.Enabled = true;
                }
        }

        private void FrmExe012_Load(object sender, EventArgs e)
        {

        }
    }
}
