using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe007
{
    public partial class FrmExe0080427 : Form
    {
        double v1 = 0;
        double v2 = 0;
        double result = 0;
        string operation = "";

        public FrmExe0080427()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            LblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            LblWeekDay.Text = DateTime.Now.ToString("dddd").ToUpper();
            LblHour.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Txt2ndValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LblHour_Click(object sender, EventArgs e)
        {
            
        }

        private void LblDate_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LblHour.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            Txt1stValue.Text = "";
            Txt2ndValue.Text = "";
            LblResult.Text = "";
            v1 = 0;
            v2 = 0;
            result = 0;
            operation = "";
            Txt1stValue.Focus();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                v1 = Convert.ToDouble(Txt1stValue.Text);
                v2 = Convert.ToDouble(Txt2ndValue.Text);
                operation = (sender as Button).Text;

                switch(operation)
                {
                    case "+":
                        {
                            result = v1 + v2;
                            LblResult.Text = result.ToString();
                            break;
                        }

                    case "-":
                        {
                            result = v1 - v2;
                            LblResult.Text = result.ToString();
                            break;
                        }

                    case "*":
                        {
                            result = v1 * v2;
                            LblResult.Text = result.ToString();
                            break;
                        }

                    case "/":
                        {
                            if (v2 != 0)
                            {
                                result = v1 / v2;
                                LblResult.Text = result.ToString();
                                break;
                            }
                            else
                            {
                                throw new Exception("Dividing by zero?");
                            }
                        }

                    default:
                        {
                            result = Math.Pow(v1,v2);
                            LblResult.Text = result.ToString();
                            break;
                        }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Verify values written" + error, "Atention");
                Txt1stValue.SelectAll();
                Txt2ndValue.Focus();
            }
          
        }
    }
}
