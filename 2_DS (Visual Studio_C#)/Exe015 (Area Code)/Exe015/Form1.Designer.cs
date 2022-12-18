
namespace Exe015
{
    partial class FrmExe015
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblDDD = new System.Windows.Forms.Label();
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.CboDDD = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(190, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area Codes in Brazil";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CboDDD);
            this.groupBox1.Controls.Add(this.BtnSearch);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 80);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select the city";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(282, 29);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(193, 29);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "Search Area Code";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LblDDD);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox2.Location = new System.Drawing.Point(13, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(259, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Area Code =";
            // 
            // LblDDD
            // 
            this.LblDDD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblDDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.LblDDD.Location = new System.Drawing.Point(136, 45);
            this.LblDDD.Name = "LblDDD";
            this.LblDDD.Size = new System.Drawing.Size(55, 34);
            this.LblDDD.TabIndex = 4;
            // 
            // BtnClean
            // 
            this.BtnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnClean.Location = new System.Drawing.Point(294, 160);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(193, 30);
            this.BtnClean.TabIndex = 2;
            this.BtnClean.Text = "Clean All";
            this.BtnClean.UseVisualStyleBackColor = true;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnExit.Location = new System.Drawing.Point(294, 196);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(193, 30);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // CboDDD
            // 
            this.CboDDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.CboDDD.FormattingEnabled = true;
            this.CboDDD.Location = new System.Drawing.Point(12, 29);
            this.CboDDD.Name = "CboDDD";
            this.CboDDD.Size = new System.Drawing.Size(216, 28);
            this.CboDDD.Sorted = true;
            this.CboDDD.TabIndex = 2;
            // 
            // FrmExe015
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 258);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClean);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmExe015";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area Codes from BR";
            this.Load += new System.EventHandler(this.FrmExe015_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CboDDD;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblDDD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Button BtnExit;
    }
}

