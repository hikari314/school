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

namespace PrjArduino
{
    public partial class Form1 : Form
    {
        string RxString;


        public Form1()
        {
            InitializeComponent();
            timerCOM.Enabled = true;
        }

        private void atualizaListaCOMs()
        {
            int i;
            bool quantDiferente;    //flag para sinalizar que a quantidade de portas mudou

            i = 0;
            quantDiferente = false;

            //se a quantidade de portas mudou
            if (comboBox1.Items.Count == SerialPort.GetPortNames().Length)
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
            atualizaListaCOMs(); //a cada 100ms vai verificar se tem um arduino conectado 
            //o arduino tem portas COM3, COM4 e COM5 ai vai aparecer no combobox (tem que apertar pra aparecer, n vai automatico)
        }

        private void BtnConectar_Click(object sender, EventArgs e)
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
                    btnConectar.Text = "Desconectar";
                    comboBox1.Enabled = false;
                }
            }
            else
            {
                try
                {
                    serialPort1.Close();
                    comboBox1.Enabled = true;
                    btnConectar.Text = "Conectar";
                }
                catch
                {
                    return;
                }

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) //evento
        {
            if (serialPort1.IsOpen == true)  // se porta aberta 
                serialPort1.Close();            //fecha a porta
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)          //porta está aberta
                serialPort1.Write(txtEnviar.Text);  //envia o texto presente no textbox Enviar
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            RxString = serialPort1.ReadExisting();              //le o dado disponível na serial
            this.Invoke(new EventHandler(trataDadoRecebido));   //chama outra thread para escrever o dado no text box
        }

        private void trataDadoRecebido(object sender, EventArgs e)
        {
            txtReceber.AppendText(RxString); //apende coloca na ultima linha - se tiver codigo já onde vai ter o texo, vai procurar a ultima linha desse texto que tá lá
        }

        //

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            string a = trackBar1.Value.ToString();
            txtReceber.Text = a;
        }
    }
}
