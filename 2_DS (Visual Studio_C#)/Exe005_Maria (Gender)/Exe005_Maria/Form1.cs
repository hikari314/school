using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe005_Maria
{
    public partial class FrmExe005 : Form
    {

        public FrmExe005()
        {
            InitializeComponent();
        }

        private void Lbl3_Click(object sender, EventArgs e)
        {

        }

        private void LblMensage_Click(object sender, EventArgs e)
        {

        }

        private void Lbl2_Click(object sender, EventArgs e)
        {

        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(TxtName.Text)) || (string.IsNullOrEmpty(TxtGender.Text))) {

                MessageBox.Show("You didnt write your name!", "Warning!");
                TxtName.Focus();
            }
            else if (TxtGender.Text == "M")
            {
                LblMensage.Text = "Welcome boy!";
                BtnClean.Focus();
            }

             else if (TxtGender.Text == "W")
            {
                LblMensage.Text = "Welcome girl!";
            }

            else if ( ( TxtGender.Text != "W") || (TxtGender.Text != "M") )
            {
                MessageBox.Show("This value doenst exist, try again.", "Error");
            }

        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            TxtName.Text = "";
            TxtGender.Text = "";
            LblMensage.Text = "";
            BtnShow.Enabled = true;
            BtnClean.Enabled = false;
            TxtName.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You", "Always Come Back!");
            Application.Exit();
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
