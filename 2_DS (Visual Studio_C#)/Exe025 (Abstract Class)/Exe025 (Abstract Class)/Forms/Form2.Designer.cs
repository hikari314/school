namespace Exe025__Abstract_Class_.Forms
{
    partial class FrmRegister
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
            this.TandS = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gpT = new System.Windows.Forms.GroupBox();
            this.txtITRt = new System.Windows.Forms.TextBox();
            this.txtNamet = new System.Windows.Forms.TextBox();
            this.txtAddresst = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtDegree = new System.Windows.Forms.TextBox();
            this.btnDeletet = new System.Windows.Forms.Button();
            this.btnAddt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gpS = new System.Windows.Forms.GroupBox();
            this.txtIRTs = new System.Windows.Forms.TextBox();
            this.txtNames = new System.Windows.Forms.TextBox();
            this.txtAdresss = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.btnDeletes = new System.Windows.Forms.Button();
            this.btnAdds = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAddressS = new System.Windows.Forms.Label();
            this.lblNameS = new System.Windows.Forms.Label();
            this.lblITRs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.TandS.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gpT.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gpS.SuspendLayout();
            this.SuspendLayout();
            // 
            // TandS
            // 
            this.TandS.Controls.Add(this.tabPage1);
            this.TandS.Controls.Add(this.tabPage2);
            this.TandS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TandS.Location = new System.Drawing.Point(12, 59);
            this.TandS.Name = "TandS";
            this.TandS.SelectedIndex = 0;
            this.TandS.Size = new System.Drawing.Size(506, 326);
            this.TandS.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.RosyBrown;
            this.tabPage1.Controls.Add(this.gpT);
            this.tabPage1.Controls.Add(this.btnDeletet);
            this.tabPage1.Controls.Add(this.btnAddt);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(498, 297);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Teacher";
            // 
            // gpT
            // 
            this.gpT.Controls.Add(this.txtITRt);
            this.gpT.Controls.Add(this.txtNamet);
            this.gpT.Controls.Add(this.txtAddresst);
            this.gpT.Controls.Add(this.txtCategory);
            this.gpT.Controls.Add(this.txtDegree);
            this.gpT.Location = new System.Drawing.Point(163, 6);
            this.gpT.Name = "gpT";
            this.gpT.Size = new System.Drawing.Size(322, 230);
            this.gpT.TabIndex = 12;
            this.gpT.TabStop = false;
            // 
            // txtITRt
            // 
            this.txtITRt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtITRt.Location = new System.Drawing.Point(15, 25);
            this.txtITRt.Name = "txtITRt";
            this.txtITRt.Size = new System.Drawing.Size(288, 27);
            this.txtITRt.TabIndex = 5;
            this.txtITRt.TextChanged += new System.EventHandler(this.TxtITRt_TextChanged);
            // 
            // txtNamet
            // 
            this.txtNamet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtNamet.Location = new System.Drawing.Point(15, 66);
            this.txtNamet.Name = "txtNamet";
            this.txtNamet.Size = new System.Drawing.Size(288, 27);
            this.txtNamet.TabIndex = 6;
            // 
            // txtAddresst
            // 
            this.txtAddresst.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtAddresst.Location = new System.Drawing.Point(15, 109);
            this.txtAddresst.Name = "txtAddresst";
            this.txtAddresst.Size = new System.Drawing.Size(288, 27);
            this.txtAddresst.TabIndex = 7;
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtCategory.Location = new System.Drawing.Point(15, 194);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(288, 27);
            this.txtCategory.TabIndex = 9;
            // 
            // txtDegree
            // 
            this.txtDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtDegree.Location = new System.Drawing.Point(15, 151);
            this.txtDegree.Name = "txtDegree";
            this.txtDegree.Size = new System.Drawing.Size(288, 27);
            this.txtDegree.TabIndex = 8;
            // 
            // btnDeletet
            // 
            this.btnDeletet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDeletet.Location = new System.Drawing.Point(269, 249);
            this.btnDeletet.Name = "btnDeletet";
            this.btnDeletet.Size = new System.Drawing.Size(79, 32);
            this.btnDeletet.TabIndex = 11;
            this.btnDeletet.Text = "Delete";
            this.btnDeletet.UseVisualStyleBackColor = true;
            this.btnDeletet.Click += new System.EventHandler(this.BtnDeletet_Click);
            // 
            // btnAddt
            // 
            this.btnAddt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddt.Location = new System.Drawing.Point(123, 249);
            this.btnAddt.Name = "btnAddt";
            this.btnAddt.Size = new System.Drawing.Size(77, 32);
            this.btnAddt.TabIndex = 10;
            this.btnAddt.Text = "Add";
            this.btnAddt.UseVisualStyleBackColor = true;
            this.btnAddt.Click += new System.EventHandler(this.BtnAddt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.Location = new System.Drawing.Point(20, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Category:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(20, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Degree Course:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(20, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Address:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(20, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(20, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "ITR:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.IndianRed;
            this.tabPage2.Controls.Add(this.gpS);
            this.tabPage2.Controls.Add(this.btnDeletes);
            this.tabPage2.Controls.Add(this.btnAdds);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.lblAddressS);
            this.tabPage2.Controls.Add(this.lblNameS);
            this.tabPage2.Controls.Add(this.lblITRs);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(498, 297);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Student";
            // 
            // gpS
            // 
            this.gpS.Controls.Add(this.txtIRTs);
            this.gpS.Controls.Add(this.txtNames);
            this.gpS.Controls.Add(this.txtAdresss);
            this.gpS.Controls.Add(this.txtClass);
            this.gpS.Controls.Add(this.txtCourse);
            this.gpS.Location = new System.Drawing.Point(160, 6);
            this.gpS.Name = "gpS";
            this.gpS.Size = new System.Drawing.Size(325, 237);
            this.gpS.TabIndex = 24;
            this.gpS.TabStop = false;
            // 
            // txtIRTs
            // 
            this.txtIRTs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtIRTs.Location = new System.Drawing.Point(16, 21);
            this.txtIRTs.Name = "txtIRTs";
            this.txtIRTs.Size = new System.Drawing.Size(288, 27);
            this.txtIRTs.TabIndex = 15;
            // 
            // txtNames
            // 
            this.txtNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtNames.Location = new System.Drawing.Point(16, 62);
            this.txtNames.Name = "txtNames";
            this.txtNames.Size = new System.Drawing.Size(288, 27);
            this.txtNames.TabIndex = 20;
            // 
            // txtAdresss
            // 
            this.txtAdresss.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtAdresss.Location = new System.Drawing.Point(16, 110);
            this.txtAdresss.Name = "txtAdresss";
            this.txtAdresss.Size = new System.Drawing.Size(288, 27);
            this.txtAdresss.TabIndex = 22;
            // 
            // txtClass
            // 
            this.txtClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtClass.Location = new System.Drawing.Point(16, 203);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(288, 27);
            this.txtClass.TabIndex = 23;
            // 
            // txtCourse
            // 
            this.txtCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtCourse.Location = new System.Drawing.Point(16, 157);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(288, 27);
            this.txtCourse.TabIndex = 21;
            // 
            // btnDeletes
            // 
            this.btnDeletes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDeletes.Location = new System.Drawing.Point(269, 249);
            this.btnDeletes.Name = "btnDeletes";
            this.btnDeletes.Size = new System.Drawing.Size(79, 32);
            this.btnDeletes.TabIndex = 15;
            this.btnDeletes.Text = "Delete";
            this.btnDeletes.UseVisualStyleBackColor = true;
            this.btnDeletes.Click += new System.EventHandler(this.BtnDeletes_Click);
            // 
            // btnAdds
            // 
            this.btnAdds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdds.Location = new System.Drawing.Point(123, 249);
            this.btnAdds.Name = "btnAdds";
            this.btnAdds.Size = new System.Drawing.Size(77, 32);
            this.btnAdds.TabIndex = 15;
            this.btnAdds.Text = "Add";
            this.btnAdds.UseVisualStyleBackColor = true;
            this.btnAdds.Click += new System.EventHandler(this.BtnAdds_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label10.Location = new System.Drawing.Point(24, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 22);
            this.label10.TabIndex = 19;
            this.label10.Text = "Class:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label9.Location = new System.Drawing.Point(22, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Course:";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // lblAddressS
            // 
            this.lblAddressS.AutoSize = true;
            this.lblAddressS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblAddressS.Location = new System.Drawing.Point(22, 121);
            this.lblAddressS.Name = "lblAddressS";
            this.lblAddressS.Size = new System.Drawing.Size(81, 22);
            this.lblAddressS.TabIndex = 17;
            this.lblAddressS.Text = "Address:";
            // 
            // lblNameS
            // 
            this.lblNameS.AutoSize = true;
            this.lblNameS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblNameS.Location = new System.Drawing.Point(22, 73);
            this.lblNameS.Name = "lblNameS";
            this.lblNameS.Size = new System.Drawing.Size(62, 22);
            this.lblNameS.TabIndex = 16;
            this.lblNameS.Text = "Name:";
            // 
            // lblITRs
            // 
            this.lblITRs.AutoSize = true;
            this.lblITRs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblITRs.Location = new System.Drawing.Point(24, 32);
            this.lblITRs.Name = "lblITRs";
            this.lblITRs.Size = new System.Drawing.Size(44, 22);
            this.lblITRs.TabIndex = 15;
            this.lblITRs.Text = "ITR:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tisch School of the Arts - NYU";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label7.Location = new System.Drawing.Point(14, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblStatus.Location = new System.Drawing.Point(86, 404);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(415, 149);
            this.lblStatus.TabIndex = 13;
            // 
            // btnClean
            // 
            this.btnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClean.Location = new System.Drawing.Point(139, 570);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(77, 32);
            this.btnClean.TabIndex = 12;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExit.Location = new System.Drawing.Point(287, 570);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 32);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 614);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TandS);
            this.MaximizeBox = false;
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registering";
            this.TandS.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gpT.ResumeLayout(false);
            this.gpT.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gpS.ResumeLayout(false);
            this.gpS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TandS;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtDegree;
        private System.Windows.Forms.TextBox txtAddresst;
        private System.Windows.Forms.TextBox txtNamet;
        private System.Windows.Forms.TextBox txtITRt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeletet;
        private System.Windows.Forms.Button btnAddt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAddressS;
        private System.Windows.Forms.Label lblNameS;
        private System.Windows.Forms.Label lblITRs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtAdresss;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtNames;
        private System.Windows.Forms.TextBox txtIRTs;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Button btnDeletes;
        private System.Windows.Forms.Button btnAdds;
        private System.Windows.Forms.GroupBox gpT;
        private System.Windows.Forms.GroupBox gpS;
    }
}