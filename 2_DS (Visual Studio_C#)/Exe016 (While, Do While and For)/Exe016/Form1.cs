using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe016
{
    public partial class FrmExe016 : Form
    {
        public FrmExe016()
        {
            InitializeComponent();
        }

        private void BtnFinish_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnWhile_Click(object sender, EventArgs e)
        {
            //while testa primeiro e depois faz a condicao 
            LstYears.Items.Clear();
            int todayYear = 0;
            todayYear = Convert.ToInt16(DateTime.Now.ToString("yyyy"));
            int startYear = 1990;
            while (startYear <= todayYear)
            {
                LstYears.Items.Add(startYear);
                startYear++; //adiciona 1 ao startYear
            }
        }

        private void BtnDoWhile_Click(object sender, EventArgs e)
        {
            //do while o processo é feito antes e testa depois
            LstYears.Items.Clear();
            int todayYear = 0;
            todayYear = Convert.ToInt16(DateTime.Now.ToString("yyyy"));
            int startYear = 2850;
            do
            {
                LstYears.Items.Add(startYear);
                startYear++;
            }
            while (startYear <= todayYear);
        }

        private void BtnFor_Click(object sender, EventArgs e)
        {
            //for é como o while - usa quando as condicoes sao numericas!
            LstYears.Items.Clear();

            int todayYear = 0;
            todayYear = Convert.ToInt16(DateTime.Now.ToString("yyyy"));

            //for(var controle; condicao; incremento)
            for (int startYear = 1900; startYear <= todayYear; startYear++)
                LstYears.Items.Add(startYear);
        }
    }
}
