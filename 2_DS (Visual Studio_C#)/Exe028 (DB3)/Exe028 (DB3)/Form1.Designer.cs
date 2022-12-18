namespace Exe028__DB3_
{
    partial class FrmProducts
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
            this.label1 = new System.Windows.Forms.Label();
            this.GprData = new System.Windows.Forms.GroupBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet = new Exe028__DB3_.DataBaseDataSet();
            this.txtMaxQuan = new System.Windows.Forms.TextBox();
            this.txtMinQuan = new System.Windows.Forms.TextBox();
            this.cboCorporate = new System.Windows.Forms.ComboBox();
            this.purveyorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtDescrProd = new System.Windows.Forms.TextBox();
            this.txtCodProd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gprAct = new System.Windows.Forms.GroupBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.gprBrowser = new System.Windows.Forms.GroupBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.productsTableAdapter = new Exe028__DB3_.DataBaseDataSetTableAdapters.ProductsTableAdapter();
            this.purveyorTableAdapter = new Exe028__DB3_.DataBaseDataSetTableAdapters.PurveyorTableAdapter();
            this.btnPur = new System.Windows.Forms.Button();
            this.GprData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purveyorBindingSource)).BeginInit();
            this.gprAct.SuspendLayout();
            this.gprBrowser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(163, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products Register ";
            // 
            // GprData
            // 
            this.GprData.Controls.Add(this.txtUnit);
            this.GprData.Controls.Add(this.txtMaxQuan);
            this.GprData.Controls.Add(this.txtMinQuan);
            this.GprData.Controls.Add(this.cboCorporate);
            this.GprData.Controls.Add(this.txtQuantity);
            this.GprData.Controls.Add(this.txtDescrProd);
            this.GprData.Controls.Add(this.txtCodProd);
            this.GprData.Controls.Add(this.label8);
            this.GprData.Controls.Add(this.label7);
            this.GprData.Controls.Add(this.label6);
            this.GprData.Controls.Add(this.label5);
            this.GprData.Controls.Add(this.label4);
            this.GprData.Controls.Add(this.label3);
            this.GprData.Controls.Add(this.label2);
            this.GprData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.GprData.Location = new System.Drawing.Point(13, 56);
            this.GprData.Name = "GprData";
            this.GprData.Size = new System.Drawing.Size(401, 254);
            this.GprData.TabIndex = 1;
            this.GprData.TabStop = false;
            this.GprData.Text = "Registration Data";
            // 
            // txtUnit
            // 
            this.txtUnit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "UnitPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.txtUnit.Enabled = false;
            this.txtUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUnit.Location = new System.Drawing.Point(167, 214);
            this.txtUnit.MaxLength = 10;
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(211, 26);
            this.txtUnit.TabIndex = 6;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // dataBaseDataSet
            // 
            this.dataBaseDataSet.DataSetName = "DataBaseDataSet";
            this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMaxQuan
            // 
            this.txtMaxQuan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "MaxQuantity", true));
            this.txtMaxQuan.Enabled = false;
            this.txtMaxQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMaxQuan.Location = new System.Drawing.Point(167, 185);
            this.txtMaxQuan.MaxLength = 5;
            this.txtMaxQuan.Name = "txtMaxQuan";
            this.txtMaxQuan.Size = new System.Drawing.Size(211, 26);
            this.txtMaxQuan.TabIndex = 5;
            // 
            // txtMinQuan
            // 
            this.txtMinQuan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "MinQuantity", true));
            this.txtMinQuan.Enabled = false;
            this.txtMinQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtMinQuan.Location = new System.Drawing.Point(167, 154);
            this.txtMinQuan.MaxLength = 5;
            this.txtMinQuan.Name = "txtMinQuan";
            this.txtMinQuan.Size = new System.Drawing.Size(211, 26);
            this.txtMinQuan.TabIndex = 4;
            // 
            // cboCorporate
            // 
            this.cboCorporate.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource, "CodPur", true));
            this.cboCorporate.DataSource = this.purveyorBindingSource;
            this.cboCorporate.DisplayMember = "CorporateName";
            this.cboCorporate.Enabled = false;
            this.cboCorporate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cboCorporate.FormattingEnabled = true;
            this.cboCorporate.Location = new System.Drawing.Point(167, 91);
            this.cboCorporate.Name = "cboCorporate";
            this.cboCorporate.Size = new System.Drawing.Size(211, 28);
            this.cboCorporate.TabIndex = 2;
            this.cboCorporate.ValueMember = "CodPur";
            // 
            // purveyorBindingSource
            // 
            this.purveyorBindingSource.DataMember = "Purveyor";
            this.purveyorBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // txtQuantity
            // 
            this.txtQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "StockQuantity", true));
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtQuantity.Location = new System.Drawing.Point(167, 123);
            this.txtQuantity.MaxLength = 5;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(211, 26);
            this.txtQuantity.TabIndex = 3;
            // 
            // txtDescrProd
            // 
            this.txtDescrProd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Description", true));
            this.txtDescrProd.Enabled = false;
            this.txtDescrProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDescrProd.Location = new System.Drawing.Point(167, 62);
            this.txtDescrProd.MaxLength = 50;
            this.txtDescrProd.Name = "txtDescrProd";
            this.txtDescrProd.Size = new System.Drawing.Size(211, 26);
            this.txtDescrProd.TabIndex = 1;
            // 
            // txtCodProd
            // 
            this.txtCodProd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "CodPro", true));
            this.txtCodProd.Enabled = false;
            this.txtCodProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCodProd.Location = new System.Drawing.Point(167, 32);
            this.txtCodProd.MaxLength = 5;
            this.txtCodProd.Name = "txtCodProd";
            this.txtCodProd.Size = new System.Drawing.Size(211, 26);
            this.txtCodProd.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(9, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Unit Value:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(9, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Max. Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(9, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Min. Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(9, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Stock Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(9, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Purveyor Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(9, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product Code:";
            // 
            // gprAct
            // 
            this.gprAct.Controls.Add(this.btnList);
            this.gprAct.Controls.Add(this.btnDelete);
            this.gprAct.Controls.Add(this.btnEdit);
            this.gprAct.Controls.Add(this.btnRegister);
            this.gprAct.Controls.Add(this.btnNew);
            this.gprAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.gprAct.Location = new System.Drawing.Point(439, 56);
            this.gprAct.Name = "gprAct";
            this.gprAct.Size = new System.Drawing.Size(116, 254);
            this.gprAct.TabIndex = 2;
            this.gprAct.TabStop = false;
            this.gprAct.Text = "Actions";
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnList.Location = new System.Drawing.Point(11, 191);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(95, 31);
            this.btnList.TabIndex = 4;
            this.btnList.Text = "&List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDelete.Location = new System.Drawing.Point(11, 154);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 31);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEdit.Location = new System.Drawing.Point(11, 117);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 31);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Enabled = false;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnRegister.Location = new System.Drawing.Point(11, 80);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(95, 31);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "&Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNew.Location = new System.Drawing.Point(11, 45);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(95, 31);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // gprBrowser
            // 
            this.gprBrowser.Controls.Add(this.btnPrevious);
            this.gprBrowser.Controls.Add(this.btnNext);
            this.gprBrowser.Controls.Add(this.btnLast);
            this.gprBrowser.Controls.Add(this.btnFirst);
            this.gprBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.gprBrowser.Location = new System.Drawing.Point(13, 316);
            this.gprBrowser.Name = "gprBrowser";
            this.gprBrowser.Size = new System.Drawing.Size(401, 77);
            this.gprBrowser.TabIndex = 3;
            this.gprBrowser.TabStop = false;
            this.gprBrowser.Text = "Browsing";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPrevious.Location = new System.Drawing.Point(139, 26);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(46, 39);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "<";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNext.Location = new System.Drawing.Point(216, 26);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(46, 39);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLast.Location = new System.Drawing.Point(332, 26);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(46, 39);
            this.btnLast.TabIndex = 1;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFirst.Location = new System.Drawing.Point(13, 26);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(46, 39);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnClose.Location = new System.Drawing.Point(451, 342);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 39);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // purveyorTableAdapter
            // 
            this.purveyorTableAdapter.ClearBeforeFill = true;
            // 
            // btnPur
            // 
            this.btnPur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPur.Location = new System.Drawing.Point(460, 12);
            this.btnPur.Name = "btnPur";
            this.btnPur.Size = new System.Drawing.Size(85, 29);
            this.btnPur.TabIndex = 6;
            this.btnPur.Text = "Purveyor";
            this.btnPur.UseVisualStyleBackColor = true;
            this.btnPur.Click += new System.EventHandler(this.BtnPur_Click);
            // 
            // FrmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 404);
            this.Controls.Add(this.btnPur);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gprBrowser);
            this.Controls.Add(this.gprAct);
            this.Controls.Add(this.GprData);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products Register";
            this.Load += new System.EventHandler(this.FrmProducts_Load);
            this.GprData.ResumeLayout(false);
            this.GprData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purveyorBindingSource)).EndInit();
            this.gprAct.ResumeLayout(false);
            this.gprBrowser.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GprData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtMaxQuan;
        private System.Windows.Forms.TextBox txtMinQuan;
        private System.Windows.Forms.ComboBox cboCorporate;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtDescrProd;
        private System.Windows.Forms.TextBox txtCodProd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gprAct;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox gprBrowser;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnClose;
        private DataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private DataBaseDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource purveyorBindingSource;
        private DataBaseDataSetTableAdapters.PurveyorTableAdapter purveyorTableAdapter;
        private System.Windows.Forms.Button btnPur;
    }
}

