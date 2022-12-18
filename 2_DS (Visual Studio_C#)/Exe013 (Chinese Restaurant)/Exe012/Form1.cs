using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe012
{
    public partial class FrmExe012 : Form
    {
        public FrmExe012()
        {
            InitializeComponent();
        }

        private void FrmExe012_Load(object sender, EventArgs e)
        {
            CboMain.Items.Add("Shrimp Yakisoba");
            CboMain.Items.Add("Yakimshi");
            CboMain.Items.Add("Yakisoba");

            CboMain.SelectedIndex = 0;

            LstSide.Items.Add("Beef with Broccoli");
            LstSide.Items.Add("Bittersweet Chicken");
            LstSide.Items.Add("Kung Pao Chicken");
            LstSide.Items.Add("Meat with Vegetables");
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Program Exit", "Atention", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnInDish_Click(object sender, EventArgs e)
        {
            if (!LstBOrder.Items.Contains(CboMain.Text))
            {
                LstBOrder.Items.Add(CboMain.Text);
                LblItems.Text = Convert.ToString(LstBOrder.Items.Count);
                BtnInSide.Enabled = true;
            }
            else
            {
                MessageBox.Show("This dish already exists in the order", "Atention");
            }
        }

        private void BtnExclude_Click(object sender, EventArgs e)
        {
            int ItemDelete = LstBOrder.SelectedIndex;
            if (ItemDelete < 0)
                MessageBox.Show("You need to select an item", "Atention!");
            else
            {
                LstBOrder.Items.RemoveAt(LstBOrder.SelectedIndex);
                LblItems.Text = Convert.ToString(LstBOrder.Items.Count);
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            LstBOrder.Items.Clear();
            LblItems.Text = "0";
            CboMain.SelectedIndex = 0;
        }

        private void BtnInSide_Click(object sender, EventArgs e)
        {
            if (LstSide.SelectedIndex < 0)
                MessageBox.Show("You need to select an side dish", "Atention");
            else
            {
                LstBOrder.Items.Add(LstSide.Text);
                LblItems.Text = Convert.ToString(LstBOrder.Items.Count);
                LstSide.SelectedIndex = -1;
            }
        }

        private void LstSide_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
