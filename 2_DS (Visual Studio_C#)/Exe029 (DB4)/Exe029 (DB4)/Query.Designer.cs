namespace Exe029__DB4_
{
    partial class Query
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rdbName = new System.Windows.Forms.RadioButton();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.rdbCode = new System.Windows.Forms.RadioButton();
            this.rdbGeral = new System.Windows.Forms.RadioButton();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "List of Registered Users";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.rdbName);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.rdbCode);
            this.groupBox1.Controls.Add(this.rdbGeral);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.groupBox1.Location = new System.Drawing.Point(18, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 151);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select the type of query:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSearch.Location = new System.Drawing.Point(299, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search >>";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtName.Location = new System.Drawing.Point(154, 101);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(126, 26);
            this.txtName.TabIndex = 4;
            // 
            // rdbName
            // 
            this.rdbName.AutoSize = true;
            this.rdbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdbName.Location = new System.Drawing.Point(16, 102);
            this.rdbName.Name = "rdbName";
            this.rdbName.Size = new System.Drawing.Size(135, 24);
            this.rdbName.TabIndex = 3;
            this.rdbName.TabStop = true;
            this.rdbName.Text = "Query by Name";
            this.rdbName.UseVisualStyleBackColor = true;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCode.Location = new System.Drawing.Point(154, 70);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(126, 26);
            this.txtCode.TabIndex = 2;
            // 
            // rdbCode
            // 
            this.rdbCode.AutoSize = true;
            this.rdbCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdbCode.Location = new System.Drawing.Point(16, 70);
            this.rdbCode.Name = "rdbCode";
            this.rdbCode.Size = new System.Drawing.Size(131, 24);
            this.rdbCode.TabIndex = 1;
            this.rdbCode.TabStop = true;
            this.rdbCode.Text = "Query by Code";
            this.rdbCode.UseVisualStyleBackColor = true;
            // 
            // rdbGeral
            // 
            this.rdbGeral.AutoSize = true;
            this.rdbGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rdbGeral.Location = new System.Drawing.Point(16, 40);
            this.rdbGeral.Name = "rdbGeral";
            this.rdbGeral.Size = new System.Drawing.Size(95, 24);
            this.rdbGeral.TabIndex = 0;
            this.rdbGeral.TabStop = true;
            this.rdbGeral.Text = "Geral List";
            this.rdbGeral.UseVisualStyleBackColor = true;
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(18, 211);
            this.dgvList.Name = "dgvList";
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(400, 137);
            this.dgvList.TabIndex = 2;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvList_CellClick);
            this.dgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvList_CellContentClick);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBack.Location = new System.Drawing.Point(172, 354);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 30);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "<< Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 395);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Query";
            this.Text = "Query";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rdbName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.RadioButton rdbCode;
        private System.Windows.Forms.RadioButton rdbGeral;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnBack;
    }
}