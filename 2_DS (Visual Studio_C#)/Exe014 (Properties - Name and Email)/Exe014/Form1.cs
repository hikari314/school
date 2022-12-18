using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe014
{
    public partial class FrmExe014 : Form
    {
        public FrmExe014()
        {
            InitializeComponent();
        }

        private void BtnRender_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;
            string testName = name.Trim();
            int qntdCharacters = testName.Length;

            if (name != testName)
            {
                MessageBox.Show("Verify your name again", "Atention");
                TxtName.SelectionStart = 0;
                TxtName.SelectionLength = TxtName.Text.Length;
                TxtName.Focus();
            }
            else if (qntdCharacters < 10 || qntdCharacters > 60)
            {
                MessageBox.Show("Name size out of padronization", "Atention");
                TxtName.SelectionStart = 0;
                TxtName.SelectionLength = TxtName.Text.Length;
                TxtName.Focus();
            }
            else
            {
                int firstname = testName.IndexOf(" ");
                LblName.Text = name.Substring(0, firstname);
                LblChara.Text = qntdCharacters.ToString();

                string email = TxtEmail.Text;
                int finishnameemail = email.IndexOf("@");
                int totalsizeemail = email.Length;
                int totaldominio = totalsizeemail - finishnameemail;

                if (finishnameemail < 1)
                {
                    MessageBox.Show("Verify your email address!", "Atention!");
                    TxtEmail.SelectionStart = 0;
                    TxtEmail.SelectionLength = TxtEmail.Text.Length;
                    TxtEmail.Focus();
                }
                else
                {
                    LblEmail.Text = email.Substring(0, finishnameemail);
                    LblDomain.Text = email.Substring(finishnameemail + 1, totaldominio - 1);
                }
            }
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            TxtName.Text = "";
            TxtEmail.Text = "";
            LblChara.Text = "";
            LblDomain.Text = "";
            LblEmail.Text = "";
            LblName.Text = "";
            TxtName.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
