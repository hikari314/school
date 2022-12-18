using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avaliacao3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                ClsCalcular meta = new ClsCalcular();

                meta.Num = Double.Parse(txtNumber.Text);

                meta.Check();

                lblShow.Text = meta.Show;
            }
            catch
            {
                lblShow.Text = "Essa parada esta errada aí mano...";
            }


        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
