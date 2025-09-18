
namespace SistemaDropToParadise
{
    partial class formRelProduto
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ClassProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoRel = new System.Windows.Forms.ComboBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btGerarRelatorio = new System.Windows.Forms.Button();
            this.gbMarca = new System.Windows.Forms.GroupBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.gbDataAdmissao = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.gbQuantidade = new System.Windows.Forms.GroupBox();
            this.dtpMax = new System.Windows.Forms.TextBox();
            this.dtpMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbPromocao = new System.Windows.Forms.GroupBox();
            this.com = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rptvProduto = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ClassProdutoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbMarca.SuspendLayout();
            this.gbDataAdmissao.SuspendLayout();
            this.gbCategoria.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbQuantidade.SuspendLayout();
            this.gbPromocao.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClassProdutoBindingSource
            // 
            this.ClassProdutoBindingSource.DataSource = typeof(SistemaDropToParadise.ClassProduto);
            this.ClassProdutoBindingSource.CurrentChanged += new System.EventHandler(this.ClassProdutoBindingSource_CurrentChanged);
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rbAtivo.Location = new System.Drawing.Point(12, 32);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(57, 21);
            this.rbAtivo.TabIndex = 134;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbTipoRel);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 60);
            this.groupBox1.TabIndex = 145;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 23);
            this.label1.TabIndex = 134;
            this.label1.Text = "Selecione o Tipo de Relatório:";
            // 
            // cbTipoRel
            // 
            this.cbTipoRel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoRel.Font = new System.Drawing.Font("Calibri", 10F);
            this.cbTipoRel.FormattingEnabled = true;
            this.cbTipoRel.Location = new System.Drawing.Point(256, 24);
            this.cbTipoRel.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoRel.Name = "cbTipoRel";
            this.cbTipoRel.Size = new System.Drawing.Size(161, 23);
            this.cbTipoRel.TabIndex = 130;
            this.cbTipoRel.SelectedIndexChanged += new System.EventHandler(this.cbTipoRel_SelectedIndexChanged);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.White;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSair.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(632, 59);
            this.btSair.Name = "btSair";
            this.btSair.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btSair.Size = new System.Drawing.Size(129, 50);
            this.btSair.TabIndex = 144;
            this.btSair.Text = "     Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btGerarRelatorio
            // 
            this.btGerarRelatorio.BackColor = System.Drawing.Color.White;
            this.btGerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGerarRelatorio.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerarRelatorio.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btGerarRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGerarRelatorio.Location = new System.Drawing.Point(450, 59);
            this.btGerarRelatorio.Name = "btGerarRelatorio";
            this.btGerarRelatorio.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btGerarRelatorio.Size = new System.Drawing.Size(176, 50);
            this.btGerarRelatorio.TabIndex = 143;
            this.btGerarRelatorio.Text = "     Gerar Relatório";
            this.btGerarRelatorio.UseVisualStyleBackColor = false;
            this.btGerarRelatorio.Click += new System.EventHandler(this.btGerarRelatorio_Click);
            // 
            // gbMarca
            // 
            this.gbMarca.Controls.Add(this.cbMarca);
            this.gbMarca.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMarca.ForeColor = System.Drawing.Color.White;
            this.gbMarca.Location = new System.Drawing.Point(586, 118);
            this.gbMarca.Name = "gbMarca";
            this.gbMarca.Size = new System.Drawing.Size(175, 66);
            this.gbMarca.TabIndex = 137;
            this.gbMarca.TabStop = false;
            this.gbMarca.Text = "Marca:";
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(7, 25);
            this.cbMarca.Margin = new System.Windows.Forms.Padding(4);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(161, 27);
            this.cbMarca.TabIndex = 79;
            // 
            // gbDataAdmissao
            // 
            this.gbDataAdmissao.Controls.Add(this.label6);
            this.gbDataAdmissao.Controls.Add(this.label8);
            this.gbDataAdmissao.Controls.Add(this.dtpDataFinal);
            this.gbDataAdmissao.Controls.Add(this.dtpDataInicial);
            this.gbDataAdmissao.ForeColor = System.Drawing.Color.White;
            this.gbDataAdmissao.Location = new System.Drawing.Point(12, 118);
            this.gbDataAdmissao.Name = "gbDataAdmissao";
            this.gbDataAdmissao.Size = new System.Drawing.Size(356, 66);
            this.gbDataAdmissao.TabIndex = 140;
            this.gbDataAdmissao.TabStop = false;
            this.gbDataAdmissao.Text = "Data de Admissão:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(176, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 19);
            this.label6.TabIndex = 46;
            this.label6.Text = "Até:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 19);
            this.label8.TabIndex = 46;
            this.label8.Text = "De:";
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(217, 25);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(116, 20);
            this.dtpDataFinal.TabIndex = 1;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(46, 25);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(116, 20);
            this.dtpDataInicial.TabIndex = 0;
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.cbCategoria);
            this.gbCategoria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCategoria.ForeColor = System.Drawing.Color.White;
            this.gbCategoria.Location = new System.Drawing.Point(389, 118);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Size = new System.Drawing.Size(175, 66);
            this.gbCategoria.TabIndex = 141;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "Categoria:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(9, 28);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(153, 27);
            this.cbCategoria.TabIndex = 66;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.ForeColor = System.Drawing.Color.White;
            this.gbStatus.Location = new System.Drawing.Point(12, 190);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(206, 66);
            this.gbStatus.TabIndex = 136;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status:";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(119, 30);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(71, 23);
            this.rbInativo.TabIndex = 2;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(278, 20);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(233, 29);
            this.lbTitulo.TabIndex = 65;
            this.lbTitulo.Text = "Relatório de Produtos";
            // 
            // gbQuantidade
            // 
            this.gbQuantidade.Controls.Add(this.dtpMax);
            this.gbQuantidade.Controls.Add(this.dtpMin);
            this.gbQuantidade.Controls.Add(this.label2);
            this.gbQuantidade.Controls.Add(this.label3);
            this.gbQuantidade.ForeColor = System.Drawing.Color.White;
            this.gbQuantidade.Location = new System.Drawing.Point(229, 190);
            this.gbQuantidade.Name = "gbQuantidade";
            this.gbQuantidade.Size = new System.Drawing.Size(282, 66);
            this.gbQuantidade.TabIndex = 141;
            this.gbQuantidade.TabStop = false;
            this.gbQuantidade.Text = "Quantidade:";
            // 
            // dtpMax
            // 
            this.dtpMax.Location = new System.Drawing.Point(193, 28);
            this.dtpMax.Name = "dtpMax";
            this.dtpMax.Size = new System.Drawing.Size(77, 20);
            this.dtpMax.TabIndex = 48;
            this.dtpMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpMax_KeyPress);
            // 
            // dtpMin
            // 
            this.dtpMin.Location = new System.Drawing.Point(39, 28);
            this.dtpMin.Name = "dtpMin";
            this.dtpMin.Size = new System.Drawing.Size(77, 20);
            this.dtpMin.TabIndex = 47;
            this.dtpMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpMin_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 19);
            this.label2.TabIndex = 46;
            this.label2.Text = "Até:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 19);
            this.label3.TabIndex = 46;
            this.label3.Text = "De:";
            // 
            // gbPromocao
            // 
            this.gbPromocao.BackColor = System.Drawing.Color.Transparent;
            this.gbPromocao.Controls.Add(this.com);
            this.gbPromocao.Controls.Add(this.radioButton2);
            this.gbPromocao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPromocao.ForeColor = System.Drawing.Color.White;
            this.gbPromocao.Location = new System.Drawing.Point(517, 190);
            this.gbPromocao.Name = "gbPromocao";
            this.gbPromocao.Size = new System.Drawing.Size(244, 66);
            this.gbPromocao.TabIndex = 137;
            this.gbPromocao.TabStop = false;
            this.gbPromocao.Text = "Promoção";
            // 
            // com
            // 
            this.com.AutoSize = true;
            this.com.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.com.Location = new System.Drawing.Point(12, 32);
            this.com.Name = "com";
            this.com.Size = new System.Drawing.Size(54, 21);
            this.com.TabIndex = 134;
            this.com.Text = "Com";
            this.com.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(137, 30);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 23);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Sem";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rptvProduto
            // 
            reportDataSource2.Name = "dsProduto";
            reportDataSource2.Value = this.ClassProdutoBindingSource;
            this.rptvProduto.LocalReport.DataSources.Add(reportDataSource2);
            this.rptvProduto.LocalReport.ReportEmbeddedResource = "SistemaDropToParadise.rptProduto.rdlc";
            this.rptvProduto.Location = new System.Drawing.Point(12, 271);
            this.rptvProduto.Name = "rptvProduto";
            this.rptvProduto.ServerReport.BearerToken = null;
            this.rptvProduto.Size = new System.Drawing.Size(753, 584);
            this.rptvProduto.TabIndex = 146;
            this.rptvProduto.Load += new System.EventHandler(this.rptvProduto_Load);
            // 
            // formRelProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(777, 820);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.rptvProduto);
            this.Controls.Add(this.gbPromocao);
            this.Controls.Add(this.gbQuantidade);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btGerarRelatorio);
            this.Controls.Add(this.gbMarca);
            this.Controls.Add(this.gbDataAdmissao);
            this.Controls.Add(this.gbCategoria);
            this.Controls.Add(this.gbStatus);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formRelProduto";
            this.Text = "formRelProduto";
            this.Load += new System.EventHandler(this.formRelProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassProdutoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbMarca.ResumeLayout(false);
            this.gbDataAdmissao.ResumeLayout(false);
            this.gbDataAdmissao.PerformLayout();
            this.gbCategoria.ResumeLayout(false);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbQuantidade.ResumeLayout(false);
            this.gbQuantidade.PerformLayout();
            this.gbPromocao.ResumeLayout(false);
            this.gbPromocao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbTipoRel;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btGerarRelatorio;
        private System.Windows.Forms.GroupBox gbMarca;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.GroupBox gbDataAdmissao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.GroupBox gbQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dtpMin;
        private System.Windows.Forms.TextBox dtpMax;
        private System.Windows.Forms.GroupBox gbPromocao;
        private System.Windows.Forms.RadioButton com;
        private System.Windows.Forms.RadioButton radioButton2;
        private Microsoft.Reporting.WinForms.ReportViewer rptvProduto;
        private System.Windows.Forms.BindingSource ClassProdutoBindingSource;
    }
}