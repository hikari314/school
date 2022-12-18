using Exe025__Abstract_Class_.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe025__Abstract_Class_.Forms
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Program.statusMenu = ""; //aqui tá reinicializando a variavel, tá "destravando"
            this.Close();
        }

        private void BtnAddt_Click(object sender, EventArgs e)
        {
            ClsTeacher ObjT = new ClsTeacher();

            ObjT.Itr = txtITRt.Text;
            ObjT.Name = txtNamet.Text;
            ObjT.Address = txtAddresst.Text;
            ObjT.Degree = txtDegree.Text;
            ObjT.Category = txtCategory.Text;

            lblStatus.Text = ObjT.Add();
        }

        private void BtnDeletet_Click(object sender, EventArgs e)
        {
            ClsTeacher ObjTe = new ClsTeacher();

            if (txtITRt.Text != "")
            {
                ObjTe.Itr = txtITRt.Text;
                lblStatus.Text = ObjTe.Delete();
            }
            else
            {
                lblStatus.Text = "ATENTION: Write your ITR number to be excluded!";
            }
        }

        private void BtnAdds_Click(object sender, EventArgs e)
        {
            ClsStudent ObjS = new ClsStudent();
            
            ObjS.Itr = txtIRTs.Text;
            ObjS.Name = txtNames.Text;
            ObjS.Address = txtAdresss.Text;
            ObjS.Course = txtCourse.Text;
            ObjS.Class = txtClass.Text;
            
            lblStatus.Text = ObjS.Add();
        }

        private void BtnDeletes_Click(object sender, EventArgs e)
        {
            ClsStudent ObjSt = new ClsStudent();
            
            if (txtIRTs.Text != "")
            {
                ObjSt.Itr = txtIRTs.Text;
                lblStatus.Text = ObjSt.Delete();
            }
            else
            {
                lblStatus.Text = "ATENTION: Write your ITR number to be excluded!";
            }
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            if (TandS.SelectedIndex == 0)
            {
                foreach(TextBox CaixaTexto in gpT.Controls)
                {
                    CaixaTexto.Text = "";
                }
            }
            else
            {
                foreach(TextBox CaixaTexto in gpS.Controls)
                {
                    CaixaTexto.Text = "";
                }
            }
            lblStatus.Text = "";
        }

        private void TxtITRt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
