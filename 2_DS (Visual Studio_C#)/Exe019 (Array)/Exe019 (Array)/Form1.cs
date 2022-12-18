using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe019__Array_
{
    public partial class FrmEx019 : Form
    {
        string[] result = new string[10];
        int number = 0;
        public FrmEx019()
        {
            InitializeComponent();
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                number = Convert.ToInt16(txtNumber.Text);
                lblResult.Text = result[number - 1];
            }
            catch
            {
                MessageBox.Show("Only write numbers between 1 and 10!", "Atention!");
                txtNumber.Text = "";
                txtNumber.Focus();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmEx019_Load(object sender, EventArgs e)
        {
            result[0] = "Approved";
            result[1] = "Approved";
            result[2] = "Disapproved";
            result[3] = "Approved";
            result[4] = "Approved";
            result[5] = "Approved";
            result[6] = "Disapproved";
            result[7] = "Approved";
            result[8] = "Approved";
            result[9] = "Withheld";
        }
    }
}
