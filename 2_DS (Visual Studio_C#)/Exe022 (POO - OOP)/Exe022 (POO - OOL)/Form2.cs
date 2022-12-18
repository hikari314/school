using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe022__POO___OOL_
{
    public partial class FrmExe023 : Form
    {
        public FrmExe023()
        {
            InitializeComponent();
        }

        private void FrmExe023_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            ClsClassified ObjClas = new ClsClassified();
            
            try
            {
                ObjClas.NumRegister = Convert.ToInt32(txtNumber.Text);
                lblResult.Text = ObjClas.Check().ToString();
            }
            catch
            {
                MessageBox.Show("Write only number!!", "Atention!");
                txtNumber.Text = "";
                txtNumber.Focus();
            }
            
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "";
            lblResult.Text = "";
            txtNumber.Focus();
        }

        private void BtnE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LblOpen2_Click(object sender, EventArgs e)
        {

        }
    }
}
