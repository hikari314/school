using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe027__DB2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EmployeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataBaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataBaseDataSet.Employees'. Você pode movê-la ou removê-la conforme necessário.
            this.employeesTableAdapter.Fill(this.dataBaseDataSet.Employees);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            decimal totalWage = (decimal)employeesTableAdapter.SumWage();
            MessageBox.Show("Wage Total: " + totalWage.ToString("C2"));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are u sure?", "EXIT");
            Application.Exit();
        }
    }
}
