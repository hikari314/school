namespace Exe006
{
    partial class FrmExe006
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblTime = new System.Windows.Forms.Label();
            this.LblDay = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtAge1 = new System.Windows.Forms.TextBox();
            this.TxtName1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtAge2 = new System.Windows.Forms.TextBox();
            this.TxtName2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnYoungPerson = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LblAgeYoung = new System.Windows.Forms.Label();
            this.LblNameYoung = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Thistle;
            this.groupBox1.Controls.Add(this.LblTime);
            this.groupBox1.Controls.Add(this.LblDay);
            this.groupBox1.Controls.Add(this.LblDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // LblTime
            // 
            this.LblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblTime.Location = new System.Drawing.Point(333, 16);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(99, 22);
            this.LblTime.TabIndex = 3;
            this.LblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblDay
            // 
            this.LblDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblDay.Location = new System.Drawing.Point(112, 16);
            this.LblDay.Name = "LblDay";
            this.LblDay.Size = new System.Drawing.Size(215, 22);
            this.LblDay.TabIndex = 2;
            this.LblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblDay.Click += new System.EventHandler(this.LblDay_Click);
            // 
            // LblDate
            // 
            this.LblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.LblDate.Location = new System.Drawing.Point(6, 16);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(100, 22);
            this.LblDate.TabIndex = 0;
            this.LblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblDate.UseMnemonic = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Thistle;
            this.groupBox2.Controls.Add(this.TxtAge1);
            this.groupBox2.Controls.Add(this.TxtName1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(13, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 95);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "First Student:";
            // 
            // TxtAge1
            // 
            this.TxtAge1.Location = new System.Drawing.Point(54, 61);
            this.TxtAge1.Name = "TxtAge1";
            this.TxtAge1.Size = new System.Drawing.Size(37, 23);
            this.TxtAge1.TabIndex = 2;
            this.TxtAge1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAge1_KeyPress);
            // 
            // TxtName1
            // 
            this.TxtName1.Location = new System.Drawing.Point(57, 29);
            this.TxtName1.Name = "TxtName1";
            this.TxtName1.Size = new System.Drawing.Size(353, 23);
            this.TxtName1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Thistle;
            this.groupBox3.Controls.Add(this.TxtAge2);
            this.groupBox3.Controls.Add(this.TxtName2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox3.Location = new System.Drawing.Point(13, 170);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(431, 95);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Second Student:";
            // 
            // TxtAge2
            // 
            this.TxtAge2.Location = new System.Drawing.Point(57, 61);
            this.TxtAge2.Name = "TxtAge2";
            this.TxtAge2.Size = new System.Drawing.Size(34, 23);
            this.TxtAge2.TabIndex = 4;
            this.TxtAge2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAge2_KeyPress);
            // 
            // TxtName2
            // 
            this.TxtName2.Location = new System.Drawing.Point(54, 29);
            this.TxtName2.Name = "TxtName2";
            this.TxtName2.Size = new System.Drawing.Size(353, 23);
            this.TxtName2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Age:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name:";
            // 
            // BtnYoungPerson
            // 
            this.BtnYoungPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnYoungPerson.Location = new System.Drawing.Point(124, 271);
            this.BtnYoungPerson.Name = "BtnYoungPerson";
            this.BtnYoungPerson.Size = new System.Drawing.Size(172, 33);
            this.BtnYoungPerson.TabIndex = 5;
            this.BtnYoungPerson.Text = "Show youngest student";
            this.BtnYoungPerson.UseVisualStyleBackColor = true;
            this.BtnYoungPerson.Click += new System.EventHandler(this.BtnYoungPerson_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Thistle;
            this.groupBox4.Controls.Add(this.LblAgeYoung);
            this.groupBox4.Controls.Add(this.LblNameYoung);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox4.Location = new System.Drawing.Point(13, 310);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(431, 95);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Result: Youngest Student";
            // 
            // LblAgeYoung
            // 
            this.LblAgeYoung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblAgeYoung.Location = new System.Drawing.Point(54, 63);
            this.LblAgeYoung.Name = "LblAgeYoung";
            this.LblAgeYoung.Size = new System.Drawing.Size(37, 21);
            this.LblAgeYoung.TabIndex = 3;
            // 
            // LblNameYoung
            // 
            this.LblNameYoung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblNameYoung.Location = new System.Drawing.Point(54, 29);
            this.LblNameYoung.Name = "LblNameYoung";
            this.LblNameYoung.Size = new System.Drawing.Size(356, 21);
            this.LblNameYoung.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Age:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name:";
            // 
            // BtnClean
            // 
            this.BtnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnClean.Location = new System.Drawing.Point(87, 437);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(82, 33);
            this.BtnClean.TabIndex = 6;
            this.BtnClean.Text = "&Clean All";
            this.BtnClean.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnExit.Location = new System.Drawing.Point(237, 437);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(82, 33);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "&Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FrmExe006
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 481);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClean);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.BtnYoungPerson);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmExe006";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exe006_Var";
            this.Load += new System.EventHandler(this.FrmExe006_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label LblDay;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtAge1;
        private System.Windows.Forms.TextBox TxtName1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtAge2;
        private System.Windows.Forms.TextBox TxtName2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnYoungPerson;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label LblAgeYoung;
        private System.Windows.Forms.Label LblNameYoung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Timer timer1;
    }
}

