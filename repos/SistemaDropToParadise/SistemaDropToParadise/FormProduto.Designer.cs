
namespace SistemaDropToParadise
{
    partial class FormProduto
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbDataCadastro = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.txtLucro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtVenda = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.gbPromocao = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPromoFinal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rbPromocaoSim = new System.Windows.Forms.RadioButton();
            this.rbPromocaoNao = new System.Windows.Forms.RadioButton();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btcadastrar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.ckStatus = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbPromocao.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.White;
            this.lbTitulo.Location = new System.Drawing.Point(514, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(241, 24);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Cadastro de Produtos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbDataCadastro);
            this.groupBox2.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(258, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 66);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "*Data Cadastro:";
            // 
            // lbDataCadastro
            // 
            this.lbDataCadastro.AutoSize = true;
            this.lbDataCadastro.ForeColor = System.Drawing.Color.White;
            this.lbDataCadastro.Location = new System.Drawing.Point(14, 28);
            this.lbDataCadastro.Name = "lbDataCadastro";
            this.lbDataCadastro.Size = new System.Drawing.Size(37, 15);
            this.lbDataCadastro.TabIndex = 51;
            this.lbDataCadastro.Text = "Data";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.cbMarca);
            this.groupBox4.Controls.Add(this.cbCategoria);
            this.groupBox4.Controls.Add(this.txtCusto);
            this.groupBox4.Controls.Add(this.txtLucro);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtQuantidade);
            this.groupBox4.Controls.Add(this.txtVenda);
            this.groupBox4.Controls.Add(this.txtNome);
            this.groupBox4.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(6, 149);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(614, 258);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dados do Produto:";
            // 
            // cbMarca
            // 
            this.cbMarca.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(309, 124);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(298, 23);
            this.cbMarca.TabIndex = 50;
            // 
            // cbCategoria
            // 
            this.cbCategoria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(7, 124);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(298, 23);
            this.cbCategoria.TabIndex = 49;
            // 
            // txtCusto
            // 
            this.txtCusto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCusto.Location = new System.Drawing.Point(6, 205);
            this.txtCusto.Multiline = true;
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(138, 26);
            this.txtCusto.TabIndex = 46;
            this.txtCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCusto_KeyPress);
            // 
            // txtLucro
            // 
            this.txtLucro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtLucro.Location = new System.Drawing.Point(165, 205);
            this.txtLucro.Multiline = true;
            this.txtLucro.Name = "txtLucro";
            this.txtLucro.Size = new System.Drawing.Size(138, 26);
            this.txtLucro.TabIndex = 45;
            this.txtLucro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLucro_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 44;
            this.label3.Text = "*Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 43;
            this.label2.Text = "*Nome do Produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(308, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "*Marca:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(466, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 41;
            this.label8.Text = "*Qntd:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(308, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 15);
            this.label7.TabIndex = 40;
            this.label7.Text = "*Preço de Venda:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(162, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "*% de Lucro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "*Preço de Custo:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtQuantidade.Location = new System.Drawing.Point(469, 205);
            this.txtQuantidade.Multiline = true;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(138, 26);
            this.txtQuantidade.TabIndex = 9;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // txtVenda
            // 
            this.txtVenda.Enabled = false;
            this.txtVenda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtVenda.Location = new System.Drawing.Point(311, 205);
            this.txtVenda.Multiline = true;
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.Size = new System.Drawing.Size(138, 26);
            this.txtVenda.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNome.Location = new System.Drawing.Point(6, 52);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(602, 31);
            this.txtNome.TabIndex = 3;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Enabled = false;
            this.txtDesconto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDesconto.Location = new System.Drawing.Point(190, 35);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(120, 22);
            this.txtDesconto.TabIndex = 3;
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
            this.txtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesconto_KeyPress);
            // 
            // gbPromocao
            // 
            this.gbPromocao.Controls.Add(this.label10);
            this.gbPromocao.Controls.Add(this.txtPromoFinal);
            this.gbPromocao.Controls.Add(this.label9);
            this.gbPromocao.Controls.Add(this.rbPromocaoSim);
            this.gbPromocao.Controls.Add(this.rbPromocaoNao);
            this.gbPromocao.Controls.Add(this.txtDesconto);
            this.gbPromocao.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPromocao.ForeColor = System.Drawing.Color.White;
            this.gbPromocao.Location = new System.Drawing.Point(639, 65);
            this.gbPromocao.Name = "gbPromocao";
            this.gbPromocao.Size = new System.Drawing.Size(616, 66);
            this.gbPromocao.TabIndex = 10;
            this.gbPromocao.TabStop = false;
            this.gbPromocao.Text = "*Promoção:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(460, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 15);
            this.label10.TabIndex = 47;
            this.label10.Text = "Preço com Promoção:";
            // 
            // txtPromoFinal
            // 
            this.txtPromoFinal.Enabled = false;
            this.txtPromoFinal.Location = new System.Drawing.Point(463, 35);
            this.txtPromoFinal.Name = "txtPromoFinal";
            this.txtPromoFinal.Size = new System.Drawing.Size(120, 22);
            this.txtPromoFinal.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(187, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 15);
            this.label9.TabIndex = 45;
            this.label9.Text = "% de Desconto:";
            // 
            // rbPromocaoSim
            // 
            this.rbPromocaoSim.AutoSize = true;
            this.rbPromocaoSim.ForeColor = System.Drawing.Color.White;
            this.rbPromocaoSim.Location = new System.Drawing.Point(15, 41);
            this.rbPromocaoSim.Name = "rbPromocaoSim";
            this.rbPromocaoSim.Size = new System.Drawing.Size(52, 19);
            this.rbPromocaoSim.TabIndex = 36;
            this.rbPromocaoSim.Text = "Sim";
            this.rbPromocaoSim.UseVisualStyleBackColor = true;
            this.rbPromocaoSim.CheckedChanged += new System.EventHandler(this.rbPromocaoSim_CheckedChanged);
            // 
            // rbPromocaoNao
            // 
            this.rbPromocaoNao.AutoSize = true;
            this.rbPromocaoNao.Checked = true;
            this.rbPromocaoNao.ForeColor = System.Drawing.Color.White;
            this.rbPromocaoNao.Location = new System.Drawing.Point(16, 19);
            this.rbPromocaoNao.Name = "rbPromocaoNao";
            this.rbPromocaoNao.Size = new System.Drawing.Size(51, 19);
            this.rbPromocaoNao.TabIndex = 35;
            this.rbPromocaoNao.TabStop = true;
            this.rbPromocaoNao.Text = "Não";
            this.rbPromocaoNao.UseVisualStyleBackColor = true;
            this.rbPromocaoNao.CheckedChanged += new System.EventHandler(this.rbPromocaoNao_CheckedChanged_1);
            // 
            // btAtualizar
            // 
            this.btAtualizar.BackColor = System.Drawing.Color.White;
            this.btAtualizar.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btAtualizar.Location = new System.Drawing.Point(545, 464);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(91, 43);
            this.btAtualizar.TabIndex = 32;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = false;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // btcadastrar
            // 
            this.btcadastrar.BackColor = System.Drawing.Color.White;
            this.btcadastrar.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcadastrar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btcadastrar.Location = new System.Drawing.Point(326, 464);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(91, 43);
            this.btcadastrar.TabIndex = 31;
            this.btcadastrar.Text = "Cadastrar";
            this.btcadastrar.UseVisualStyleBackColor = false;
            this.btcadastrar.Click += new System.EventHandler(this.btcadastrar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(432, 419);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(406, 42);
            this.label12.TabIndex = 48;
            this.label12.Text = "Todos os Campos Com * são Obrigatórios!\r\n\r\n";
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.ckStatus);
            this.gbStatus.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStatus.ForeColor = System.Drawing.Color.White;
            this.gbStatus.Location = new System.Drawing.Point(450, 65);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(170, 66);
            this.gbStatus.TabIndex = 24;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "*Status";
            // 
            // ckStatus
            // 
            this.ckStatus.AutoSize = true;
            this.ckStatus.Checked = true;
            this.ckStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckStatus.Enabled = false;
            this.ckStatus.Location = new System.Drawing.Point(25, 28);
            this.ckStatus.Name = "ckStatus";
            this.ckStatus.Size = new System.Drawing.Size(65, 19);
            this.ckStatus.TabIndex = 0;
            this.ckStatus.Text = "Ativo";
            this.ckStatus.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDescricao);
            this.groupBox3.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(639, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(616, 121);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDescricao.Location = new System.Drawing.Point(6, 19);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(604, 88);
            this.txtDescricao.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(935, 465);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 43);
            this.button4.TabIndex = 50;
            this.button4.Text = "sair";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.White;
            this.btExcluir.Enabled = false;
            this.btExcluir.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btExcluir.Location = new System.Drawing.Point(731, 465);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(91, 43);
            this.btExcluir.TabIndex = 49;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtObservacao);
            this.groupBox7.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(639, 286);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(616, 121);
            this.groupBox7.TabIndex = 49;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Observação:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtObservacao.Location = new System.Drawing.Point(6, 19);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(604, 88);
            this.txtObservacao.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigoProduto);
            this.groupBox1.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(15, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 65);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "*Código Produto:";
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.BackColor = System.Drawing.Color.White;
            this.txtCodigoProduto.Enabled = false;
            this.txtCodigoProduto.Location = new System.Drawing.Point(6, 28);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(162, 21);
            this.txtCodigoProduto.TabIndex = 2;
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1268, 514);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btcadastrar);
            this.Controls.Add(this.gbPromocao);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProduto";
            this.Text = "FormProduto";
            this.Load += new System.EventHandler(this.FormProduto_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbPromocao.ResumeLayout(false);
            this.gbPromocao.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox gbPromocao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btcadastrar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lbDataCadastro;
        public System.Windows.Forms.TextBox txtQuantidade;
        public System.Windows.Forms.TextBox txtVenda;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtDesconto;
        public System.Windows.Forms.RadioButton rbPromocaoSim;
        public System.Windows.Forms.RadioButton rbPromocaoNao;
        public System.Windows.Forms.TextBox txtCusto;
        public System.Windows.Forms.TextBox txtLucro;
        public System.Windows.Forms.TextBox txtPromoFinal;
        public System.Windows.Forms.TextBox txtDescricao;
        public System.Windows.Forms.TextBox txtObservacao;
        public System.Windows.Forms.ComboBox cbMarca;
        public System.Windows.Forms.ComboBox cbCategoria;
        public System.Windows.Forms.TextBox txtCodigoProduto;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.CheckBox ckStatus;
    }
}