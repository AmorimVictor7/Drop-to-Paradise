using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDropToParadise
{
    public partial class formVenda49 : Form
    {
        public formVenda49()
        {
            InitializeComponent();
        }

        //CRIAR A LISTA QUE SERÁ USADA NA GRID DE PRODUTOS VENDIDOS QUE SERÁ COMO BASE A CLASSE DE ITENSVENDA
        private List<classItensVenda> ListaItensVenda = new List<classItensVenda>();

        //VARIÁVEL PATA CALCULAR VALOR TOTAL DA VENDA 
        private decimal VendaTotal = 0;

        //VARIÁVEL PARA CONTAR QUANTAS LINHAS FORAM ADICIONADAS NA GRID DE VENDA 
        private int ItensVenda = 0;
        private void formVenda49_Load(object sender, EventArgs e)
        {
            //CARREGAR DATA DA VENDA
            txtDataVenda.Text = DateTime.Now.ToShortDateString();

            //COMBO FORMA DE PAGAMENTO
            cbFormaPagamento.Items.Add("Cartão de Crédito");
            cbFormaPagamento.Items.Add("Cartão de Débito");
            cbFormaPagamento.Items.Add("Dinheiro");
            cbFormaPagamento.Items.Add("Pix");
          
            cbFormaPagamento.SelectedIndex = -1;
            cbFormaPagamento.SelectedItem = "Pix";

            classFuncionario cfuncionario = new classFuncionario();
            //CHAMAR MÉTODO NA COMBO
            cbFuncionario.DataSource = cfuncionario.BuscarFuncionario();
            //MOSTRAR NA COMBO A LISTA DE CARGOS - NOME - O QUE VOU EXIBIR NA COMBO
            cbFuncionario.DisplayMember = "nome";
            //VALOR ARMAZENADO PELA TABELA FUNCIONÁRIO - CÓDIGO
            cbFuncionario.ValueMember = "codigo_funcionario";
            cbFuncionario.SelectedIndex = -1;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?", "Sistema Loja de Cosméticos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btBuscaCliente_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtPesqCliente.Text))
            {
                MessageBox.Show("Favor informar um clique", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ClassCliente cCliente = new ClassCliente();
                dgvCliente.DataSource = cCliente.CarregaGridCliente(txtPesqCliente.Text);
            }
        }

        private void btBuscaProduto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesqProduto.Text))
            {
                MessageBox.Show("Favor informar um clique", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                ClassProduto cProduto = new ClassProduto();
                dgvProduto.DataSource = cProduto.CarregaGridProduto(txtPesqProduto.Text);
            }
        }

        private void txtQtde_TextChanged(object sender, EventArgs e)
        {
            if (txtQtde.Text == "" || txtQtde.Text == "0")
            {
                MessageBox.Show("Favor informar uma quantidade", "Sistema Loja drop to paradise", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQtde.Text = "01";
                txtQtde.SelectAll();
            }

            int qtdevendida = Convert.ToInt32(txtQtde.Text);
            int qtdestoque = Convert.ToInt32(txtQtdeEstoque.Text);

            if (qtdevendida > qtdestoque)
            {
                MessageBox.Show("A quantidade disponível no estoque é de " + qtdestoque + " unidades!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQtde.Text = "01";
                txtQtde.SelectAll();
            }
            else
            {
                qtdevendida = Convert.ToInt32(txtQtde.Text);
                decimal valor = Convert.ToDecimal(txtValor.Text);
                txtTotal.Text = (qtdevendida * valor).ToString();
            }

        }

       

  

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassProduto cProduto = new ClassProduto();

            bool resp = cProduto.ConsultaProduto(Convert.ToInt32(dgvProduto.SelectedRows[0].Cells[0].Value));

            if (resp == true)
            {
                txtProduto.Text = cProduto.nome_produto;
                txtQtdeEstoque.Text = cProduto.quantidade.ToString();
                txtValor.Text = cProduto.preco_venda.ToString("n2");
                txtQtde.Text = "01";
                txtQtde_TextChanged(this, new EventArgs());
                txtQtde.Select();
            }
        }

    

      private void AtualizarGrid()
        {
            //INSTANCIAR CLASSE PRODUTO PARA PEGAR MÉTODO QUE TRAZ O NOME DO PRODUTO
            ClassProduto cProduto = new ClassProduto();

            //CRIAR UMA TABELA TEMPORÁRIA
            DataTable dt = new DataTable();

            // CRIAR AS COLUNAS DA GRID
            dt.Columns.Add(new DataColumn("Código"));
            dt.Columns.Add(new DataColumn("Produto"));
            dt.Columns.Add(new DataColumn("Quantidade"));
            dt.Columns.Add(new DataColumn("Valor"));

            foreach (classItensVenda item in ListaItensVenda)
            {
                dt.Rows.Add(item.codigo_produto, cProduto.BuscaNomaProd(item.codigo_produto), item.quantidade, item.preco);
                dt.AcceptChanges();
            }

            dgvItens.DataSource = dt;
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            classItensVenda cItensVenda = new classItensVenda();

            decimal ValorItem = 0;

            if (txtTotal.Text == "")
            {
                MessageBox.Show("Não há produto para ser inserido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                cItensVenda.codigo_produto = Convert.ToInt32(dgvProduto.SelectedRows[0].Cells[0].Value);
                cItensVenda.quantidade = Convert.ToInt32(txtQtde.Text);
                cItensVenda.preco = Convert.ToDecimal(txtTotal.Text);

                ValorItem = Convert.ToDecimal(txtTotal.Text);
                VendaTotal = VendaTotal + ValorItem;
                txtValorTotal.Text = VendaTotal.ToString("n2");

                //CONTAR ITENS DA VENDA (QTDE DE LINHAS DA GRID)
                ItensVenda++;

                ListaItensVenda.Add(cItensVenda);

                //PEGAR DA LISTA A QUANTIDADE DE ITENS
                txtQtdeItens.Text = ItensVenda.ToString();
                txtQtdeItens.Text = ListaItensVenda.Count.ToString();

                //ADICIONAR NA LISTA
               

                //CHAMAR MÉTODO QUE CRIA A GRID DE PRODUTOS VENDIDOS
                AtualizarGrid();

                //LIMPAR OS CAMPOS DE PRODUTO APÓS ADICIONAR
                txtProduto.Clear();
                txtQtde.Text = "01";
                txtTotal.Clear();
                txtQtdeEstoque.Clear();
                txtPercentualDesconto_TextChanged(this, new EventArgs());
                txtPercentualDesconto.Select();
            }
        }

        private void CalculaEstoque(int qtde, int cod)
        {
            ClassProduto cProduto = new ClassProduto();
            cProduto.ConsultaProduto(cod);
            int quantidade = cProduto.quantidade;
            cProduto.AtualizarEstoque(quantidade - qtde, cod);
        }

        private void Limpar()
        {
            cbFuncionario.SelectedIndex = -1;
            txtPesqCliente.Clear();
            txtPesqProduto.Clear();
            dgvCliente.DataSource = null;
            txtPesqCliente.Clear();
            dgvProduto.DataSource = null;

            ListaItensVenda.Clear();
            AtualizarGrid();
            dgvItens.Refresh();

            txtValorTotal.Text = "0";
            txtTotalVenda.Text = "0";
            txtPercentualDesconto.Text = "0";
            txtTotalDesconto.Text = "0";
            txtValor.Text = "0";
            txtTotalPago.Text = "0";
            txtTroco.Text = "0";

            txtQtdeItens.Clear();
            cbFormaPagamento.SelectedIndex = -1;
            VendaTotal = 0;
        }

        private void camposObrigatorios()
        {
            gbFuncionario.BackColor = Color.Lavender;
            gbClientes.BackColor = Color.Lavender;
            gbProdutos.BackColor = Color.Lavender;
            gbItensVenda.BackColor = Color.Lavender;
            lbFormaPagamento.BackColor = Color.Lavender;
        }

        private void btFechaVenda_Click(object sender, EventArgs e)
        {
            // Verifica os campos obrigatórios básicos
            if (cbFuncionario.SelectedIndex != -1 &&
                dgvCliente.DataSource != null &&
                dgvItens.DataSource != null &&
                cbFormaPagamento.SelectedIndex != -1)
            {
                // Converte o valor total da venda
                bool totalVendaOk = decimal.TryParse(txtTotalVenda.Text, out decimal valorTotal);

                if (!totalVendaOk)
                {
                    MessageBox.Show("Valor total da venda inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Verificação se a forma de pagamento é DINHEIRO
                if (cbFormaPagamento.SelectedItem.ToString().ToLower().Contains("dinheiro"))
                {
                    // Verifica se o campo TotalPago está preenchido
                    if (string.IsNullOrWhiteSpace(txtTotalPago.Text))
                    {
                        MessageBox.Show("Informe o valor pago pelo cliente.", "Pagamento em Dinheiro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Tenta converter o valor pago
                    bool valorPagoOk = decimal.TryParse(txtTotalPago.Text, out decimal valorPago);

                    if (!valorPagoOk)
                    {
                        MessageBox.Show("Valor pago inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Verifica se o valor pago é menor que o total
                    if (valorPago < valorTotal)
                    {
                        MessageBox.Show("O valor pago é menor que o total da venda. Não é possível concluir a venda.", "Pagamento Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Calcula e exibe o troco
                    decimal troco = valorPago - valorTotal;
                    txtTroco.Text = troco.ToString("F2");
                }

                // CONTINUA O PROCESSO DE VENDA
                classVendas cVenda = new classVendas();

                cVenda.preco_final = valorTotal;
                cVenda.desconto = Convert.ToDecimal(txtTotalDesconto.Text);
                cVenda.forma_pagamento = cbFormaPagamento.SelectedItem.ToString();
                cVenda.codigo_cliente = Convert.ToInt32(dgvCliente.SelectedRows[0].Cells[0].Value);
                cVenda.codigo_funcionario = Convert.ToInt32(cbFuncionario.SelectedValue);

                bool resp = cVenda.CadastrarVenda();

                if (resp == true)
                {
                    foreach (classItensVenda item in ListaItensVenda)
                    {
                        item.codigo_venda = cVenda.codigo_venda;
                        resp = item.CadastrarItensVenda();

                        CalculaEstoque(item.quantidade, item.codigo_produto);
                    }

                    if (resp == true)
                    {
                        MessageBox.Show("Venda realizada com Sucesso", "Sistema Drop to Paradise", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpar();
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao realizar venda", "Sistema Drop to Paradise", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Favor preencher todos os campos", "Sistema Drop to Paradise", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                camposObrigatorios();
            }
        }


        private void btRemover_Click(object sender, EventArgs e)
        {
            if (dgvItens.Rows.Count > 0)
            {
                if(MessageBox.Show("Deseja Remover o Produto Selecionado?", "Sistema Drop to Paradise", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    decimal valor = Convert.ToDecimal(dgvItens.SelectedRows[0].Cells[3].Value);
                    VendaTotal = VendaTotal - valor;
                    txtTotalVenda.Text = VendaTotal.ToString();
                    txtValorTotal.Text = VendaTotal.ToString();

                    ListaItensVenda.RemoveAt(dgvItens.CurrentRow.Index);
                    AtualizarGrid();

                    txtQtdeItens.Text = ListaItensVenda.Count.ToString();
                    txtPercentualDesconto_TextChanged(this, new EventArgs());

                }
            }
            else
            {
                MessageBox.Show("Não há produtos para ser removido", "Sistema Drop to Paradise", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Sistema Drop to Paradise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtPercentualDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Sistema Drop to Paradise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool atualizandoCampos = false;
        private void txtPercentualDesconto_TextChanged(object sender, EventArgs e)
        {
            if (atualizandoCampos) return;


            atualizandoCampos = true;

            if (decimal.TryParse(txtValorTotal.Text, out decimal valorTotal) &&
                decimal.TryParse(txtPercentualDesconto.Text, out decimal percentual))
            {
                // Limita percentual entre 0 e 100
                if (percentual < 0) percentual = 0;
                if (percentual > 100) percentual = 100;

                // Calcula desconto com 2 casas decimais
                decimal valorDesconto = Math.Round((percentual / 100m) * valorTotal, 2);

                txtTotalDesconto.Text = valorDesconto.ToString("N2");

                decimal totalComDesconto = valorTotal - valorDesconto;
                txtTotalVenda.Text = totalComDesconto.ToString("N2");
            }
            else
            {
                txtTotalDesconto.Text = "0,00";
                txtTotalVenda.Text = txtValorTotal.Text;
            }

            atualizandoCampos = false;
        }

        private void cbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(cbFormaPagamento.Text == "Cartão de Crédito")
           {
                label1.Visible = false; 
                txtTotalPago.Visible = false;
                label20.Visible = false;
                txtTroco.Visible = false;

           }


            if (cbFormaPagamento.Text == "Cartão de Débito")
            {
                label1.Visible = false;
                txtTotalPago.Visible = false;
                label20.Visible = false;
                txtTroco.Visible = false;

            }


            if (cbFormaPagamento.Text == "Dinheiro")
            {
                label1.Visible = true;
                txtTotalPago.Visible = true;
                label20.Visible = true;
                txtTroco.Visible = true;

            }


            if (cbFormaPagamento.Text == "Pix")
            {
                label1.Visible = false;
                txtTotalPago.Visible = false;
                label20.Visible = false;
                txtTroco.Visible = false;

            }

        }



        private void txtTotalPago_TextChanged(object sender, EventArgs e)
        {
            // Se quiser atualizar o troco dinamicamente, pode usar este bloco opcional:
            if (decimal.TryParse(txtValorTotal.Text, out decimal valorTotal) &&
                decimal.TryParse(txtTotalPago.Text, out decimal valorPago))
            {
                decimal troco = Math.Max(0, valorPago - valorTotal);
                txtTroco.Text = troco.ToString("F2");
            }
            else
            {
                txtTroco.Text = "0,00";
            }
        }

        private void cbFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTroco_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
