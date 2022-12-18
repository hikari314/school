namespace Exe004
{
    partial class FrmExe004
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExe004));
            this.Lbl1 = new System.Windows.Forms.Label();
            this.TxtTuition = new System.Windows.Forms.TextBox();
            this.LblTuition = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.TxtNameStudent = new System.Windows.Forms.TextBox();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.Lbl4 = new System.Windows.Forms.Label();
            this.Lbl5 = new System.Windows.Forms.Label();
            this.Lbl6 = new System.Windows.Forms.Label();
            this.Lbl7 = new System.Windows.Forms.Label();
            this.TxtZipCode = new System.Windows.Forms.TextBox();
            this.TxtCity = new System.Windows.Forms.TextBox();
            this.TxtState = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.Lbl8 = new System.Windows.Forms.Label();
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblDataSent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.BackColor = System.Drawing.Color.Transparent;
            this.Lbl1.Font = new System.Drawing.Font("SimSun", 25F, System.Drawing.FontStyle.Bold);
            this.Lbl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Lbl1.Location = new System.Drawing.Point(177, 21);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(375, 34);
            this.Lbl1.TabIndex = 0;
            this.Lbl1.Text = "Membership Register ";
            this.Lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtTuition
            // 
            this.TxtTuition.BackColor = System.Drawing.SystemColors.Window;
            this.TxtTuition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTuition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TxtTuition.Location = new System.Drawing.Point(48, 137);
            this.TxtTuition.Name = "TxtTuition";
            this.TxtTuition.Size = new System.Drawing.Size(135, 30);
            this.TxtTuition.TabIndex = 1;
            this.TxtTuition.TextChanged += new System.EventHandler(this.TxtTuition_TextChanged);
            // 
            // LblTuition
            // 
            this.LblTuition.AutoSize = true;
            this.LblTuition.BackColor = System.Drawing.Color.Transparent;
            this.LblTuition.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTuition.Location = new System.Drawing.Point(43, 109);
            this.LblTuition.Name = "LblTuition";
            this.LblTuition.Size = new System.Drawing.Size(120, 25);
            this.LblTuition.TabIndex = 0;
            this.LblTuition.Text = "Tuition (RM)";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.BackColor = System.Drawing.Color.Transparent;
            this.Lbl2.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.Location = new System.Drawing.Point(269, 109);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(138, 25);
            this.Lbl2.TabIndex = 0;
            this.Lbl2.Text = "Student Name";
            // 
            // TxtNameStudent
            // 
            this.TxtNameStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNameStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TxtNameStudent.Location = new System.Drawing.Point(274, 137);
            this.TxtNameStudent.Name = "TxtNameStudent";
            this.TxtNameStudent.Size = new System.Drawing.Size(375, 30);
            this.TxtNameStudent.TabIndex = 2;
            this.TxtNameStudent.TextChanged += new System.EventHandler(this.TxtNameStudent_TextChanged);
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.BackColor = System.Drawing.Color.Transparent;
            this.Lbl3.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl3.Location = new System.Drawing.Point(43, 194);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(82, 25);
            this.Lbl3.TabIndex = 0;
            this.Lbl3.Text = "Address";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TxtAddress.Location = new System.Drawing.Point(48, 222);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(360, 30);
            this.TxtAddress.TabIndex = 3;
            // 
            // Lbl4
            // 
            this.Lbl4.AutoSize = true;
            this.Lbl4.BackColor = System.Drawing.Color.Transparent;
            this.Lbl4.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl4.Location = new System.Drawing.Point(448, 194);
            this.Lbl4.Name = "Lbl4";
            this.Lbl4.Size = new System.Drawing.Size(91, 25);
            this.Lbl4.TabIndex = 0;
            this.Lbl4.Text = "Zip Code";
            // 
            // Lbl5
            // 
            this.Lbl5.AutoSize = true;
            this.Lbl5.BackColor = System.Drawing.Color.Transparent;
            this.Lbl5.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl5.Location = new System.Drawing.Point(43, 280);
            this.Lbl5.Name = "Lbl5";
            this.Lbl5.Size = new System.Drawing.Size(46, 25);
            this.Lbl5.TabIndex = 0;
            this.Lbl5.Text = "City";
            this.Lbl5.Click += new System.EventHandler(this.Lbl5_Click);
            // 
            // Lbl6
            // 
            this.Lbl6.AutoSize = true;
            this.Lbl6.BackColor = System.Drawing.Color.Transparent;
            this.Lbl6.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl6.Location = new System.Drawing.Point(448, 280);
            this.Lbl6.Name = "Lbl6";
            this.Lbl6.Size = new System.Drawing.Size(57, 25);
            this.Lbl6.TabIndex = 0;
            this.Lbl6.Text = "State";
            // 
            // Lbl7
            // 
            this.Lbl7.AutoSize = true;
            this.Lbl7.BackColor = System.Drawing.Color.Transparent;
            this.Lbl7.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl7.Location = new System.Drawing.Point(43, 360);
            this.Lbl7.Name = "Lbl7";
            this.Lbl7.Size = new System.Drawing.Size(59, 25);
            this.Lbl7.TabIndex = 0;
            this.Lbl7.Text = "Email";
            // 
            // TxtZipCode
            // 
            this.TxtZipCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TxtZipCode.Location = new System.Drawing.Point(453, 222);
            this.TxtZipCode.Name = "TxtZipCode";
            this.TxtZipCode.Size = new System.Drawing.Size(195, 30);
            this.TxtZipCode.TabIndex = 4;
            // 
            // TxtCity
            // 
            this.TxtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TxtCity.Location = new System.Drawing.Point(48, 308);
            this.TxtCity.Name = "TxtCity";
            this.TxtCity.Size = new System.Drawing.Size(360, 30);
            this.TxtCity.TabIndex = 5;
            // 
            // TxtState
            // 
            this.TxtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtState.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TxtState.Location = new System.Drawing.Point(453, 308);
            this.TxtState.Name = "TxtState";
            this.TxtState.Size = new System.Drawing.Size(195, 30);
            this.TxtState.TabIndex = 6;
            // 
            // TxtEmail
            // 
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TxtEmail.Location = new System.Drawing.Point(48, 388);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(360, 30);
            this.TxtEmail.TabIndex = 7;
            // 
            // BtnSend
            // 
            this.BtnSend.BackColor = System.Drawing.Color.Transparent;
            this.BtnSend.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSend.Location = new System.Drawing.Point(466, 381);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(100, 46);
            this.BtnSend.TabIndex = 8;
            this.BtnSend.Text = "Send >";
            this.BtnSend.UseVisualStyleBackColor = false;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // Lbl8
            // 
            this.Lbl8.AutoSize = true;
            this.Lbl8.BackColor = System.Drawing.Color.Transparent;
            this.Lbl8.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl8.Location = new System.Drawing.Point(43, 461);
            this.Lbl8.Name = "Lbl8";
            this.Lbl8.Size = new System.Drawing.Size(101, 25);
            this.Lbl8.TabIndex = 0;
            this.Lbl8.Text = "Data Sent:";
            this.Lbl8.Click += new System.EventHandler(this.Lbl8_Click);
            // 
            // BtnClean
            // 
            this.BtnClean.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClean.Location = new System.Drawing.Point(467, 487);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(101, 46);
            this.BtnClean.TabIndex = 10;
            this.BtnClean.Text = "Clean All";
            this.BtnClean.UseVisualStyleBackColor = true;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(466, 588);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(101, 49);
            this.BtnExit.TabIndex = 11;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblDataSent
            // 
            this.LblDataSent.AutoSize = true;
            this.LblDataSent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblDataSent.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataSent.Location = new System.Drawing.Point(48, 487);
            this.LblDataSent.Name = "LblDataSent";
            this.LblDataSent.Size = new System.Drawing.Size(2, 27);
            this.LblDataSent.TabIndex = 12;
            // 
            // FrmExe004
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(699, 671);
            this.Controls.Add(this.LblDataSent);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClean);
            this.Controls.Add(this.Lbl8);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtState);
            this.Controls.Add(this.TxtCity);
            this.Controls.Add(this.TxtZipCode);
            this.Controls.Add(this.Lbl7);
            this.Controls.Add(this.Lbl6);
            this.Controls.Add(this.Lbl5);
            this.Controls.Add(this.Lbl4);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.TxtNameStudent);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.LblTuition);
            this.Controls.Add(this.TxtTuition);
            this.Controls.Add(this.Lbl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MaximizeBox = false;
            this.Name = "FrmExe004";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sun and Beach College (Student Guild)";
            this.Load += new System.EventHandler(this.FrmExe004_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.TextBox TxtTuition;
        private System.Windows.Forms.Label LblTuition;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.TextBox TxtNameStudent;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label Lbl4;
        private System.Windows.Forms.Label Lbl5;
        private System.Windows.Forms.Label Lbl6;
        private System.Windows.Forms.Label Lbl7;
        private System.Windows.Forms.TextBox TxtZipCode;
        private System.Windows.Forms.TextBox TxtCity;
        private System.Windows.Forms.TextBox TxtState;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Label Lbl8;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblDataSent;
    }
}

