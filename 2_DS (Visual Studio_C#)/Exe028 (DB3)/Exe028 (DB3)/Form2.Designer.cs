namespace Exe028__DB3_
{
    partial class Form2
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
            this.gpRegister = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.purveyorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet = new Exe028__DB3_.DataBaseDataSet();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpAction = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gpBrowser = new System.Windows.Forms.GroupBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.purveyorTableAdapter = new Exe028__DB3_.DataBaseDataSetTableAdapters.PurveyorTableAdapter();
            this.gpRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purveyorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            this.gpAction.SuspendLayout();
            this.gpBrowser.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpRegister
            // 
            this.gpRegister.Controls.Add(this.txtName);
            this.gpRegister.Controls.Add(this.txtCode);
            this.gpRegister.Controls.Add(this.label3);
            this.gpRegister.Controls.Add(this.label2);
            this.gpRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.gpRegister.Location = new System.Drawing.Point(12, 57);
            this.gpRegister.Name = "gpRegister";
            this.gpRegister.Size = new System.Drawing.Size(403, 125);
            this.gpRegister.TabIndex = 0;
            this.gpRegister.TabStop = false;
            this.gpRegister.Text = "Registration Data";
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purveyorBindingSource, "CorporateName", true));
            this.txtName.Location = new System.Drawing.Point(147, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(234, 27);
            this.txtName.TabIndex = 3;
            // 
            // purveyorBindingSource
            // 
            this.purveyorBindingSource.DataMember = "Purveyor";
            this.purveyorBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // dataBaseDataSet
            // 
            this.dataBaseDataSet.DataSetName = "DataBaseDataSet";
            this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtCode
            // 
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.purveyorBindingSource, "CodPur", true));
            this.txtCode.Location = new System.Drawing.Point(147, 39);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(234, 27);
            this.txtCode.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Purveyor Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Purveyor Code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(154, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Purveyor Register ";
            // 
            // gpAction
            // 
            this.gpAction.Controls.Add(this.button1);
            this.gpAction.Controls.Add(this.button5);
            this.gpAction.Controls.Add(this.button4);
            this.gpAction.Controls.Add(this.button3);
            this.gpAction.Controls.Add(this.button2);
            this.gpAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.gpAction.Location = new System.Drawing.Point(433, 26);
            this.gpAction.Name = "gpAction";
            this.gpAction.Size = new System.Drawing.Size(120, 225);
            this.gpAction.TabIndex = 3;
            this.gpAction.TabStop = false;
            this.gpAction.Text = "Actions";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(6, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "&List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button5.Location = new System.Drawing.Point(6, 145);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 32);
            this.button5.TabIndex = 7;
            this.button5.Text = "&Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.Location = new System.Drawing.Point(6, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 32);
            this.button4.TabIndex = 6;
            this.button4.Text = "&Edit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(6, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 32);
            this.button3.TabIndex = 5;
            this.button3.Text = "&Register";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(6, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 32);
            this.button2.TabIndex = 4;
            this.button2.Text = "&New";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // gpBrowser
            // 
            this.gpBrowser.Controls.Add(this.btnPrevious);
            this.gpBrowser.Controls.Add(this.btnFirst);
            this.gpBrowser.Controls.Add(this.btnNext);
            this.gpBrowser.Controls.Add(this.btnLast);
            this.gpBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gpBrowser.Location = new System.Drawing.Point(12, 197);
            this.gpBrowser.Name = "gpBrowser";
            this.gpBrowser.Size = new System.Drawing.Size(403, 70);
            this.gpBrowser.TabIndex = 4;
            this.gpBrowser.TabStop = false;
            this.gpBrowser.Text = "Browsing";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPrevious.Location = new System.Drawing.Point(148, 21);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(46, 39);
            this.btnPrevious.TabIndex = 8;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFirst.Location = new System.Drawing.Point(22, 21);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(46, 39);
            this.btnFirst.TabIndex = 5;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNext.Location = new System.Drawing.Point(225, 21);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(46, 39);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLast.Location = new System.Drawing.Point(341, 21);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(46, 39);
            this.btnLast.TabIndex = 6;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button6.Location = new System.Drawing.Point(439, 257);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(104, 32);
            this.button6.TabIndex = 8;
            this.button6.Text = "Close";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // purveyorTableAdapter
            // 
            this.purveyorTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 319);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.gpBrowser);
            this.Controls.Add(this.gpAction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpRegister);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purveyor Register";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gpRegister.ResumeLayout(false);
            this.gpRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purveyorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            this.gpAction.ResumeLayout(false);
            this.gpBrowser.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpRegister;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpAction;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox gpBrowser;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button button6;
        private DataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource purveyorBindingSource;
        private DataBaseDataSetTableAdapters.PurveyorTableAdapter purveyorTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}