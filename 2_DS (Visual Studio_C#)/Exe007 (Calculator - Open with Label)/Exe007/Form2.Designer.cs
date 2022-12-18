namespace Exe007
{
    partial class FrmExe0080427
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnClean = new System.Windows.Forms.Button();
            this.GpOperations = new System.Windows.Forms.GroupBox();
            this.LblResult = new System.Windows.Forms.Label();
            this.BtnPower = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.BtnMulti = new System.Windows.Forms.Button();
            this.BtnSub = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.GpValues = new System.Windows.Forms.GroupBox();
            this.BtnValidate = new System.Windows.Forms.Button();
            this.Txt2ndValue = new System.Windows.Forms.TextBox();
            this.Txt1stValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblWeekDay = new System.Windows.Forms.Label();
            this.LblHour = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblR = new System.Windows.Forms.Label();
            this.GpOperations.SuspendLayout();
            this.GpValues.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnExit.Location = new System.Drawing.Point(680, 164);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 35);
            this.BtnExit.TabIndex = 15;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnClean
            // 
            this.BtnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnClean.Location = new System.Drawing.Point(680, 97);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(75, 61);
            this.BtnClean.TabIndex = 13;
            this.BtnClean.Text = "&Clean All";
            this.BtnClean.UseVisualStyleBackColor = true;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
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
            this.GpOperations.Location = new System.Drawing.Point(323, 79);
            this.GpOperations.Name = "GpOperations";
            this.GpOperations.Size = new System.Drawing.Size(351, 129);
            this.GpOperations.TabIndex = 12;
            this.GpOperations.TabStop = false;
            this.GpOperations.Text = "Aritmetic Operations";
            // 
            // LblResult
            // 
            this.LblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblResult.Location = new System.Drawing.Point(148, 80);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(106, 35);
            this.LblResult.TabIndex = 6;
            // 
            // BtnPower
            // 
            this.BtnPower.Location = new System.Drawing.Point(194, 35);
            this.BtnPower.Name = "BtnPower";
            this.BtnPower.Size = new System.Drawing.Size(140, 40);
            this.BtnPower.TabIndex = 4;
            this.BtnPower.Text = "To the Power";
            this.BtnPower.UseVisualStyleBackColor = true;
            this.BtnPower.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDivide
            // 
            this.BtnDivide.Location = new System.Drawing.Point(148, 35);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(40, 40);
            this.BtnDivide.TabIndex = 3;
            this.BtnDivide.Text = "/";
            this.BtnDivide.UseVisualStyleBackColor = true;
            this.BtnDivide.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnMulti
            // 
            this.BtnMulti.Location = new System.Drawing.Point(102, 35);
            this.BtnMulti.Name = "BtnMulti";
            this.BtnMulti.Size = new System.Drawing.Size(40, 40);
            this.BtnMulti.TabIndex = 2;
            this.BtnMulti.Text = "*";
            this.BtnMulti.UseVisualStyleBackColor = true;
            this.BtnMulti.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnSub
            // 
            this.BtnSub.Location = new System.Drawing.Point(56, 35);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(40, 40);
            this.BtnSub.TabIndex = 1;
            this.BtnSub.Text = "-";
            this.BtnSub.UseVisualStyleBackColor = true;
            this.BtnSub.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(10, 35);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(40, 40);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
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
            this.GpValues.Location = new System.Drawing.Point(12, 79);
            this.GpValues.Name = "GpValues";
            this.GpValues.Size = new System.Drawing.Size(305, 129);
            this.GpValues.TabIndex = 11;
            this.GpValues.TabStop = false;
            this.GpValues.Text = "Values:";
            // 
            // BtnValidate
            // 
            this.BtnValidate.Location = new System.Drawing.Point(316, 29);
            this.BtnValidate.Name = "BtnValidate";
            this.BtnValidate.Size = new System.Drawing.Size(0, 0);
            this.BtnValidate.TabIndex = 4;
            this.BtnValidate.Text = "Validate Values";
            this.BtnValidate.UseVisualStyleBackColor = true;
            // 
            // Txt2ndValue
            // 
            this.Txt2ndValue.Location = new System.Drawing.Point(217, 82);
            this.Txt2ndValue.Name = "Txt2ndValue";
            this.Txt2ndValue.Size = new System.Drawing.Size(62, 30);
            this.Txt2ndValue.TabIndex = 3;
            this.Txt2ndValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt2ndValue.TextChanged += new System.EventHandler(this.Txt2ndValue_TextChanged);
            // 
            // Txt1stValue
            // 
            this.Txt1stValue.Location = new System.Drawing.Point(217, 40);
            this.Txt1stValue.Name = "Txt1stValue";
            this.Txt1stValue.Size = new System.Drawing.Size(62, 30);
            this.Txt1stValue.TabIndex = 2;
            this.Txt1stValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Write the 2nd value:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Write the 1st value:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // LblDate
            // 
            this.LblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblDate.Location = new System.Drawing.Point(151, 23);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(131, 39);
            this.LblDate.TabIndex = 16;
            this.LblDate.Click += new System.EventHandler(this.LblDate_Click);
            // 
            // LblWeekDay
            // 
            this.LblWeekDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblWeekDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblWeekDay.Location = new System.Drawing.Point(288, 23);
            this.LblWeekDay.Name = "LblWeekDay";
            this.LblWeekDay.Size = new System.Drawing.Size(223, 39);
            this.LblWeekDay.TabIndex = 17;
            // 
            // LblHour
            // 
            this.LblHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblHour.Location = new System.Drawing.Point(517, 23);
            this.LblHour.Name = "LblHour";
            this.LblHour.Size = new System.Drawing.Size(124, 39);
            this.LblHour.TabIndex = 18;
            this.LblHour.Click += new System.EventHandler(this.LblHour_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // LblR
            // 
            this.LblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.LblR.Location = new System.Drawing.Point(51, 82);
            this.LblR.Name = "LblR";
            this.LblR.Size = new System.Drawing.Size(91, 34);
            this.LblR.TabIndex = 8;
            this.LblR.Text = "Result:";
            // 
            // FrmExe0080427
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 226);
            this.Controls.Add(this.LblHour);
            this.Controls.Add(this.LblWeekDay);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClean);
            this.Controls.Add(this.GpOperations);
            this.Controls.Add(this.GpValues);
            this.Name = "FrmExe0080427";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exe008 - Aritmetic Operation";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.GpOperations.ResumeLayout(false);
            this.GpValues.ResumeLayout(false);
            this.GpValues.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.GroupBox GpOperations;
        private System.Windows.Forms.Label LblResult;
        private System.Windows.Forms.Button BtnPower;
        private System.Windows.Forms.Button BtnDivide;
        private System.Windows.Forms.Button BtnMulti;
        private System.Windows.Forms.Button BtnSub;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.GroupBox GpValues;
        private System.Windows.Forms.Button BtnValidate;
        private System.Windows.Forms.TextBox Txt2ndValue;
        private System.Windows.Forms.TextBox Txt1stValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblWeekDay;
        private System.Windows.Forms.Label LblHour;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblR;
    }
}