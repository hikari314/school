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
    public partial class FrmProducts : Form
    {
        public FrmProducts()
        {
            InitializeComponent();
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            this.productsBindingSource.MoveLast();
        }

        private void FrmProducts_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataBaseDataSet.Purveyor'. Você pode movê-la ou removê-la conforme necessário.
            this.purveyorTableAdapter.Fill(this.dataBaseDataSet.Purveyor);
            // TODO: esta linha de código carrega dados na tabela 'dataBaseDataSet.Products'. Você pode movê-la ou removê-la conforme necessário.
            this.productsTableAdapter.Fill(this.dataBaseDataSet.Products);

        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            this.productsBindingSource.MoveFirst();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            this.productsBindingSource.MovePrevious();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            this.productsBindingSource.MoveNext();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            Unlock();
            txtCodProd.Focus();

            //comando para aguardar entrada de dados
            productsBindingSource.AddNew();

        }

        private void Unlock()
        {
            foreach(Control Controle in GprData.Controls)
            {
                if (Controle is TextBox)
                {
                    Controle.Enabled = true;
                }
            }

            cboCorporate.Enabled = true;

            //travar botoes
            gprBrowser.Enabled = false;
            btnNew.Enabled = false;
            btnRegister.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnList.Enabled = false;
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            /*i.Qtde Estoque >=0 e <= qtde máxima
             * ii.Qtde Maxima < Qtde Minima
             * iii.Valor unitário > 0
             * iv.Razao social diferente de “branco”*/
            //qtde estoque:
            int d = Convert.ToInt32(txtQuantity.Text);

            //qtde minina:
            int g = Convert.ToInt32(txtMinQuan.Text);

            //qtde maxima:
            int i = Convert.ToInt32(txtMaxQuan.Text);

            //valor unitario:
            int k = Convert.ToInt32(txtUnit.Text);

            //razao social
            string l = cboCorporate.Text;

            if (d >= 0 || d > g || i < g || k > 0 || l != "")
            {
                productsBindingSource.EndEdit();

                productsTableAdapter.Update(dataBaseDataSet.Products);
                MessageBox.Show("Success registering!", "Report");

                productsBindingSource.MoveFirst();
                
                Lock();
            }
            else
            {
                MessageBox.Show("Registering ERROR", "Atention!");
            }
            
        }

        private void Lock()
        {
            foreach (Control Controle in GprData.Controls)
            {
                if (Controle is TextBox)
                {
                    Controle.Enabled = false;
                }
            }

            cboCorporate.Enabled = false;

            //destrava
            gprBrowser.Enabled = true;
            btnNew.Enabled = true;
            btnRegister.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnList.Enabled = true;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Unlock();
            txtCodProd.Enabled = false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm product exclusion?", "ATENTION", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string a = txtQuantity.Text;
                int b = Int32.Parse(a);

                if (b > 0)
                {
                    productsBindingSource.RemoveCurrent();
                    productsTableAdapter.Update(dataBaseDataSet.Products);
                }
                else
                {
                    MessageBox.Show("The stock quantity is 0.", "Atention!");
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            FrmList MyList = new FrmList();
            MyList.ShowDialog();
        }

        private void BtnPur_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.ShowDialog();
        }
    }
}
