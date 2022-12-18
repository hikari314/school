using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe002_Maria
{
    public partial class FrmExe002 : Form
    {
        public FrmExe002()
        {
            InitializeComponent();
        }

        private void LblMensage_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMensage1_Click(object sender, EventArgs e)
        {
            LblMensage.Text = "If u're doing something that u don't like... press \"Show Mensage 2\"";
            BtnMensage2.Enabled = true;
            BtnMensage1.Enabled = false;
        }

        private void BtnMensage2_Click(object sender, EventArgs e)
        {
            LblMensage.Text = "... just cry, I don't have a solution either";
            BtnMensage1.Enabled = true;
            BtnMensage2.Enabled = false;
        }
    }
}
