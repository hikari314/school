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
    public partial class Query : Form
    {
        FrmExe029 instanciaForm1;

        public Query(FrmExe029 frm1)
        {
            InitializeComponent();

            instanciaForm1 = frm1;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            ClsDB obj = new ClsDB();

            byte typeQuery = 1;

            if (rdbCode.Checked == true)
            {
                typeQuery = 2;
                txtName.Text = "";
            }
            else if (rdbName.Checked == true)
            {
                typeQuery = 3;
                txtCode.Text = "";
            }

            int intcode;
            try
            {
                intcode = Convert.ToInt32(txtCode.Text);
            }
            catch (Exception)
            {
                intcode = 0;
            }

            dgvList.DataSource = obj.DataCheck(typeQuery, intcode, txtName.Text);

            if (dgvList.RowCount == 0)
            {
                MessageBox.Show("This user doesn't exist", "Atention");
            }
        }

        private void DgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            instanciaForm1.txtCode.Text = dgvList.CurrentRow.Cells[0].Value.ToString();
            instanciaForm1.txtPassword.Text = dgvList.CurrentRow.Cells[1].Value.ToString();
            instanciaForm1.txtName.Text = dgvList.CurrentRow.Cells[2].Value.ToString();

            this.Close();
        }

        private void DgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
