
namespace SistemaDropToParadise
{
    partial class formConsProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbConsCliente = new System.Windows.Forms.GroupBox();
            this.gbPromocao = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbCom = new System.Windows.Forms.RadioButton();
            this.gbQuantidade = new System.Windows.Forms.GroupBox();
            this.dtpMax = new System.Windows.Forms.TextBox();
            this.dtpMin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.gbMarca = new System.Windows.Forms.GroupBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbInativo = new System.Windows.Forms.RadioButton();
            this.rbAtivo = new System.Windows.Forms.RadioButton();
            this.gbOpcao = new System.Windows.Forms.GroupBox();
            this.cbOpcoes = new System.Windows.Forms.ComboBox();
            this.btSair = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.gbNome = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gbTipoPesquisa = new System.Windows.Forms.GroupBox();
            this.rbContem = new System.Windows.Forms.RadioButton();
            this.rbInicio = new System.Windows.Forms.RadioButton();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.gbConsCliente.SuspendLayout();
            this.gbPromocao.SuspendLayout();
            this.gbQuantidade.SuspendLayout();
            this.gbCategoria.SuspendLayout();
            this.gbMarca.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.gbOpcao.SuspendLayout();
            this.gbNome.SuspendLayout();
            this.gbTipoPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.Transparent;
            this.lbTitulo.Location = new System.Drawing.Point(129, 18);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(218, 29);
            this.lbTitulo.TabIndex = 65;
            this.lbTitulo.Text = "Consulta de Produto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(536, 24);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(436, 23);
            this.label10.TabIndex = 100;
            this.label10.Text = "Para alterar ou excluir  um cliente, selecione na grid!!!";
            // 
            // gbConsCliente
            // 
            this.gbConsCliente.Controls.Add(this.gbPromocao);
            this.gbConsCliente.Controls.Add(this.gbQuantidade);
            this.gbConsCliente.Controls.Add(this.gbCategoria);
            this.gbConsCliente.Controls.Add(this.gbMarca);
            this.gbConsCliente.Controls.Add(this.gbStatus);
            this.gbConsCliente.Controls.Add(this.gbOpcao);
            this.gbConsCliente.Controls.Add(this.btSair);
            this.gbConsCliente.Controls.Add(this.btPesquisar);
            this.gbConsCliente.Controls.Add(this.gbNome);
            this.gbConsCliente.Controls.Add(this.gbTipoPesquisa);
            this.gbConsCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsCliente.Location = new System.Drawing.Point(26, 40);
            this.gbConsCliente.Name = "gbConsCliente";
            this.gbConsCliente.Size = new System.Drawing.Size(408, 415);
            this.gbConsCliente.TabIndex = 55;
            this.gbConsCliente.TabStop = false;
            // 
            // gbPromocao
            // 
            this.gbPromocao.Controls.Add(this.radioButton1);
            this.gbPromocao.Controls.Add(this.rbCom);
            this.gbPromocao.ForeColor = System.Drawing.Color.White;
            this.gbPromocao.Location = new System.Drawing.Point(6, 291);
            this.gbPromocao.Name = "gbPromocao";
            this.gbPromocao.Size = new System.Drawing.Size(180, 60);
            this.gbPromocao.TabIndex = 103;
            this.gbPromocao.TabStop = false;
            this.gbPromocao.Text = "Promoção:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(89, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 23);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.Text = "Sem";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbCom
            // 
            this.rbCom.AutoSize = true;
            this.rbCom.Checked = true;
            this.rbCom.Location = new System.Drawing.Point(12, 25);
            this.rbCom.Name = "rbCom";
            this.rbCom.Size = new System.Drawing.Size(56, 23);
            this.rbCom.TabIndex = 1;
            this.rbCom.TabStop = true;
            this.rbCom.Text = "Com";
            this.rbCom.UseVisualStyleBackColor = true;
            // 
            // gbQuantidade
            // 
            this.gbQuantidade.Controls.Add(this.dtpMax);
            this.gbQuantidade.Controls.Add(this.dtpMin);
            this.gbQuantidade.Controls.Add(this.label6);
            this.gbQuantidade.Controls.Add(this.label8);
            this.gbQuantidade.ForeColor = System.Drawing.Color.White;
            this.gbQuantidade.Location = new System.Drawing.Point(6, 224);
            this.gbQuantidade.Name = "gbQuantidade";
            this.gbQuantidade.Size = new System.Drawing.Size(387, 60);
            this.gbQuantidade.TabIndex = 115;
            this.gbQuantidade.TabStop = false;
            this.gbQuantidade.Text = "Quantidade:";
            // 
            // dtpMax
            // 
            this.dtpMax.Location = new System.Drawing.Point(232, 26);
            this.dtpMax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpMax.MaxLength = 50;
            this.dtpMax.Name = "dtpMax";
            this.dtpMax.Size = new System.Drawing.Size(143, 27);
            this.dtpMax.TabIndex = 47;
            this.dtpMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpMax_KeyPress);
            // 
            // dtpMin
            // 
            this.dtpMin.Location = new System.Drawing.Point(37, 26);
            this.dtpMin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpMin.MaxLength = 50;
            this.dtpMin.Name = "dtpMin";
            this.dtpMin.Size = new System.Drawing.Size(143, 27);
            this.dtpMin.TabIndex = 1;
            this.dtpMin.TextChanged += new System.EventHandler(this.dtpMin_TextChanged);
            this.dtpMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpMin_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(188, 29);
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
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.cbCategoria);
            this.gbCategoria.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCategoria.ForeColor = System.Drawing.Color.White;
            this.gbCategoria.Location = new System.Drawing.Point(211, 158);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Size = new System.Drawing.Size(184, 60);
            this.gbCategoria.TabIndex = 105;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "Categoria:";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(12, 23);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(164, 27);
            this.cbCategoria.TabIndex = 50;
            // 
            // gbMarca
            // 
            this.gbMarca.Controls.Add(this.cbMarca);
            this.gbMarca.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMarca.ForeColor = System.Drawing.Color.White;
            this.gbMarca.Location = new System.Drawing.Point(6, 158);
            this.gbMarca.Name = "gbMarca";
            this.gbMarca.Size = new System.Drawing.Size(180, 60);
            this.gbMarca.TabIndex = 112;
            this.gbMarca.TabStop = false;
            this.gbMarca.Text = "Marca:";
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(6, 23);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(168, 27);
            this.cbMarca.TabIndex = 50;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbInativo);
            this.gbStatus.Controls.Add(this.rbAtivo);
            this.gbStatus.ForeColor = System.Drawing.Color.White;
            this.gbStatus.Location = new System.Drawing.Point(211, 291);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(182, 60);
            this.gbStatus.TabIndex = 102;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status:";
            // 
            // rbInativo
            // 
            this.rbInativo.AutoSize = true;
            this.rbInativo.Location = new System.Drawing.Point(91, 25);
            this.rbInativo.Name = "rbInativo";
            this.rbInativo.Size = new System.Drawing.Size(71, 23);
            this.rbInativo.TabIndex = 2;
            this.rbInativo.Text = "Inativo";
            this.rbInativo.UseVisualStyleBackColor = true;
            // 
            // rbAtivo
            // 
            this.rbAtivo.AutoSize = true;
            this.rbAtivo.Checked = true;
            this.rbAtivo.Location = new System.Drawing.Point(12, 25);
            this.rbAtivo.Name = "rbAtivo";
            this.rbAtivo.Size = new System.Drawing.Size(60, 23);
            this.rbAtivo.TabIndex = 1;
            this.rbAtivo.TabStop = true;
            this.rbAtivo.Text = "Ativo";
            this.rbAtivo.UseVisualStyleBackColor = true;
            // 
            // gbOpcao
            // 
            this.gbOpcao.Controls.Add(this.cbOpcoes);
            this.gbOpcao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpcao.ForeColor = System.Drawing.Color.White;
            this.gbOpcao.Location = new System.Drawing.Point(6, 26);
            this.gbOpcao.Name = "gbOpcao";
            this.gbOpcao.Size = new System.Drawing.Size(387, 60);
            this.gbOpcao.TabIndex = 4;
            this.gbOpcao.TabStop = false;
            this.gbOpcao.Text = "Escolha uma Opção de Consulta:";
            // 
            // cbOpcoes
            // 
            this.cbOpcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpcoes.FormattingEnabled = true;
            this.cbOpcoes.Location = new System.Drawing.Point(6, 26);
            this.cbOpcoes.Name = "cbOpcoes";
            this.cbOpcoes.Size = new System.Drawing.Size(375, 27);
            this.cbOpcoes.TabIndex = 8;
            this.cbOpcoes.SelectedIndexChanged += new System.EventHandler(this.cbOpcoes_SelectedIndexChanged);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.White;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSair.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSair.Location = new System.Drawing.Point(223, 357);
            this.btSair.Name = "btSair";
            this.btSair.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btSair.Size = new System.Drawing.Size(133, 50);
            this.btSair.TabIndex = 108;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.BackColor = System.Drawing.Color.White;
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btPesquisar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPesquisar.Location = new System.Drawing.Point(43, 357);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btPesquisar.Size = new System.Drawing.Size(133, 50);
            this.btPesquisar.TabIndex = 111;
            this.btPesquisar.Text = "     Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = false;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // gbNome
            // 
            this.gbNome.Controls.Add(this.txtNome);
            this.gbNome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNome.ForeColor = System.Drawing.Color.White;
            this.gbNome.Location = new System.Drawing.Point(170, 92);
            this.gbNome.Name = "gbNome";
            this.gbNome.Size = new System.Drawing.Size(223, 60);
            this.gbNome.TabIndex = 0;
            this.gbNome.TabStop = false;
            this.gbNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 25);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(203, 27);
            this.txtNome.TabIndex = 0;
            // 
            // gbTipoPesquisa
            // 
            this.gbTipoPesquisa.Controls.Add(this.rbContem);
            this.gbTipoPesquisa.Controls.Add(this.rbInicio);
            this.gbTipoPesquisa.ForeColor = System.Drawing.Color.White;
            this.gbTipoPesquisa.Location = new System.Drawing.Point(6, 92);
            this.gbTipoPesquisa.Name = "gbTipoPesquisa";
            this.gbTipoPesquisa.Size = new System.Drawing.Size(158, 60);
            this.gbTipoPesquisa.TabIndex = 102;
            this.gbTipoPesquisa.TabStop = false;
            this.gbTipoPesquisa.Text = "Tipo de Pesquisa:";
            // 
            // rbContem
            // 
            this.rbContem.AutoSize = true;
            this.rbContem.Location = new System.Drawing.Point(71, 27);
            this.rbContem.Name = "rbContem";
            this.rbContem.Size = new System.Drawing.Size(77, 23);
            this.rbContem.TabIndex = 2;
            this.rbContem.Text = "Contém";
            this.rbContem.UseVisualStyleBackColor = true;
            // 
            // rbInicio
            // 
            this.rbInicio.AutoSize = true;
            this.rbInicio.Checked = true;
            this.rbInicio.Location = new System.Drawing.Point(6, 27);
            this.rbInicio.Name = "rbInicio";
            this.rbInicio.Size = new System.Drawing.Size(62, 23);
            this.rbInicio.TabIndex = 1;
            this.rbInicio.TabStop = true;
            this.rbInicio.Text = "Início";
            this.rbInicio.UseVisualStyleBackColor = true;
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.AllowUserToResizeColumns = false;
            this.dgvProduto.AllowUserToResizeRows = false;
            this.dgvProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduto.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduto.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduto.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvProduto.Location = new System.Drawing.Point(452, 49);
            this.dgvProduto.MultiSelect = false;
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.RowHeadersVisible = false;
            this.dgvProduto.RowHeadersWidth = 51;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(609, 406);
            this.dgvProduto.TabIndex = 57;
            this.dgvProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduto_CellClick);
            // 
            // formConsProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1065, 463);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gbConsCliente);
            this.Controls.Add(this.dgvProduto);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formConsProduto";
            this.Text = "formConsProduto";
            this.Load += new System.EventHandler(this.formConsProduto_Load);
            this.gbConsCliente.ResumeLayout(false);
            this.gbPromocao.ResumeLayout(false);
            this.gbPromocao.PerformLayout();
            this.gbQuantidade.ResumeLayout(false);
            this.gbQuantidade.PerformLayout();
            this.gbCategoria.ResumeLayout(false);
            this.gbMarca.ResumeLayout(false);
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbOpcao.ResumeLayout(false);
            this.gbNome.ResumeLayout(false);
            this.gbNome.PerformLayout();
            this.gbTipoPesquisa.ResumeLayout(false);
            this.gbTipoPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbConsCliente;
        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.GroupBox gbMarca;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbInativo;
        private System.Windows.Forms.RadioButton rbAtivo;
        private System.Windows.Forms.GroupBox gbOpcao;
        private System.Windows.Forms.ComboBox cbOpcoes;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.GroupBox gbNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gbTipoPesquisa;
        private System.Windows.Forms.RadioButton rbContem;
        private System.Windows.Forms.RadioButton rbInicio;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.GroupBox gbQuantidade;
        private System.Windows.Forms.TextBox dtpMax;
        private System.Windows.Forms.TextBox dtpMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbPromocao;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbCom;
    }
}