namespace Exe028__DB3_
{
    partial class FrmList2
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
            this.txtQuick = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codPurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corporateNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purveyorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet = new Exe028__DB3_.DataBaseDataSet();
            this.purveyorTableAdapter = new Exe028__DB3_.DataBaseDataSetTableAdapters.PurveyorTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purveyorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuick
            // 
            this.txtQuick.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtQuick.Location = new System.Drawing.Point(209, 4);
            this.txtQuick.Name = "txtQuick";
            this.txtQuick.Size = new System.Drawing.Size(270, 27);
            this.txtQuick.TabIndex = 7;
            this.txtQuick.TextChanged += new System.EventHandler(this.TxtQuick_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quick Consultation:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codPurDataGridViewTextBoxColumn,
            this.corporateNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.purveyorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(153, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(244, 122);
            this.dataGridView1.TabIndex = 8;
            // 
            // codPurDataGridViewTextBoxColumn
            // 
            this.codPurDataGridViewTextBoxColumn.DataPropertyName = "CodPur";
            this.codPurDataGridViewTextBoxColumn.HeaderText = "CodPur";
            this.codPurDataGridViewTextBoxColumn.Name = "codPurDataGridViewTextBoxColumn";
            this.codPurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // corporateNameDataGridViewTextBoxColumn
            // 
            this.corporateNameDataGridViewTextBoxColumn.DataPropertyName = "CorporateName";
            this.corporateNameDataGridViewTextBoxColumn.HeaderText = "CorporateName";
            this.corporateNameDataGridViewTextBoxColumn.Name = "corporateNameDataGridViewTextBoxColumn";
            this.corporateNameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // purveyorTableAdapter
            // 
            this.purveyorTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button3.Location = new System.Drawing.Point(373, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 33);
            this.button3.TabIndex = 10;
            this.button3.Text = "&Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.button1.Location = new System.Drawing.Point(41, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "&General List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FrmList2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 233);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtQuick);
            this.Controls.Add(this.label1);
            this.Name = "FrmList2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmList2";
            this.Load += new System.EventHandler(this.FrmList2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purveyorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource purveyorBindingSource;
        private DataBaseDataSetTableAdapters.PurveyorTableAdapter purveyorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corporateNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}