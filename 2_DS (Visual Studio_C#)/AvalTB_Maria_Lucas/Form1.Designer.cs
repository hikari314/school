namespace AvalTB_Maria_Lucas
{
    partial class FrmAvaliacao
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
            this.LblAvaliacao = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblQuestoes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNomeB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtB1 = new System.Windows.Forms.TextBox();
            this.TxtB2 = new System.Windows.Forms.TextBox();
            this.TxtB3 = new System.Windows.Forms.TextBox();
            this.LblStatusB1 = new System.Windows.Forms.Label();
            this.LblStatusB2 = new System.Windows.Forms.Label();
            this.LblStatusB3 = new System.Windows.Forms.Label();
            this.BtnVerificarB = new System.Windows.Forms.Button();
            this.BtnLimparB = new System.Windows.Forms.Button();
            this.BtnSairB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblAvaliacao
            // 
            this.LblAvaliacao.AutoSize = true;
            this.LblAvaliacao.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAvaliacao.Location = new System.Drawing.Point(222, 32);
            this.LblAvaliacao.Name = "LblAvaliacao";
            this.LblAvaliacao.Size = new System.Drawing.Size(231, 25);
            this.LblAvaliacao.TabIndex = 0;
            this.LblAvaliacao.Text = "Avaliação de Matemática";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(32, 99);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(156, 50);
            this.LblNome.TabIndex = 1;
            this.LblNome.Text = "Nome do Aluno:\r\n\r\n";
            // 
            // LblQuestoes
            // 
            this.LblQuestoes.AutoSize = true;
            this.LblQuestoes.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuestoes.Location = new System.Drawing.Point(53, 191);
            this.LblQuestoes.Name = "LblQuestoes";
            this.LblQuestoes.Size = new System.Drawing.Size(93, 25);
            this.LblQuestoes.TabIndex = 2;
            this.LblQuestoes.Text = "Questões";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Respostas";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(500, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "(Opcional)";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // TxtNomeB
            // 
            this.TxtNomeB.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNomeB.Location = new System.Drawing.Point(194, 96);
            this.TxtNomeB.MaxLength = 50;
            this.TxtNomeB.Name = "TxtNomeB";
            this.TxtNomeB.Size = new System.Drawing.Size(401, 33);
            this.TxtNomeB.TabIndex = 0;
            this.TxtNomeB.TextChanged += new System.EventHandler(this.TxtNomeB_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "X - 4 = 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "5 + X = 7";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "X * 2 = 10";
            // 
            // TxtB1
            // 
            this.TxtB1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.TxtB1.Location = new System.Drawing.Point(300, 230);
            this.TxtB1.MaxLength = 1;
            this.TxtB1.Name = "TxtB1";
            this.TxtB1.Size = new System.Drawing.Size(53, 28);
            this.TxtB1.TabIndex = 1;
            // 
            // TxtB2
            // 
            this.TxtB2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.TxtB2.Location = new System.Drawing.Point(300, 282);
            this.TxtB2.MaxLength = 1;
            this.TxtB2.Name = "TxtB2";
            this.TxtB2.Size = new System.Drawing.Size(53, 28);
            this.TxtB2.TabIndex = 2;
            // 
            // TxtB3
            // 
            this.TxtB3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F);
            this.TxtB3.Location = new System.Drawing.Point(300, 333);
            this.TxtB3.MaxLength = 1;
            this.TxtB3.Name = "TxtB3";
            this.TxtB3.Size = new System.Drawing.Size(53, 28);
            this.TxtB3.TabIndex = 3;
            // 
            // LblStatusB1
            // 
            this.LblStatusB1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblStatusB1.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatusB1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblStatusB1.Location = new System.Drawing.Point(473, 235);
            this.LblStatusB1.Name = "LblStatusB1";
            this.LblStatusB1.Size = new System.Drawing.Size(121, 23);
            this.LblStatusB1.TabIndex = 11;
            // 
            // LblStatusB2
            // 
            this.LblStatusB2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblStatusB2.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatusB2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblStatusB2.Location = new System.Drawing.Point(474, 287);
            this.LblStatusB2.Name = "LblStatusB2";
            this.LblStatusB2.Size = new System.Drawing.Size(121, 23);
            this.LblStatusB2.TabIndex = 12;
            // 
            // LblStatusB3
            // 
            this.LblStatusB3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LblStatusB3.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatusB3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblStatusB3.Location = new System.Drawing.Point(474, 338);
            this.LblStatusB3.Name = "LblStatusB3";
            this.LblStatusB3.Size = new System.Drawing.Size(121, 23);
            this.LblStatusB3.TabIndex = 13;
            // 
            // BtnVerificarB
            // 
            this.BtnVerificarB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnVerificarB.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerificarB.Location = new System.Drawing.Point(37, 428);
            this.BtnVerificarB.Name = "BtnVerificarB";
            this.BtnVerificarB.Size = new System.Drawing.Size(195, 33);
            this.BtnVerificarB.TabIndex = 14;
            this.BtnVerificarB.Text = "Verificar Respostas";
            this.BtnVerificarB.UseVisualStyleBackColor = false;
            this.BtnVerificarB.Click += new System.EventHandler(this.BtnVerificarB_Click);
            // 
            // BtnLimparB
            // 
            this.BtnLimparB.Enabled = false;
            this.BtnLimparB.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimparB.Location = new System.Drawing.Point(280, 428);
            this.BtnLimparB.Name = "BtnLimparB";
            this.BtnLimparB.Size = new System.Drawing.Size(122, 33);
            this.BtnLimparB.TabIndex = 15;
            this.BtnLimparB.Text = "Limpar";
            this.BtnLimparB.UseVisualStyleBackColor = true;
            this.BtnLimparB.Click += new System.EventHandler(this.BtnLimparB_Click);
            // 
            // BtnSairB
            // 
            this.BtnSairB.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSairB.Location = new System.Drawing.Point(473, 428);
            this.BtnSairB.Name = "BtnSairB";
            this.BtnSairB.Size = new System.Drawing.Size(122, 33);
            this.BtnSairB.TabIndex = 16;
            this.BtnSairB.Text = "Sair";
            this.BtnSairB.UseVisualStyleBackColor = true;
            this.BtnSairB.Click += new System.EventHandler(this.BtnSairB_Click);
            // 
            // FrmAvaliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 511);
            this.Controls.Add(this.BtnSairB);
            this.Controls.Add(this.BtnLimparB);
            this.Controls.Add(this.BtnVerificarB);
            this.Controls.Add(this.LblStatusB3);
            this.Controls.Add(this.LblStatusB2);
            this.Controls.Add(this.LblStatusB1);
            this.Controls.Add(this.TxtB3);
            this.Controls.Add(this.TxtB2);
            this.Controls.Add(this.TxtB1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtNomeB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblQuestoes);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.LblAvaliacao);
            this.Name = "FrmAvaliacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avaliação de DS - 2° ETIM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAvaliacao;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblQuestoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNomeB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtB1;
        private System.Windows.Forms.TextBox TxtB2;
        private System.Windows.Forms.TextBox TxtB3;
        private System.Windows.Forms.Label LblStatusB1;
        private System.Windows.Forms.Label LblStatusB2;
        private System.Windows.Forms.Label LblStatusB3;
        private System.Windows.Forms.Button BtnVerificarB;
        private System.Windows.Forms.Button BtnLimparB;
        private System.Windows.Forms.Button BtnSairB;
    }
}

