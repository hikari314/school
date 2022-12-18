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
    public partial class FrmList2 : Form
    {
        public FrmList2()
        {
            InitializeComponent();
        }

        private void FrmList2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'dataBaseDataSet.Purveyor'. Você pode movê-la ou removê-la conforme necessário.
            this.purveyorTableAdapter.Fill(this.dataBaseDataSet.Purveyor);

        }

        private void TxtQuick_TextChanged(object sender, EventArgs e)
        {
            this.purveyorTableAdapter.FillByQuick(dataBaseDataSet.Purveyor, "%" + txtQuick.Text + "%");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.purveyorTableAdapter.Fill(this.dataBaseDataSet.Purveyor);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
