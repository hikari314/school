namespace Prj001_Maria
{
    partial class FrmPrj001
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrj001));
            this.LblMensage = new System.Windows.Forms.Label();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblMensage
            // 
            this.LblMensage.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.LblMensage, "LblMensage");
            this.LblMensage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblMensage.Name = "LblMensage";
            this.LblMensage.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.BackColor = System.Drawing.Color.DarkGray;
            this.BtnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BtnNext, "BtnNext");
            this.BtnNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.DarkGray;
            this.BtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.BtnBack, "BtnBack");
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.UseVisualStyleBackColor = false;
            // 
            // FrmPrj001
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.LblMensage);
            this.MaximizeBox = false;
            this.Name = "FrmPrj001";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblMensage;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnBack;
    }
}

