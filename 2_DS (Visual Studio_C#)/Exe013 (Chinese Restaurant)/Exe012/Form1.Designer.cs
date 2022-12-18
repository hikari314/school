namespace Exe012
{
    partial class FrmExe012
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CboMain = new System.Windows.Forms.ComboBox();
            this.LstSide = new System.Windows.Forms.ListBox();
            this.BtnInDish = new System.Windows.Forms.Button();
            this.BtnInSide = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnExclude = new System.Windows.Forms.Button();
            this.LblItems = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LstBOrder = new System.Windows.Forms.ListBox();
            this.BtnNew = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(202, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurant Shu";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Main Duck:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(12, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Side Dishes:";
            // 
            // CboMain
            // 
            this.CboMain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.CboMain.FormattingEnabled = true;
            this.CboMain.Location = new System.Drawing.Point(150, 61);
            this.CboMain.Name = "CboMain";
            this.CboMain.Size = new System.Drawing.Size(196, 33);
            this.CboMain.Sorted = true;
            this.CboMain.TabIndex = 3;
            this.CboMain.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // LstSide
            // 
            this.LstSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LstSide.FormattingEnabled = true;
            this.LstSide.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.LstSide.ItemHeight = 25;
            this.LstSide.Location = new System.Drawing.Point(149, 123);
            this.LstSide.Name = "LstSide";
            this.LstSide.ScrollAlwaysVisible = true;
            this.LstSide.Size = new System.Drawing.Size(195, 29);
            this.LstSide.Sorted = true;
            this.LstSide.TabIndex = 4;
            this.LstSide.SelectedIndexChanged += new System.EventHandler(this.LstSide_SelectedIndexChanged);
            // 
            // BtnInDish
            // 
            this.BtnInDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnInDish.Location = new System.Drawing.Point(379, 57);
            this.BtnInDish.Name = "BtnInDish";
            this.BtnInDish.Size = new System.Drawing.Size(213, 38);
            this.BtnInDish.TabIndex = 5;
            this.BtnInDish.Text = "Include Dish";
            this.BtnInDish.UseVisualStyleBackColor = true;
            this.BtnInDish.Click += new System.EventHandler(this.BtnInDish_Click);
            // 
            // BtnInSide
            // 
            this.BtnInSide.Enabled = false;
            this.BtnInSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnInSide.Location = new System.Drawing.Point(379, 116);
            this.BtnInSide.Name = "BtnInSide";
            this.BtnInSide.Size = new System.Drawing.Size(213, 38);
            this.BtnInSide.TabIndex = 6;
            this.BtnInSide.Text = "Include Side Dish";
            this.BtnInSide.UseVisualStyleBackColor = true;
            this.BtnInSide.Click += new System.EventHandler(this.BtnInSide_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnExclude);
            this.groupBox1.Controls.Add(this.LblItems);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LstBOrder);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.groupBox1.Location = new System.Drawing.Point(17, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 172);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order";
            // 
            // BtnExclude
            // 
            this.BtnExclude.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BtnExclude.Location = new System.Drawing.Point(375, 120);
            this.BtnExclude.Name = "BtnExclude";
            this.BtnExclude.Size = new System.Drawing.Size(160, 38);
            this.BtnExclude.TabIndex = 8;
            this.BtnExclude.Text = "Exclude Item";
            this.BtnExclude.UseVisualStyleBackColor = true;
            this.BtnExclude.Click += new System.EventHandler(this.BtnExclude_Click);
            // 
            // LblItems
            // 
            this.LblItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LblItems.Location = new System.Drawing.Point(429, 60);
            this.LblItems.Name = "LblItems";
            this.LblItems.Size = new System.Drawing.Size(44, 36);
            this.LblItems.TabIndex = 9;
            this.LblItems.Text = "0";
            this.LblItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(357, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total Items in Order:";
            // 
            // LstBOrder
            // 
            this.LstBOrder.FormattingEnabled = true;
            this.LstBOrder.ItemHeight = 25;
            this.LstBOrder.Location = new System.Drawing.Point(6, 29);
            this.LstBOrder.Name = "LstBOrder";
            this.LstBOrder.Size = new System.Drawing.Size(345, 129);
            this.LstBOrder.TabIndex = 0;
            // 
            // BtnNew
            // 
            this.BtnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnNew.Location = new System.Drawing.Point(87, 348);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(160, 38);
            this.BtnNew.TabIndex = 10;
            this.BtnNew.Text = "New Order";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.BtnExit.Location = new System.Drawing.Point(330, 348);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(160, 38);
            this.BtnExit.TabIndex = 11;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmExe012
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 401);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnInSide);
            this.Controls.Add(this.BtnInDish);
            this.Controls.Add(this.LstSide);
            this.Controls.Add(this.CboMain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmExe012";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order - Chinese Food";
            this.Load += new System.EventHandler(this.FrmExe012_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CboMain;
        private System.Windows.Forms.ListBox LstSide;
        private System.Windows.Forms.Button BtnInDish;
        private System.Windows.Forms.Button BtnInSide;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnExclude;
        private System.Windows.Forms.Label LblItems;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LstBOrder;
        private System.Windows.Forms.Button BtnNew;
        private System.Windows.Forms.Button BtnExit;
    }
}

