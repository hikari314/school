using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe004
{
    public partial class FrmExe004 : Form
    {
        public FrmExe004()
        {
            InitializeComponent();
        }

        private void TxtTuition_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl5_Click(object sender, EventArgs e)
        {

        }

        private void TxtNameStudent_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            TxtTuition.Text = "";
            TxtNameStudent.Text = "";
            TxtAddress.Text = "";
            TxtZipCode.Text = "";
            TxtCity.Text = "";
            TxtState.Text = "";
            TxtEmail.Text = "";
            LblDataSent.Text = "";
            TxtTuition.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your data was sent!", "Sun and Beach College");
            Application.Exit();
        }

        private void TxtDataSent_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            LblDataSent.Text = TxtTuition.Text +
                "\n" + TxtNameStudent.Text +
                "\n" + TxtAddress.Text +
                "\n" + TxtZipCode.Text +
                "\n" + TxtCity.Text +
                "\n" + TxtState.Text +
                "\n" + TxtEmail.Text;
        }

        private void FrmExe004_Load(object sender, EventArgs e)
        {

        }

        private void Lbl8_Click(object sender, EventArgs e)
        {

        }
    }
}
