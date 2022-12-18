namespace Exe005_Maria
{
    partial class FrmExe005
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
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtGender = new System.Windows.Forms.TextBox();
            this.LblMensage = new System.Windows.Forms.Label();
            this.BtnShow = new System.Windows.Forms.Button();
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl1
            // 
            this.Lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Lbl1.Location = new System.Drawing.Point(59, 43);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(81, 25);
            this.Lbl1.TabIndex = 0;
            this.Lbl1.Text = "Name:";
            // 
            // Lbl2
            // 
            this.Lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Lbl2.Location = new System.Drawing.Point(59, 108);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(94, 26);
            this.Lbl2.TabIndex = 0;
            this.Lbl2.Text = "Gender:";
            this.Lbl2.Click += new System.EventHandler(this.Lbl2_Click);
            // 
            // Lbl3
            // 
            this.Lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Lbl3.Location = new System.Drawing.Point(59, 221);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(101, 26);
            this.Lbl3.TabIndex = 0;
            this.Lbl3.Text = "Mensage";
            this.Lbl3.Click += new System.EventHandler(this.Lbl3_Click);
            // 
            // TxtName
            // 
            this.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxtName.Location = new System.Drawing.Point(159, 36);
            this.TxtName.MaxLength = 50;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(410, 32);
            this.TxtName.TabIndex = 1;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // TxtGender
            // 
            this.TxtGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtGender.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.TxtGender.Location = new System.Drawing.Point(159, 102);
            this.TxtGender.MaxLength = 1;
            this.TxtGender.Name = "TxtGender";
            this.TxtGender.Size = new System.Drawing.Size(41, 32);
            this.TxtGender.TabIndex = 2;
            // 
            // LblMensage
            // 
            this.LblMensage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMensage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LblMensage.Location = new System.Drawing.Point(159, 212);
            this.LblMensage.Name = "LblMensage";
            this.LblMensage.Size = new System.Drawing.Size(403, 35);
            this.LblMensage.TabIndex = 0;
            this.LblMensage.Click += new System.EventHandler(this.LblMensage_Click);
            // 
            // BtnShow
            // 
            this.BtnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.BtnShow.Location = new System.Drawing.Point(159, 150);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(79, 40);
            this.BtnShow.TabIndex = 3;
            this.BtnShow.Text = "&Show";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // BtnClean
            // 
            this.BtnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.BtnClean.Location = new System.Drawing.Point(159, 276);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(119, 40);
            this.BtnClean.TabIndex = 4;
            this.BtnClean.Text = "&Clean All";
            this.BtnClean.UseVisualStyleBackColor = true;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.BtnExit.Location = new System.Drawing.Point(471, 276);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(98, 40);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Text = "&Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmExe005
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 370);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClean);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.LblMensage);
            this.Controls.Add(this.TxtGender);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lbl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Name = "FrmExe005";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forth Project - Conditional Estructure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtGender;
        private System.Windows.Forms.Label LblMensage;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Button BtnExit;
    }
}

