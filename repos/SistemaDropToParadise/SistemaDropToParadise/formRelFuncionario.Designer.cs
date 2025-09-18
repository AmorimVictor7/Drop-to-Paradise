namespace SistemaDropToParadise
{
    partial class formRelFuncionario
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.classFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btGerarRelatorio = new System.Windows.Forms.Button();
            this.gbSexo = new System.Windows.Forms.GroupBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.gbDataAdmissao = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.cbTipoRel = new System.Windows.Forms.ComboBox();
            this.gbCidade = new System.Windows.Forms.GroupBox();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.gbAniversariantes = new System.Windows.Forms.GroupBox();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.gbIdade = new System.Windows.Forms.GroupBox();
            this.txtIdadeFinal = new System.Windows.Forms.TextBox();
            this.txtIdadeInicial = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.rptvFuncionario = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.gbCargo = new System.Windows.Forms.GroupBox();
            this.ClassClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.classFuncionarioBindingSource)).BeginInit();
            this.gbSexo.SuspendLayout();
            this.gbDataAdmissao.SuspendLayout();
            this.gbCidade.SuspendLayout();
            this.gbAniversariantes.SuspendLayout();
            this.gbIdade.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbCargo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // classFuncionarioBindingSource
            // 
            this.classFuncionarioBindingSource.DataSource = typeof(SistemaDropToParadise.classFuncionario);
            // 
            // btGerarRelatorio
            // 
            this.btGerarRelatorio.BackColor = System.Drawing.Color.White;
            this.btGerarRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btGerarRelatorio.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerarRelatorio.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btGerarRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGerarRelatorio.Location = new System.Drawing.Point(442, 59);
            this.btGerarRelatorio.Name = "btGerarRelatorio";
            this.btGerarRelatorio.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btGerarRelatorio.Size = new System.Drawing.Size(176, 50);
            this.btGerarRelatorio.TabIndex = 131;
            this.btGerarRelatorio.Text = "     Gerar Relatório";
            this.btGerarRelatorio.UseVisualStyleBackColor = false;
            this.btGerarRelatorio.Click += new System.EventHandler(this.btGerarRelatorio_Click);
            // 
            // gbSexo
            // 
            this.gbSexo.Controls.Add(this.cbSexo);
            this.gbSexo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSexo.ForeColor = System.Drawing.Color.White;
            this.gbSexo.Location = new System.Drawing.Point(374, 190);
            this.gbSexo.Name = "gbSexo";
            this.gbSexo.Size = new System.Drawing.Size(175, 66);
            this.gbSexo.TabIndex = 123;
            this.gbSexo.TabStop = false;
            this.gbSexo.Text = "Sexo:";
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(7, 25);
            this.cbSexo.Margin = new System.Windows.Forms.Padding(4);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(161, 27);
            this.cbSexo.TabIndex = 79;
            // 
            // gbDataAdmissao
            // 
            this.gbDataAdmissao.Controls.Add(this.label6);
            this.gbDataAdmissao.Controls.Add(this.label8);
            this.gbDataAdmissao.Controls.Add(this.dtpDataFinal);
            this.gbDataAdmissao.Controls.Add(this.dtpDataInicial);
            this.gbDataAdmissao.ForeColor = System.Drawing.Color.White;
            this.gbDataAdmissao.Location = new System.Drawing.Point(193, 118);
            this.gbDataAdmissao.Name = "gbDataAdmissao";
            this.gbDataAdmissao.Size = new System.Drawing.Size(356, 66);
            this.gbDataAdmissao.TabIndex = 126;
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
            this.dtpDataFinal.Size = new System.Drawing.Size(116, 27);
            this.dtpDataFinal.TabIndex = 1;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(46, 25);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(116, 27);
            this.dtpDataInicial.TabIndex = 0;
            // 
            // cbTipoRel
            // 
            this.cbTipoRel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoRel.Font = new System.Drawing.Font("Calibri", 10F);
            this.cbTipoRel.FormattingEnabled = true;
            this.cbTipoRel.Location = new System.Drawing.Point(259, 21);
            this.cbTipoRel.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoRel.Name = "cbTipoRel";
            this.cbTipoRel.Size = new System.Drawing.Size(161, 23);
            this.cbTipoRel.TabIndex = 130;
            this.cbTipoRel.SelectedIndexChanged += new System.EventHandler(this.cbTipoRel_SelectedIndexChanged);
            // 
            // gbCidade
            // 
            this.gbCidade.Controls.Add(this.cbCidade);
            this.gbCidade.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCidade.ForeColor = System.Drawing.Color.White;
            this.gbCidade.Location = new System.Drawing.Point(193, 190);
            this.gbCidade.Name = "gbCidade";
            this.gbCidade.Size = new System.Drawing.Size(175, 66);
            this.gbCidade.TabIndex = 127;
            this.gbCidade.TabStop = false;
            this.gbCidade.Text = "Cidade:";
            // 
            // cbCidade
            // 
            this.cbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCidade.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(9, 28);
            this.cbCidade.Margin = new System.Windows.Forms.Padding(4);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(153, 27);
            this.cbCidade.TabIndex = 66;
            // 
            // gbAniversariantes
            // 
            this.gbAniversariantes.BackColor = System.Drawing.Color.Transparent;
            this.gbAniversariantes.Controls.Add(this.cbMes);
            this.gbAniversariantes.ForeColor = System.Drawing.Color.White;
            this.gbAniversariantes.Location = new System.Drawing.Point(12, 117);
            this.gbAniversariantes.Name = "gbAniversariantes";
            this.gbAniversariantes.Size = new System.Drawing.Size(175, 66);
            this.gbAniversariantes.TabIndex = 125;
            this.gbAniversariantes.TabStop = false;
            this.gbAniversariantes.Text = "Aniversariantes Mês:";
            // 
            // cbMes
            // 
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Location = new System.Drawing.Point(7, 25);
            this.cbMes.Margin = new System.Windows.Forms.Padding(4);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(161, 27);
            this.cbMes.TabIndex = 78;
            // 
            // gbIdade
            // 
            this.gbIdade.Controls.Add(this.txtIdadeFinal);
            this.gbIdade.Controls.Add(this.txtIdadeInicial);
            this.gbIdade.Controls.Add(this.label13);
            this.gbIdade.Controls.Add(this.label14);
            this.gbIdade.ForeColor = System.Drawing.Color.White;
            this.gbIdade.Location = new System.Drawing.Point(555, 118);
            this.gbIdade.Name = "gbIdade";
            this.gbIdade.Size = new System.Drawing.Size(206, 66);
            this.gbIdade.TabIndex = 124;
            this.gbIdade.TabStop = false;
            this.gbIdade.Text = "Idade";
            this.gbIdade.Enter += new System.EventHandler(this.gbIdade_Enter);
            // 
            // txtIdadeFinal
            // 
            this.txtIdadeFinal.Location = new System.Drawing.Point(137, 25);
            this.txtIdadeFinal.MaxLength = 3;
            this.txtIdadeFinal.Name = "txtIdadeFinal";
            this.txtIdadeFinal.Size = new System.Drawing.Size(50, 27);
            this.txtIdadeFinal.TabIndex = 45;
            this.txtIdadeFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdadeFinal_KeyPress);
            // 
            // txtIdadeInicial
            // 
            this.txtIdadeInicial.Location = new System.Drawing.Point(46, 25);
            this.txtIdadeInicial.MaxLength = 3;
            this.txtIdadeInicial.Name = "txtIdadeInicial";
            this.txtIdadeInicial.Size = new System.Drawing.Size(50, 27);
            this.txtIdadeInicial.TabIndex = 44;
            this.txtIdadeInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdadeInicial_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 29);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 19);
            this.label13.TabIndex = 43;
            this.label13.Text = "De:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(101, 29);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 19);
            this.label14.TabIndex = 28;
            this.label14.Text = "Até:";
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.ForeColor = System.Drawing.Color.White;
            this.gbStatus.Location = new System.Drawing.Point(555, 189);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(206, 66);
            this.gbStatus.TabIndex = 122;
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
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Location = new System.Drawing.Point(14, 30);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(60, 23);
            this.rbAtivo.TabIndex = 1;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(266, 20);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(270, 29);
            this.lbTitulo.TabIndex = 65;
            this.lbTitulo.Text = "Relatório de Funcionários";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbTipoRel);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 60);
            this.groupBox1.TabIndex = 133;
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
            this.btSair.TabIndex = 132;
            this.btSair.Text = "     Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // rptvFuncionario
            // 
            reportDataSource1.Name = "DsFuncionario";
            reportDataSource1.Value = this.classFuncionarioBindingSource;
            this.rptvFuncionario.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvFuncionario.LocalReport.ReportEmbeddedResource = "SistemaDropToParadise.rptFuncionario.rdlc";
            this.rptvFuncionario.Location = new System.Drawing.Point(12, 262);
            this.rptvFuncionario.Name = "rptvFuncionario";
            this.rptvFuncionario.ServerReport.BearerToken = null;
            this.rptvFuncionario.Size = new System.Drawing.Size(744, 542);
            this.rptvFuncionario.TabIndex = 134;
            this.rptvFuncionario.Load += new System.EventHandler(this.rptvFuncionario_Load);
            // 
            // cbCargo
            // 
            this.cbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCargo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Location = new System.Drawing.Point(9, 28);
            this.cbCargo.Margin = new System.Windows.Forms.Padding(4);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(159, 27);
            this.cbCargo.TabIndex = 66;
            // 
            // gbCargo
            // 
            this.gbCargo.Controls.Add(this.cbCargo);
            this.gbCargo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCargo.ForeColor = System.Drawing.Color.White;
            this.gbCargo.Location = new System.Drawing.Point(12, 189);
            this.gbCargo.Name = "gbCargo";
            this.gbCargo.Size = new System.Drawing.Size(175, 66);
            this.gbCargo.TabIndex = 128;
            this.gbCargo.TabStop = false;
            this.gbCargo.Text = "Cargo:";
            // 
            // ClassClienteBindingSource
            // 
            this.ClassClienteBindingSource.DataSource = typeof(SistemaDropToParadise.ClassCliente);
            // 
            // formRelFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(768, 781);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.rptvFuncionario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCargo);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btGerarRelatorio);
            this.Controls.Add(this.gbSexo);
            this.Controls.Add(this.gbDataAdmissao);
            this.Controls.Add(this.gbCidade);
            this.Controls.Add(this.gbAniversariantes);
            this.Controls.Add(this.gbIdade);
            this.Controls.Add(this.gbStatus);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formRelFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formRelFuncionario";
            this.Load += new System.EventHandler(this.formRelFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classFuncionarioBindingSource)).EndInit();
            this.gbSexo.ResumeLayout(false);
            this.gbDataAdmissao.ResumeLayout(false);
            this.gbDataAdmissao.PerformLayout();
            this.gbCidade.ResumeLayout(false);
            this.gbAniversariantes.ResumeLayout(false);
            this.gbIdade.ResumeLayout(false);
            this.gbIdade.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbCargo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClassClienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btGerarRelatorio;
        private System.Windows.Forms.GroupBox gbSexo;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.GroupBox gbDataAdmissao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        public System.Windows.Forms.ComboBox cbTipoRel;
        private System.Windows.Forms.GroupBox gbCidade;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.GroupBox gbAniversariantes;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.GroupBox gbIdade;
        private System.Windows.Forms.TextBox txtIdadeFinal;
        private System.Windows.Forms.TextBox txtIdadeInicial;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSair;
        private Microsoft.Reporting.WinForms.ReportViewer rptvFuncionario;
        private System.Windows.Forms.BindingSource classFuncionarioBindingSource;
        private System.Windows.Forms.BindingSource ClassClienteBindingSource;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.GroupBox gbCargo;
    }
}