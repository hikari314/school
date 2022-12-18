using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjComunicacaoArduino
{
    public partial class Form1 : Form
    {
        string RxString;

        public Form1()
        {
            InitializeComponent();
            timerCOM.Enabled = true; //Timer chamado "timerCOM"
        }
        private void BtEnviar_Click(object sender, EventArgs e)
        {/*
            if (serialPort1.IsOpen == true)          //porta está aberta
                serialPort1.Write(LblEnviar.Text);  //envia o texto presente no textbox Enviar*/
        }

        private void BtConectar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.PortName = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                    serialPort1.Open();

                }
                catch
                {
                    return;

                }
                if (serialPort1.IsOpen)
                {
                    btConectar.Text = "Desconectar";
                    comboBox1.Enabled = false;
                }
            }
            else
            {

                try
                {
                    serialPort1.Close();
                    comboBox1.Enabled = true;
                    btConectar.Text = "Conectar";
                }
                catch
                {
                    return;
                }
            }
        }


        private void atualizaListaCOMs()
        {
            int i;
            bool quantDiferente;    //flag para sinalizar que a quantidade de portas mudou

            i = 0;
            quantDiferente = false;

            //se a quantidade de portas mudou
            if (comboBox1.Items.Count == SerialPort.GetPortNames().Length) //Modo de comunicação serial externa entre o PC e o arduino
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (comboBox1.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;                     //retorna
            }

            //limpa comboBox
            comboBox1.Items.Clear();

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            comboBox1.SelectedIndex = 0;
        }

        private void TimerCOM_Tick(object sender, EventArgs e)
        {
            atualizaListaCOMs();
        }
        
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)  // se porta aberta 
                serialPort1.Close();            //fecha a porta
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            RxString = serialPort1.ReadExisting();              //le o dado disponível na serial
            this.Invoke(new EventHandler(trataDadoRecebido));   //chama outra thread(subprocesso) para escrever o dado no text box
                //Como o subprocesso é muito rápido ele invoca um cara mais lento e joga pra ele (esse cara é o que desenha na tela)
                //Invoke não precisa dos parenteses, só do título do método
        }

        private void trataDadoRecebido(object sender, EventArgs e)
        {
           // textBoxReceber.AppendText(RxString); //se ja tem texto, passe todas as linhas para o final
        }

        private void Tbar_Scroll(object sender, EventArgs e)
        {
            int max = 255;
            LblEnviar.Text = "" + tbar.Value+"\n";
            if (serialPort1.IsOpen == true)          //porta está aberta
                serialPort1.Write(LblEnviar.Text);

            int sv = Convert.ToInt32(tbar.Value);

            if (sv >= 0 && sv < 255)
                LblEnviar.BackColor = Color.FromArgb(255, sv, 0);
            if (sv >= 255 && sv < 510)
                LblEnviar.BackColor = Color.FromArgb(255 - sv / 2, 255, 0);
            if (sv >= 510 && sv < 765)
                LblEnviar.BackColor = Color.FromArgb(0, 255, sv / 3);
            if (sv >= 765 && sv < 1020)
                LblEnviar.BackColor = Color.FromArgb(0, 255 - sv / 4, 255);
            if (sv >= 1020 && sv < 1275)
                LblEnviar.BackColor = Color.FromArgb(sv / 5, 0, 255);
        }
    }
}