using System;
using System.Collections.Generic; //bibliotecas que o C# acha que voce vai utilizar
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj001_Maria
{
    public partial class FrmPrj001 : Form
    {
        public FrmPrj001()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit(); //faz o botao sair, fechar o form
        }
    }
}
