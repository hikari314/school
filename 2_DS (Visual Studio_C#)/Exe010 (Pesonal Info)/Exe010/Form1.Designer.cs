namespace Exe010
{
    partial class FrmExe010
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
            this.components = new System.ComponentModel.Container();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblDay = new System.Windows.Forms.Label();
            this.LblHour = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DtpBirth = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ComBSchooling = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RbM = new System.Windows.Forms.RadioButton();
            this.RbF = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ChkSing = new System.Windows.Forms.CheckBox();
            this.ChkSwin = new System.Windows.Forms.CheckBox();
            this.ChkDance = new System.Windows.Forms.CheckBox();
            this.ChkTravel = new System.Windows.Forms.CheckBox();
            this.ChkWalk = new System.Windows.Forms.CheckBox();
            this.ChkRead = new System.Windows.Forms.CheckBox();
            this.LstAnswer = new System.Windows.Forms.ListBox();
            this.BtnList = new System.Windows.Forms.Button();
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblDate
            // 
            this.LblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblDate.Location = new System.Drawing.Point(12, 13);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(111, 23);
            this.LblDate.TabIndex = 0;
            this.LblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblDay
            // 
            this.LblDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblDay.Location = new System.Drawing.Point(158, 13);
            this.LblDay.Name = "LblDay";
            this.LblDay.Size = new System.Drawing.Size(190, 23);
            this.LblDay.TabIndex = 1;
            this.LblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblHour
            // 
            this.LblHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblHour.Location = new System.Drawing.Point(379, 13);
            this.LblHour.Name = "LblHour";
            this.LblHour.Size = new System.Drawing.Size(109, 23);
            this.LblHour.TabIndex = 2;
            this.LblHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblHour.Click += new System.EventHandler(this.LblHour_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(153, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Personal Information";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox1.Location = new System.Drawing.Point(13, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 64);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(6, 24);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(462, 30);
            this.TxtName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DtpBirth);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox2.Location = new System.Drawing.Point(12, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 72);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Birth Date:";
            // 
            // DtpBirth
            // 
            this.DtpBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpBirth.Location = new System.Drawing.Point(7, 30);
            this.DtpBirth.Name = "DtpBirth";
            this.DtpBirth.Size = new System.Drawing.Size(140, 30);
            this.DtpBirth.TabIndex = 1;
            this.DtpBirth.Value = new System.DateTime(2022, 5, 4, 15, 41, 7, 0);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ComBSchooling);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox3.Location = new System.Drawing.Point(192, 171);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 72);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Level of Schooling";
            // 
            // ComBSchooling
            // 
            this.ComBSchooling.DisplayMember = "ll";
            this.ComBSchooling.FormattingEnabled = true;
            this.ComBSchooling.Location = new System.Drawing.Point(6, 27);
            this.ComBSchooling.Name = "ComBSchooling";
            this.ComBSchooling.Size = new System.Drawing.Size(289, 33);
            this.ComBSchooling.TabIndex = 2;
            this.ComBSchooling.Text = "Select...";
            this.ComBSchooling.ValueMember = "ll";
            this.ComBSchooling.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComBSchooling_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RbM);
            this.groupBox4.Controls.Add(this.RbF);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox4.Location = new System.Drawing.Point(13, 253);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(174, 85);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Birth Gender:";
            // 
            // RbM
            // 
            this.RbM.AutoSize = true;
            this.RbM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RbM.Location = new System.Drawing.Point(7, 57);
            this.RbM.Name = "RbM";
            this.RbM.Size = new System.Drawing.Size(89, 21);
            this.RbM.TabIndex = 0;
            this.RbM.Text = "Masculine";
            this.RbM.UseVisualStyleBackColor = true;
            // 
            // RbF
            // 
            this.RbF.AutoSize = true;
            this.RbF.Checked = true;
            this.RbF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RbF.Location = new System.Drawing.Point(7, 30);
            this.RbF.Name = "RbF";
            this.RbF.Size = new System.Drawing.Size(83, 21);
            this.RbF.TabIndex = 0;
            this.RbF.TabStop = true;
            this.RbF.Text = "Feminine";
            this.RbF.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ChkSing);
            this.groupBox5.Controls.Add(this.ChkSwin);
            this.groupBox5.Controls.Add(this.ChkDance);
            this.groupBox5.Controls.Add(this.ChkTravel);
            this.groupBox5.Controls.Add(this.ChkWalk);
            this.groupBox5.Controls.Add(this.ChkRead);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox5.Location = new System.Drawing.Point(193, 253);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(288, 85);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Preferences:";
            // 
            // ChkSing
            // 
            this.ChkSing.AutoSize = true;
            this.ChkSing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ChkSing.Location = new System.Drawing.Point(174, 57);
            this.ChkSing.Name = "ChkSing";
            this.ChkSing.Size = new System.Drawing.Size(47, 17);
            this.ChkSing.TabIndex = 5;
            this.ChkSing.Text = "Sing";
            this.ChkSing.UseVisualStyleBackColor = true;
            // 
            // ChkSwin
            // 
            this.ChkSwin.AutoSize = true;
            this.ChkSwin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ChkSwin.Location = new System.Drawing.Point(174, 29);
            this.ChkSwin.Name = "ChkSwin";
            this.ChkSwin.Size = new System.Drawing.Size(51, 17);
            this.ChkSwin.TabIndex = 4;
            this.ChkSwin.Text = "Swim";
            this.ChkSwin.UseVisualStyleBackColor = true;
            // 
            // ChkDance
            // 
            this.ChkDance.AutoSize = true;
            this.ChkDance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ChkDance.Location = new System.Drawing.Point(90, 57);
            this.ChkDance.Name = "ChkDance";
            this.ChkDance.Size = new System.Drawing.Size(58, 17);
            this.ChkDance.TabIndex = 3;
            this.ChkDance.Text = "Dance";
            this.ChkDance.UseVisualStyleBackColor = true;
            this.ChkDance.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);
            // 
            // ChkTravel
            // 
            this.ChkTravel.AutoSize = true;
            this.ChkTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ChkTravel.Location = new System.Drawing.Point(92, 29);
            this.ChkTravel.Name = "ChkTravel";
            this.ChkTravel.Size = new System.Drawing.Size(56, 17);
            this.ChkTravel.TabIndex = 2;
            this.ChkTravel.Text = "Travel";
            this.ChkTravel.UseVisualStyleBackColor = true;
            // 
            // ChkWalk
            // 
            this.ChkWalk.AutoSize = true;
            this.ChkWalk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ChkWalk.Location = new System.Drawing.Point(7, 57);
            this.ChkWalk.Name = "ChkWalk";
            this.ChkWalk.Size = new System.Drawing.Size(51, 17);
            this.ChkWalk.TabIndex = 1;
            this.ChkWalk.Text = "Walk";
            this.ChkWalk.UseVisualStyleBackColor = true;
            // 
            // ChkRead
            // 
            this.ChkRead.AutoSize = true;
            this.ChkRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.ChkRead.Location = new System.Drawing.Point(7, 30);
            this.ChkRead.Name = "ChkRead";
            this.ChkRead.Size = new System.Drawing.Size(52, 17);
            this.ChkRead.TabIndex = 0;
            this.ChkRead.Text = "Read";
            this.ChkRead.UseVisualStyleBackColor = true;
            // 
            // LstAnswer
            // 
            this.LstAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LstAnswer.FormattingEnabled = true;
            this.LstAnswer.ItemHeight = 25;
            this.LstAnswer.Location = new System.Drawing.Point(12, 351);
            this.LstAnswer.Name = "LstAnswer";
            this.LstAnswer.Size = new System.Drawing.Size(356, 179);
            this.LstAnswer.TabIndex = 8;
            // 
            // BtnList
            // 
            this.BtnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnList.Location = new System.Drawing.Point(374, 383);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(107, 36);
            this.BtnList.TabIndex = 9;
            this.BtnList.Text = "<<List";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BtnClean
            // 
            this.BtnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnClean.Location = new System.Drawing.Point(374, 425);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(107, 36);
            this.BtnClean.TabIndex = 10;
            this.BtnClean.Text = "Clean All";
            this.BtnClean.UseVisualStyleBackColor = true;
            this.BtnClean.Click += new System.EventHandler(this.Button2_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnExit.Location = new System.Drawing.Point(374, 467);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(107, 36);
            this.BtnExit.TabIndex = 11;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.Button3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick_1);
            // 
            // FrmExe010
            // 
            this.AcceptButton = this.BtnList;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnExit;
            this.ClientSize = new System.Drawing.Size(494, 540);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClean);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.LstAnswer);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblHour);
            this.Controls.Add(this.LblDay);
            this.Controls.Add(this.LblDate);
            this.Name = "FrmExe010";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Several Controls";
            this.Load += new System.EventHandler(this.FrmExe010_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblDay;
        private System.Windows.Forms.Label LblHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker DtpBirth;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox ComBSchooling;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton RbM;
        private System.Windows.Forms.RadioButton RbF;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox ChkSing;
        private System.Windows.Forms.CheckBox ChkSwin;
        private System.Windows.Forms.CheckBox ChkDance;
        private System.Windows.Forms.CheckBox ChkTravel;
        private System.Windows.Forms.CheckBox ChkWalk;
        private System.Windows.Forms.CheckBox ChkRead;
        private System.Windows.Forms.ListBox LstAnswer;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

