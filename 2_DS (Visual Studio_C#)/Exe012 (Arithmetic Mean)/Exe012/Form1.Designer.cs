namespace Exe012
{
    partial class FrmExe012
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
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl1V = new System.Windows.Forms.Label();
            this.Lbl2V = new System.Windows.Forms.Label();
            this.Txt1V = new System.Windows.Forms.TextBox();
            this.Txt2V = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnValidate = new System.Windows.Forms.Button();
            this.BtnMean = new System.Windows.Forms.Button();
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblHigh = new System.Windows.Forms.Label();
            this.LblMean = new System.Windows.Forms.Label();
            this.LblLow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(266, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arithmetic Mean";
            // 
            // Lbl1V
            // 
            this.Lbl1V.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.Lbl1V.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Lbl1V.Location = new System.Drawing.Point(12, 52);
            this.Lbl1V.Name = "Lbl1V";
            this.Lbl1V.Size = new System.Drawing.Size(191, 31);
            this.Lbl1V.TabIndex = 1;
            this.Lbl1V.Text = "Insert the first value: ";
            // 
            // Lbl2V
            // 
            this.Lbl2V.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.Lbl2V.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Lbl2V.Location = new System.Drawing.Point(12, 95);
            this.Lbl2V.Name = "Lbl2V";
            this.Lbl2V.Size = new System.Drawing.Size(228, 35);
            this.Lbl2V.TabIndex = 2;
            this.Lbl2V.Text = "Insert the second value: ";
            // 
            // Txt1V
            // 
            this.Txt1V.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Txt1V.Location = new System.Drawing.Point(246, 49);
            this.Txt1V.Name = "Txt1V";
            this.Txt1V.Size = new System.Drawing.Size(100, 30);
            this.Txt1V.TabIndex = 3;
            // 
            // Txt2V
            // 
            this.Txt2V.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Txt2V.Location = new System.Drawing.Point(246, 92);
            this.Txt2V.Name = "Txt2V";
            this.Txt2V.Size = new System.Drawing.Size(100, 30);
            this.Txt2V.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(12, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Highest value: ";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(12, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Arithmetic Avarage: ";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lowest value: ";
            // 
            // BtnValidate
            // 
            this.BtnValidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnValidate.Location = new System.Drawing.Point(390, 49);
            this.BtnValidate.Name = "BtnValidate";
            this.BtnValidate.Size = new System.Drawing.Size(101, 73);
            this.BtnValidate.TabIndex = 11;
            this.BtnValidate.Text = "Validate values";
            this.BtnValidate.UseVisualStyleBackColor = true;
            this.BtnValidate.Click += new System.EventHandler(this.BtnValidate_Click);
            // 
            // BtnMean
            // 
            this.BtnMean.Enabled = false;
            this.BtnMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnMean.Location = new System.Drawing.Point(85, 133);
            this.BtnMean.Name = "BtnMean";
            this.BtnMean.Size = new System.Drawing.Size(174, 42);
            this.BtnMean.TabIndex = 12;
            this.BtnMean.Text = "Arithmetic Mean";
            this.BtnMean.UseVisualStyleBackColor = true;
            this.BtnMean.Click += new System.EventHandler(this.BtnMean_Click);
            // 
            // BtnClean
            // 
            this.BtnClean.Enabled = false;
            this.BtnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnClean.Location = new System.Drawing.Point(390, 190);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(101, 39);
            this.BtnClean.TabIndex = 13;
            this.BtnClean.Text = "&Clean All";
            this.BtnClean.UseVisualStyleBackColor = true;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnExit.Location = new System.Drawing.Point(390, 253);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(101, 39);
            this.BtnExit.TabIndex = 14;
            this.BtnExit.Text = "&Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblHigh
            // 
            this.LblHigh.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.LblHigh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblHigh.Location = new System.Drawing.Point(246, 262);
            this.LblHigh.Name = "LblHigh";
            this.LblHigh.Size = new System.Drawing.Size(100, 30);
            this.LblHigh.TabIndex = 15;
            // 
            // LblMean
            // 
            this.LblMean.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.LblMean.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblMean.Location = new System.Drawing.Point(246, 226);
            this.LblMean.Name = "LblMean";
            this.LblMean.Size = new System.Drawing.Size(100, 30);
            this.LblMean.TabIndex = 16;
            // 
            // LblLow
            // 
            this.LblLow.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.LblLow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblLow.Location = new System.Drawing.Point(246, 190);
            this.LblLow.Name = "LblLow";
            this.LblLow.Size = new System.Drawing.Size(100, 30);
            this.LblLow.TabIndex = 17;
            // 
            // FrmExe012
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(533, 322);
            this.Controls.Add(this.LblLow);
            this.Controls.Add(this.LblMean);
            this.Controls.Add(this.LblHigh);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClean);
            this.Controls.Add(this.BtnMean);
            this.Controls.Add(this.BtnValidate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt2V);
            this.Controls.Add(this.Txt1V);
            this.Controls.Add(this.Lbl2V);
            this.Controls.Add(this.Lbl1V);
            this.Controls.Add(this.label1);
            this.Name = "FrmExe012";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exe012 - Arithmetic ";
            this.Load += new System.EventHandler(this.FrmExe012_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl1V;
        private System.Windows.Forms.Label Lbl2V;
        private System.Windows.Forms.TextBox Txt1V;
        private System.Windows.Forms.TextBox Txt2V;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnValidate;
        private System.Windows.Forms.Button BtnMean;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblHigh;
        private System.Windows.Forms.Label LblMean;
        private System.Windows.Forms.Label LblLow;
    }
}

