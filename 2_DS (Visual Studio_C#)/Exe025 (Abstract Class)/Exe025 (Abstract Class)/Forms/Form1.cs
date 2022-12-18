using Exe025__Abstract_Class_.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe025__Abstract_Class_
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MnuRegister_Click(object sender, EventArgs e)
        {
            //aqui faz um teste pra ver se o formulario já está aberto
            if (Program.statusMenu != "blocked")
            {
                Program.statusMenu = "blocked";
                FrmRegister MyRegister = new FrmRegister();
                MyRegister.MdiParent = this;
                MyRegister.Show();
            }
            else
            {
                MessageBox.Show("Form already open!", "ATENTION");
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
