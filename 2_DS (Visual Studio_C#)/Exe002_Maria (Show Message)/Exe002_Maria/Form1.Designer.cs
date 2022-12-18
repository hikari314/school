namespace Exe002_Maria
{
    partial class FrmExe002
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
            this.LblMensage = new System.Windows.Forms.Label();
            this.BtnMensage1 = new System.Windows.Forms.Button();
            this.BtnMensage2 = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblMensage
            // 
            this.LblMensage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMensage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LblMensage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LblMensage.Location = new System.Drawing.Point(232, 74);
            this.LblMensage.Name = "LblMensage";
            this.LblMensage.Size = new System.Drawing.Size(352, 63);
            this.LblMensage.TabIndex = 0;
            this.LblMensage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblMensage.Click += new System.EventHandler(this.LblMensage_Click);
            // 
            // BtnMensage1
            // 
            this.BtnMensage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnMensage1.Location = new System.Drawing.Point(87, 268);
            this.BtnMensage1.Name = "BtnMensage1";
            this.BtnMensage1.Size = new System.Drawing.Size(125, 32);
            this.BtnMensage1.TabIndex = 1;
            this.BtnMensage1.Text = "Show Mensage 1";
            this.BtnMensage1.UseVisualStyleBackColor = true;
            this.BtnMensage1.Click += new System.EventHandler(this.BtnMensage1_Click);
            // 
            // BtnMensage2
            // 
            this.BtnMensage2.Enabled = false;
            this.BtnMensage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnMensage2.Location = new System.Drawing.Point(358, 268);
            this.BtnMensage2.Name = "BtnMensage2";
            this.BtnMensage2.Size = new System.Drawing.Size(136, 32);
            this.BtnMensage2.TabIndex = 2;
            this.BtnMensage2.Text = "Show Mensage 2";
            this.BtnMensage2.UseVisualStyleBackColor = true;
            this.BtnMensage2.Click += new System.EventHandler(this.BtnMensage2_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnExit.Location = new System.Drawing.Point(622, 268);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(97, 32);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmExe002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnMensage2);
            this.Controls.Add(this.BtnMensage1);
            this.Controls.Add(this.LblMensage);
            this.MaximizeBox = false;
            this.Name = "FrmExe002";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblMensage;
        private System.Windows.Forms.Button BtnMensage1;
        private System.Windows.Forms.Button BtnMensage2;
        private System.Windows.Forms.Button BtnExit;
    }
}

