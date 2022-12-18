using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe011
{
    public partial class Form1 : Form
    {
        int totalDays = 0;
        double priceDaily = 0;
        double totalDaily = 0;
        double priceDiscount = 0;
        double totalServices = 0;
        double priceSubT = 0;
        double totalPayble = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            RdbSimple.Checked = false;
            RdbDouble.Checked = false;
            CheckB1.Checked = false;
            CheckB2.Checked = false;
            CheckB3.Checked = false;
            CheckB4.Checked = false;
            MasTxtIn.Text = "";
            MasTxtOut.Text = "";
            RdbCash.Checked = false;
            RdbInsta.Checked = false;
            LblStayed.Text = "";
            LblDaily.Text = "";
            LblTotalS.Text = "";
            LblDiscount.Text = "";
            LblSubT.Text = "";
            LblTotal.Text = "";
            MasTxtIn.Focus();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            LblDate.Text = DateTime.Now.ToString("dddd");
            LblHour.Text = DateTime.Now.ToString("HH:mm:ss");
            MasTxtOut.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LblHour.Text = DateTime.Now.ToString("hh:mm:ss");
            
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime EntryDate = Convert.ToDateTime(MasTxtIn.Text);
                DateTime OutDate = Convert.ToDateTime(MasTxtOut.Text);

                //dias hospedados
                totalDays = ((OutDate).Subtract(EntryDate)).Days;
                LblStayed.Text = totalDays.ToString();

                //kind of room
                if (RdbSimple.Checked)
                    priceDaily = 800;
                else
                    priceDaily = 1500;

                //valor diarias
                totalDaily = priceDaily * totalDays;
                LblDaily.Text = totalDaily.ToString("C1");

                //forma pagamento
                if (RdbCash.Checked)
                    priceDiscount = (totalDaily * 5) / 100;
                else
                    priceDiscount = 0;
                LblDiscount.Text = priceDiscount.ToString("C1");

                //sub total
                priceSubT = totalDaily - priceDiscount;
                LblSubT.Text = priceSubT.ToString("C1");

                //servicos
                if (CheckB1.Checked)
                    totalServices = 250;
                if (CheckB2.Checked)
                    totalServices += 460;
                if (CheckB3.Checked)
                    totalServices += 520;
                if (CheckB4.Checked)
                    totalServices += 680;
                LblTotalS.Text = totalServices.ToString("C1");

                //total a pagar
                totalPayble = priceSubT + totalServices;
                LblTotal.Text = totalPayble.ToString("C1");
            }
            catch
            {
                MessageBox.Show("Write a real date!", "Atention!");
                MasTxtIn.Focus();
            }

        }
    }
}
