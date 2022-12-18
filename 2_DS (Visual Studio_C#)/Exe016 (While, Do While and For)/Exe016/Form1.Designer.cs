
namespace Exe016
{
    partial class FrmExe016
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
            this.label2 = new System.Windows.Forms.Label();
            this.BtnWhile = new System.Windows.Forms.Button();
            this.BtnFor = new System.Windows.Forms.Button();
            this.BtnDoWhile = new System.Windows.Forms.Button();
            this.LstYears = new System.Windows.Forms.ListBox();
            this.BtnFinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Repetition Structures: While, Do While and For";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Display in the ListBox the years from 1900 to today";
            // 
            // BtnWhile
            // 
            this.BtnWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnWhile.Location = new System.Drawing.Point(12, 81);
            this.BtnWhile.Name = "BtnWhile";
            this.BtnWhile.Size = new System.Drawing.Size(75, 31);
            this.BtnWhile.TabIndex = 2;
            this.BtnWhile.Text = "While";
            this.BtnWhile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnWhile.UseVisualStyleBackColor = true;
            this.BtnWhile.Click += new System.EventHandler(this.BtnWhile_Click);
            // 
            // BtnFor
            // 
            this.BtnFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnFor.Location = new System.Drawing.Point(346, 81);
            this.BtnFor.Name = "BtnFor";
            this.BtnFor.Size = new System.Drawing.Size(75, 31);
            this.BtnFor.TabIndex = 3;
            this.BtnFor.Text = "For";
            this.BtnFor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnFor.UseVisualStyleBackColor = true;
            this.BtnFor.Click += new System.EventHandler(this.BtnFor_Click);
            // 
            // BtnDoWhile
            // 
            this.BtnDoWhile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnDoWhile.Location = new System.Drawing.Point(156, 81);
            this.BtnDoWhile.Name = "BtnDoWhile";
            this.BtnDoWhile.Size = new System.Drawing.Size(112, 31);
            this.BtnDoWhile.TabIndex = 4;
            this.BtnDoWhile.Text = "Do...While";
            this.BtnDoWhile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnDoWhile.UseVisualStyleBackColor = true;
            this.BtnDoWhile.Click += new System.EventHandler(this.BtnDoWhile_Click);
            // 
            // LstYears
            // 
            this.LstYears.FormattingEnabled = true;
            this.LstYears.Location = new System.Drawing.Point(139, 131);
            this.LstYears.Name = "LstYears";
            this.LstYears.Size = new System.Drawing.Size(145, 147);
            this.LstYears.TabIndex = 5;
            // 
            // BtnFinish
            // 
            this.BtnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnFinish.Location = new System.Drawing.Point(173, 294);
            this.BtnFinish.Name = "BtnFinish";
            this.BtnFinish.Size = new System.Drawing.Size(75, 31);
            this.BtnFinish.TabIndex = 6;
            this.BtnFinish.Text = "Finish";
            this.BtnFinish.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnFinish.UseVisualStyleBackColor = true;
            this.BtnFinish.Click += new System.EventHandler(this.BtnFinish_Click);
            // 
            // FrmExe016
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 338);
            this.Controls.Add(this.BtnFinish);
            this.Controls.Add(this.LstYears);
            this.Controls.Add(this.BtnDoWhile);
            this.Controls.Add(this.BtnFor);
            this.Controls.Add(this.BtnWhile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmExe016";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repetition Structures";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnWhile;
        private System.Windows.Forms.Button BtnFor;
        private System.Windows.Forms.Button BtnDoWhile;
        private System.Windows.Forms.ListBox LstYears;
        private System.Windows.Forms.Button BtnFinish;
    }
}

