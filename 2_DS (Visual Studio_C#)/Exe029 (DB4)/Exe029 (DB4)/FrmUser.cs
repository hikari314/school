using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exe029__DB4_.AccessDB;

namespace Exe029__DB4_
{
    public partial class FrmExe029 : Form
    {
        public FrmExe029()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            Query a = new Query(this);
            a.ShowDialog(); //se colocar só o show, o user pode mudar os dois forms ao mesmo tempo - n dá pra voltar pro form anterior
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            ClsDB objB = new ClsDB();

            objB.CodUser = Convert.ToInt32(txtCode.Text);
            objB.Pass = Convert.ToInt32(txtPassword.Text);
            objB.NameUser = txtName.Text;

            int status;
            status = objB.Register();

            if (status != 0)
            {
                MessageBox.Show("Register concluded!", "Success");
            }
            else
            {
                MessageBox.Show("Error registering", "*** ERROR ***");
            }
            Clean();
        }

        private void Clean()
        {
            txtCode.Text = "";
            txtPassword.Text = "";
            txtName.Text = "";
            txtCode.Focus();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            ClsDB objBa = new ClsDB();

            objBa.CodUser = Convert.ToInt32(txtCode.Text);
            objBa.Pass = Convert.ToInt32(txtPassword.Text);
            objBa.NameUser = txtName.Text ;

            int status;
            status = objBa.Edit();

            if (status != 0)
            {
                MessageBox.Show("Edit succesfull", "Success");
            }
            else
            {
                MessageBox.Show("Error in the editing process", "*** ERROR ***");
            }
            Clean();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            ClsDB objBan = new ClsDB();

            objBan.CodUser = Convert.ToInt32(txtCode.Text);

            int status;
            status = objBan.Delete();

            if (status != 0)
            {
                MessageBox.Show("Exclusion succesfull", "Success");
            }
            else
            {
                MessageBox.Show("Error in the exclusion process", "*** ERROR ***");
            }
            Clean();
        }
    }
}
