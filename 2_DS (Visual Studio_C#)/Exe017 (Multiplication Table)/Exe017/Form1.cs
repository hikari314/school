using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe017
{
    public partial class FrmExe017 : Form
    {
        public FrmExe017()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            CboNumber.SelectedIndex = 0;
            LstResults.Items.Clear();
        }

        private void CboNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            LstResults.Items.Clear();
            int result = 0;

            //aqui é até quanto vai calcular, aqui calcula até 10
            for (int count = 0; count <=10; count++)
            {
                result = count * Convert.ToInt16(CboNumber.SelectedItem);
                LstResults.Items.Add(CboNumber.SelectedItem + " * " + count + " = " + result);
            }
        }

        private void FrmExe017_Load(object sender, EventArgs e)
        {
            //aqui é até que número vai
            for (int x = 0; x <= 100; x++)
                CboNumber.Items.Add(x);

            CboNumber.SelectedIndex = 0;
            /*CboNumber.Items.Add("0");
            CboNumber.Items.Add("1");
            CboNumber.Items.Add("2");
            CboNumber.Items.Add("3");
            CboNumber.Items.Add("4");
            CboNumber.Items.Add("5");
            CboNumber.Items.Add("6");
            CboNumber.Items.Add("7");
            CboNumber.Items.Add("8");
            CboNumber.Items.Add("9");
            CboNumber.Items.Add("10");*/
        }
    }
}
