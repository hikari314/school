namespace Exe021__Writing_Methods_
{
    partial class FrmExe021
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCheck01 = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheck02 = new System.Windows.Forms.Button();
            this.btnCheck03 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnExit.Location = new System.Drawing.Point(186, 269);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 31);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnClean.Location = new System.Drawing.Point(76, 269);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(87, 31);
            this.btnClean.TabIndex = 12;
            this.btnClean.Text = "Clean ";
            this.btnClean.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox1.Location = new System.Drawing.Point(17, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 89);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result:";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(21, 35);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(294, 29);
            this.lblResult.TabIndex = 0;
            // 
            // btnCheck01
            // 
            this.btnCheck01.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCheck01.Location = new System.Drawing.Point(250, 58);
            this.btnCheck01.Name = "btnCheck01";
            this.btnCheck01.Size = new System.Drawing.Size(102, 31);
            this.btnCheck01.TabIndex = 10;
            this.btnCheck01.Text = "Check I";
            this.btnCheck01.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCheck01.UseVisualStyleBackColor = true;
            this.btnCheck01.Click += new System.EventHandler(this.BtnCheck01_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtNumber.Location = new System.Drawing.Point(169, 95);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(56, 30);
            this.txtNumber.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Write a number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(111, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Prime Numbers";
            // 
            // btnCheck02
            // 
            this.btnCheck02.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCheck02.Location = new System.Drawing.Point(250, 95);
            this.btnCheck02.Name = "btnCheck02";
            this.btnCheck02.Size = new System.Drawing.Size(102, 31);
            this.btnCheck02.TabIndex = 14;
            this.btnCheck02.Text = "Check II";
            this.btnCheck02.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCheck02.UseVisualStyleBackColor = true;
            this.btnCheck02.Click += new System.EventHandler(this.BtnCheck02_Click);
            // 
            // btnCheck03
            // 
            this.btnCheck03.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCheck03.Location = new System.Drawing.Point(250, 132);
            this.btnCheck03.Name = "btnCheck03";
            this.btnCheck03.Size = new System.Drawing.Size(102, 31);
            this.btnCheck03.TabIndex = 15;
            this.btnCheck03.Text = "Check III";
            this.btnCheck03.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCheck03.UseVisualStyleBackColor = true;
            this.btnCheck03.Click += new System.EventHandler(this.BtnCheck03_Click);
            // 
            // FrmExe021
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 312);
            this.Controls.Add(this.btnCheck03);
            this.Controls.Add(this.btnCheck02);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCheck01);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmExe021";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCheck01;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheck02;
        private System.Windows.Forms.Button btnCheck03;
    }
}

