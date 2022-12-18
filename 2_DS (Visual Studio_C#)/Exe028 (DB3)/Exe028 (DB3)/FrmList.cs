using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe028__DB3_
{
    public partial class FrmList : Form
    {
        public FrmList()
        {
            InitializeComponent();
        }

        private void FrmList_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataBaseDataSet.Products'. Você pode movê-la ou removê-la conforme necessário.
            this.productsTableAdapter.Fill(this.dataBaseDataSet.Products);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.dataBaseDataSet.Products);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.FillByPurchase(this.dataBaseDataSet.Products);

            if(productsBindingSource.Count == 0)
            {
                MessageBox.Show("There are no products below stock!!!", "ATENTION");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtQuick_TextChanged(object sender, EventArgs e)
        {
            this.productsTableAdapter.FillByQuickConsultation(dataBaseDataSet.Products, "%" + txtQuick.Text + "%");
        }
    }
}
