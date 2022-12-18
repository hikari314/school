using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe024___Budget__OOP_
{
    public partial class FrmExe024 : Form
    {
        public FrmExe024()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int x = 1; x<= 6; x++)
            {
                cboInsta.Items.Add(x);
            }

            cboInsta.SelectedIndex = 0;
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            ClsCalculate ObjCal = new ClsCalculate();

            ObjCal.Value = Convert.ToInt32(txtPrice.Text);

            if (cboInsta.SelectedIndex == 0)
            {
                lblR.Text = ObjCal.CalculateValue();
            }
            else
            {
                lblR.Text = ObjCal.CalculateValue(cboInsta.SelectedIndex + 1);
            }
        }

        private void BtnE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnN_Click(object sender, EventArgs e)
        {
            lblR.Text = "";
            txtPrice.Text = "";
            cboInsta.SelectedIndex = 0;
            txtPrice.Focus();
        }
    }
}
