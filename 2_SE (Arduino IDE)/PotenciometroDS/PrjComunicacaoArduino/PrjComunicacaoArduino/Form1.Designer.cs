namespace PrjComunicacaoArduino
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btConectar = new System.Windows.Forms.Button();
            this.btEnviar = new System.Windows.Forms.Button();
            this.timerCOM = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tbar = new System.Windows.Forms.TrackBar();
            this.LblEnviar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbar)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 32);
            this.comboBox1.TabIndex = 0;
            // 
            // btConectar
            // 
            this.btConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConectar.Location = new System.Drawing.Point(196, 12);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(166, 32);
            this.btConectar.TabIndex = 1;
            this.btConectar.Text = "Conectar";
            this.btConectar.UseVisualStyleBackColor = true;
            this.btConectar.Click += new System.EventHandler(this.BtConectar_Click);
            // 
            // btEnviar
            // 
            this.btEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnviar.Location = new System.Drawing.Point(196, 63);
            this.btEnviar.Name = "btEnviar";
            this.btEnviar.Size = new System.Drawing.Size(166, 32);
            this.btEnviar.TabIndex = 4;
            this.btEnviar.Text = "Enviar";
            this.btEnviar.UseVisualStyleBackColor = true;
            this.btEnviar.Click += new System.EventHandler(this.BtEnviar_Click);
            // 
            // timerCOM
            // 
            this.timerCOM.Tick += new System.EventHandler(this.TimerCOM_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // tbar
            // 
            this.tbar.AutoSize = false;
            this.tbar.LargeChange = 1;
            this.tbar.Location = new System.Drawing.Point(10, 112);
            this.tbar.Maximum = 1275;
            this.tbar.Name = "tbar";
            this.tbar.Size = new System.Drawing.Size(352, 32);
            this.tbar.TabIndex = 5;
            this.tbar.Scroll += new System.EventHandler(this.Tbar_Scroll);
            // 
            // LblEnviar
            // 
            this.LblEnviar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEnviar.Location = new System.Drawing.Point(12, 63);
            this.LblEnviar.Name = "LblEnviar";
            this.LblEnviar.Size = new System.Drawing.Size(166, 32);
            this.LblEnviar.TabIndex = 6;
            this.LblEnviar.Text = "0";
            this.LblEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 160);
            this.Controls.Add(this.LblEnviar);
            this.Controls.Add(this.tbar);
            this.Controls.Add(this.btEnviar);
            this.Controls.Add(this.btConectar);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comunicação Arduino";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.tbar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.Button btEnviar;
        private System.Windows.Forms.Timer timerCOM;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TrackBar tbar;
        private System.Windows.Forms.Label LblEnviar;
    }
}

