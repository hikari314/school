using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe022__POO___OOL_
{
    public partial class FrmExe022 : Form
    {
        public FrmExe022()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // Instanciar a classe antes de usa-la: (aqui o construtor é executado)
            ClsOperacao ObjOperacao = new ClsOperacao(); //o ObjOperacao é o nome que voce quer no objeto

            //aqui é o set, manda info para o _value1 / _value2
            ObjOperacao.Value1 = Convert.ToInt32(txt1value.Text); 
            ObjOperacao.Value2 = Convert.ToInt32(txt2value.Text);

            //executa o metodo Somar():
            /* int result = 0;
             * 
             * result = ObjOperacao.Somar();      vai no ObjOperacao, execute somar e guarde no lbl
             * lblResult.Text = result;*/

            lblResult.Text = ObjOperacao.Add().ToString();
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            txt1value.Text = "";
            txt2value.Text = "";
            lblResult.Text = "";
            txt1value.Focus();
        }

        private void BtnE_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LblOpen2_Click(object sender, EventArgs e)
        {
            FrmExe023 myForm = new FrmExe023();
            myForm.Show();
        }
    }
}
