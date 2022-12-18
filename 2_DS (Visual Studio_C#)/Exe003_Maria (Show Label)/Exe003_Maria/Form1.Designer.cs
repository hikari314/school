namespace Exe003_Maria
{
    partial class FrmExe003
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExe003));
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.BtnShowName = new System.Windows.Forms.Button();
            this.LblWelcomeName = new System.Windows.Forms.Label();
            this.LblWelcome = new System.Windows.Forms.Label();
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl1
            // 
            this.Lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Lbl1.Location = new System.Drawing.Point(69, 76);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(201, 45);
            this.Lbl1.TabIndex = 0;
            this.Lbl1.Text = "Write your name:";
            this.Lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl2
            // 
            this.Lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Lbl2.Location = new System.Drawing.Point(81, 176);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(189, 40);
            this.Lbl2.TabIndex = 1;
            this.Lbl2.Text = "Welcome:";
            this.Lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxtName.Location = new System.Drawing.Point(276, 83);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(367, 32);
            this.TxtName.TabIndex = 0;
            // 
            // BtnShowName
            // 
            this.BtnShowName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnShowName.Location = new System.Drawing.Point(276, 121);
            this.BtnShowName.Name = "BtnShowName";
            this.BtnShowName.Size = new System.Drawing.Size(108, 34);
            this.BtnShowName.TabIndex = 1;
            this.BtnShowName.Text = "&Show";
            this.BtnShowName.UseVisualStyleBackColor = true;
            this.BtnShowName.Click += new System.EventHandler(this.BtnShowName_Click);
            // 
            // LblWelcomeName
            // 
            this.LblWelcomeName.AutoSize = true;
            this.LblWelcomeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblWelcomeName.Location = new System.Drawing.Point(191, 159);
            this.LblWelcomeName.Name = "LblWelcomeName";
            this.LblWelcomeName.Size = new System.Drawing.Size(0, 17);
            this.LblWelcomeName.TabIndex = 4;
            // 
            // LblWelcome
            // 
            this.LblWelcome.AutoSize = true;
            this.LblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblWelcome.Location = new System.Drawing.Point(191, 162);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(0, 17);
            this.LblWelcome.TabIndex = 5;
            // 
            // BtnClean
            // 
            this.BtnClean.Enabled = false;
            this.BtnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnClean.Location = new System.Drawing.Point(144, 241);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(126, 37);
            this.BtnClean.TabIndex = 2;
            this.BtnClean.Text = "&Clean All";
            this.BtnClean.UseVisualStyleBackColor = true;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnExit.Location = new System.Drawing.Point(325, 241);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(94, 37);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "&Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblAnswer
            // 
            this.LblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LblAnswer.Location = new System.Drawing.Point(276, 176);
            this.LblAnswer.Name = "LblAnswer";
            this.LblAnswer.Size = new System.Drawing.Size(367, 32);
            this.LblAnswer.TabIndex = 8;
            // 
            // FrmExe003
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblAnswer);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClean);
            this.Controls.Add(this.LblWelcome);
            this.Controls.Add(this.LblWelcomeName);
            this.Controls.Add(this.BtnShowName);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lbl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "FrmExe003";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextBox - Third Exercise";
         
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnShowName;
        private System.Windows.Forms.Label LblWelcomeName;
        private System.Windows.Forms.Label LblWelcome;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblAnswer;
    }
}

