using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe026__Database_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataBaseDataSet);
            //aqui é automatico, como o form load, o VS que faz
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataBaseDataSet.Table'. Você pode movê-la ou removê-la conforme necessário.
            this.tableTableAdapter.Fill(this.dataBaseDataSet.Table); //carga do banco de dados pro DataSet | o adapter faz a conexao do bd real e do bd virtual

        }

        private void BtnShowM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Men Total = " + tableTableAdapter.CountM().ToString() + Environment.NewLine + "Womans Total = " + tableTableAdapter.CountF().ToString());
        }
    }
}
