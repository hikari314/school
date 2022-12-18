namespace Exe007
{
    partial class FrmExe007
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
            this.GpValues = new System.Windows.Forms.GroupBox();
            this.BtnValidate = new System.Windows.Forms.Button();
            this.Txt2ndValue = new System.Windows.Forms.TextBox();
            this.Txt1stValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GpOperations = new System.Windows.Forms.GroupBox();
            this.LblResult = new System.Windows.Forms.Label();
            this.BtnPower = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.BtnMulti = new System.Windows.Forms.Button();
            this.BtnSub = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblVersion2 = new System.Windows.Forms.Label();
            this.LblR = new System.Windows.Forms.Label();
            this.GpValues.SuspendLayout();
            this.GpOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // GpValues
            // 
            this.GpValues.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GpValues.Controls.Add(this.BtnValidate);
            this.GpValues.Controls.Add(this.Txt2ndValue);
            this.GpValues.Controls.Add(this.Txt1stValue);
            this.GpValues.Controls.Add(this.label2);
            this.GpValues.Controls.Add(this.label1);
            this.GpValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.GpValues.Location = new System.Drawing.Point(13, 55);
            this.GpValues.Name = "GpValues";
            this.GpValues.Size = new System.Drawing.Size(437, 132);
            this.GpValues.TabIndex = 0;
            this.GpValues.TabStop = false;
            this.GpValues.Text = "Values:";
            this.GpValues.Enter += new System.EventHandler(this.GpBox1_Enter);
            // 
            // BtnValidate
            // 
            this.BtnValidate.Location = new System.Drawing.Point(316, 29);
            this.BtnValidate.Name = "BtnValidate";
            this.BtnValidate.Size = new System.Drawing.Size(100, 80);
            this.BtnValidate.TabIndex = 4;
            this.BtnValidate.Text = "Validate Values";
            this.BtnValidate.UseVisualStyleBackColor = true;
            this.BtnValidate.Click += new System.EventHandler(this.BtnValidate_Click);
            // 
            // Txt2ndValue
            // 
            this.Txt2ndValue.Location = new System.Drawing.Point(217, 75);
            this.Txt2ndValue.Name = "Txt2ndValue";
            this.Txt2ndValue.Size = new System.Drawing.Size(62, 30);
            this.Txt2ndValue.TabIndex = 3;
            this.Txt2ndValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt1stValue
            // 
            this.Txt1stValue.Location = new System.Drawing.Point(217, 32);
            this.Txt1stValue.Name = "Txt1stValue";
            this.Txt1stValue.Size = new System.Drawing.Size(62, 30);
            this.Txt1stValue.TabIndex = 2;
            this.Txt1stValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Write the 2nd value:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Write the 1st value:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // GpOperations
            // 
            this.GpOperations.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.GpOperations.Controls.Add(this.LblR);
            this.GpOperations.Controls.Add(this.LblResult);
            this.GpOperations.Controls.Add(this.BtnPower);
            this.GpOperations.Controls.Add(this.BtnDivide);
            this.GpOperations.Controls.Add(this.BtnMulti);
            this.GpOperations.Controls.Add(this.BtnSub);
            this.GpOperations.Controls.Add(this.BtnAdd);
            this.GpOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.GpOperations.Location = new System.Drawing.Point(13, 193);
            this.GpOperations.Name = "GpOperations";
            this.GpOperations.Size = new System.Drawing.Size(436, 160);
            this.GpOperations.TabIndex = 1;
            this.GpOperations.TabStop = false;
            this.GpOperations.Text = "Aritmetic Operations";
            // 
            // LblResult
            // 
            this.LblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblResult.Location = new System.Drawing.Point(199, 102);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(106, 35);
            this.LblResult.TabIndex = 6;
            this.LblResult.Click += new System.EventHandler(this.LblResult_Click);
            // 
            // BtnPower
            // 
            this.BtnPower.Location = new System.Drawing.Point(238, 42);
            this.BtnPower.Name = "BtnPower";
            this.BtnPower.Size = new System.Drawing.Size(177, 40);
            this.BtnPower.TabIndex = 4;
            this.BtnPower.Text = "To the Power";
            this.BtnPower.UseVisualStyleBackColor = true;
            this.BtnPower.Click += new System.EventHandler(this.BtnPower_Click);
            // 
            // BtnDivide
            // 
            this.BtnDivide.Location = new System.Drawing.Point(148, 42);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(40, 40);
            this.BtnDivide.TabIndex = 3;
            this.BtnDivide.Text = "/";
            this.BtnDivide.UseVisualStyleBackColor = true;
            this.BtnDivide.Click += new System.EventHandler(this.BtnDivide_Click);
            // 
            // BtnMulti
            // 
            this.BtnMulti.Location = new System.Drawing.Point(102, 42);
            this.BtnMulti.Name = "BtnMulti";
            this.BtnMulti.Size = new System.Drawing.Size(40, 40);
            this.BtnMulti.TabIndex = 2;
            this.BtnMulti.Text = "*";
            this.BtnMulti.UseVisualStyleBackColor = true;
            this.BtnMulti.Click += new System.EventHandler(this.BtnMulti_Click);
            // 
            // BtnSub
            // 
            this.BtnSub.Location = new System.Drawing.Point(56, 42);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(40, 40);
            this.BtnSub.TabIndex = 1;
            this.BtnSub.Text = "-";
            this.BtnSub.UseVisualStyleBackColor = true;
            this.BtnSub.Click += new System.EventHandler(this.BtnSub_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(10, 42);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(40, 40);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnClean
            // 
            this.BtnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnClean.Location = new System.Drawing.Point(23, 370);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(132, 35);
            this.BtnClean.TabIndex = 7;
            this.BtnClean.Text = "&Clean All";
            this.BtnClean.UseVisualStyleBackColor = true;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // BtnHelp
            // 
            this.BtnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnHelp.Location = new System.Drawing.Point(161, 370);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(132, 35);
            this.BtnHelp.TabIndex = 8;
            this.BtnHelp.Text = "Help";
            this.BtnHelp.UseVisualStyleBackColor = true;
            this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnExit.Location = new System.Drawing.Point(299, 370);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(132, 35);
            this.BtnExit.TabIndex = 9;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblVersion2
            // 
            this.LblVersion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblVersion2.Location = new System.Drawing.Point(387, 22);
            this.LblVersion2.Name = "LblVersion2";
            this.LblVersion2.Size = new System.Drawing.Size(62, 20);
            this.LblVersion2.TabIndex = 10;
            this.LblVersion2.Text = "Show v2";
            this.LblVersion2.Click += new System.EventHandler(this.LblVersion2_Click);
            // 
            // LblR
            // 
            this.LblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.LblR.Location = new System.Drawing.Point(97, 103);
            this.LblR.Name = "LblR";
            this.LblR.Size = new System.Drawing.Size(91, 34);
            this.LblR.TabIndex = 7;
            this.LblR.Text = "Result:";
            // 
            // FrmExe007
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 428);
            this.Controls.Add(this.LblVersion2);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnHelp);
            this.Controls.Add(this.BtnClean);
            this.Controls.Add(this.GpOperations);
            this.Controls.Add(this.GpValues);
            this.Name = "FrmExe007";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aritmetic Operations v1";
            this.Load += new System.EventHandler(this.FrmExe007_Load);
            this.GpValues.ResumeLayout(false);
            this.GpValues.PerformLayout();
            this.GpOperations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GpValues;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnValidate;
        private System.Windows.Forms.TextBox Txt2ndValue;
        private System.Windows.Forms.TextBox Txt1stValue;
        private System.Windows.Forms.GroupBox GpOperations;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Button BtnPower;
        private System.Windows.Forms.Button BtnDivide;
        private System.Windows.Forms.Button BtnMulti;
        private System.Windows.Forms.Button BtnSub;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Button BtnHelp;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblVersion2;
        private System.Windows.Forms.Label LblR;
    }
}

