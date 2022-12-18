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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataBaseDataSet.Purveyor'. Você pode movê-la ou removê-la conforme necessário.
            this.purveyorTableAdapter.Fill(this.dataBaseDataSet.Purveyor);

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            this.purveyorBindingSource.MoveFirst();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            this.purveyorBindingSource.MovePrevious();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            this.purveyorBindingSource.MoveNext();
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            this.purveyorBindingSource.MoveLast();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Unlock();
            txtCode.Focus();

            //comando para aguardar entrada de dados
            purveyorBindingSource.AddNew();
        }

        private void Unlock()
        {
            foreach (Control Controle in gpRegister.Controls)
            {
                if (Controle is TextBox)
                {
                    Controle.Enabled = true;
                }
            }

            //travar botoes
            gpBrowser.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                purveyorBindingSource.EndEdit();

                purveyorTableAdapter.Update(dataBaseDataSet.Purveyor);
                MessageBox.Show("Success registering!", "Report");

                purveyorBindingSource.MoveFirst();
            }
            catch
            {
                MessageBox.Show("Registering ERROR", "Atention!");
            }

            Lock();
        }

        private void Lock()
        {
            foreach (Control Controle in gpRegister.Controls)
            {
                if (Controle is TextBox)
                {
                    Controle.Enabled = false;
                }
            }

            //destrava
            gpBrowser.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = true;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Unlock();
            txtCode.Enabled = false;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm product exclusion?", "ATENTION",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                purveyorBindingSource.RemoveCurrent();
                purveyorTableAdapter.Update(dataBaseDataSet.Purveyor);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FrmProducts b = new FrmProducts();
            b.ShowDialog();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            FrmList2 c = new FrmList2();
            c.ShowDialog();
        }
    }
}
