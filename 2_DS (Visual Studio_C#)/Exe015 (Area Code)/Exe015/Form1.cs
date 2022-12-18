using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe015
{
    public partial class FrmExe015 : Form
    {
        public FrmExe015()
        {
            InitializeComponent();
        }

        private void FrmExe015_Load(object sender, EventArgs e)
        {
            //SORTED(ordem alfabetica) = true ^ DropDownStyle(pra pessoa nao digitar nada) = DroDownList

            CboDDD.Items.Add("São Paulo/SP");
            CboDDD.Items.Add("Rio de Janeiro/RJ");
            CboDDD.Items.Add("Vitória/ES");
            CboDDD.Items.Add("Belo Horizonte/MG");
            CboDDD.Items.Add("Curitiba/PR");
            CboDDD.Items.Add("Florianopolis/SC");
            CboDDD.Items.Add("Porto Alegre/RS");
            CboDDD.Items.Add("Brasilia/DF");
            CboDDD.Items.Add("Goiania/GO");
            CboDDD.Items.Add("Palmas/TO");

            CboDDD.SelectedIndex = 0;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string city = CboDDD.Text;
            switch (city) //usa switch quando tem algo parecido em todos, por exemplo, aqui é a mesma variavel "cidade" em todos
            { 
                /* quando tem mais de um DDD com a mesma reposta
                 case "São Pedro/SP":
                 case "Americana/SP":
                 case "Campinas/SP":
                    LblDDD.text = "19";
                    break;*/
                case "São Paulo/SP":
                    LblDDD.Text = "11";
                    break;
                case "Rio de Janeiro/RJ":
                    LblDDD.Text = "21";
                    break;
                case "Vitória/ES":
                    LblDDD.Text = "27";
                    break;
                case "Belo Horizonte/MG":
                    LblDDD.Text = "31";
                    break;
                case "Curitiba/PR":
                    LblDDD.Text = "41";
                    break;
                case "Florianopolis/SC":
                    LblDDD.Text = "48";
                    break;
                case "Porto Alegre/RS":
                    LblDDD.Text = "51";
                    break;
                case "Brasilia/DF":
                    LblDDD.Text = "61";
                    break;
                case "Goiania/GO":
                    LblDDD.Text = "62";
                    break;
                default: //o ultimo case é sempre a negativa de todos os outros
                    LblDDD.Text = "63";
                    break;
            }
            
            /*if (CboDDD.Text == "São Paulo/SP")
                LblDDD.Text = "11";
            else if (CboDDD.Text == "Rio de Janeiro/RJ")
                LblDDD.Text = "21";
            else if (CboDDD.Text == "Vitória/ES")
                LblDDD.Text = "27";
            else if (CboDDD.Text == "Belo Horizonte/MG")
                LblDDD.Text = "31";
            else if (CboDDD.Text == "Curitiba/PR")
                LblDDD.Text = "41";
            else if (CboDDD.Text == "Florianopolis/SC")
                LblDDD.Text = "48";
            else if (CboDDD.Text == "Porto Alegre/RS")
                LblDDD.Text = "51";
            else if (CboDDD.Text == "Brasilia/DF")
                LblDDD.Text = "61";
            else if (CboDDD.Text == "Goiania/GO")
                LblDDD.Text = "62";
            else if (CboDDD.Text == "Palmas/TO")
                LblDDD.Text = "63";*/
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            LblDDD.Text = ""; 
            CboDDD.SelectedIndex = 0; 
            BtnSearch.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
