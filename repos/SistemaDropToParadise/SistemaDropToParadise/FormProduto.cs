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
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            //EVENTOS PARA CALCULAR PRECO DE VENDA AUTOMATICO
            txtCusto.TextChanged += (s, e) => CalcularPrecoVenda();
            txtLucro.TextChanged += (s, e) => CalcularPrecoVenda();
        }

        //VARIAVEIS GLOBAISS
        public string tipo;
        public int marca;
        public int categoria;
        public DateTime data_cad;

        private void FormProduto_Load(object sender, EventArgs e)
        {
            classCategoria cCategoria = new classCategoria();
            cbCategoria.DataSource = cCategoria.BuscarCategoria();
            cbCategoria.DisplayMember = "nome_categoria";
            cbCategoria.ValueMember = "codigo_categoria";
            cbCategoria.SelectedIndex = -1;

            ClassMarca cMarca = new ClassMarca();
            cbMarca.DataSource = cMarca.BuscarMarca();
            cbMarca.DisplayMember = "nome_marca";
            cbMarca.ValueMember = "codigo_marca";
            cbMarca.SelectedIndex = -1;

            //IF PARA QUE QUANDO FOR FAZER A CONSULTA O USUARIO TENHA A OPCAO DE ATUALIZAR CLICANDO NO PRODUTO E INDO PARA A ATUALIZACAO IGUAL A TELA DE CADASTRO MAS COM AS INFORMACOES JA FEITAS
            if (tipo == "Atualização")
            {
                lbDataCadastro.Text = data_cad.ToString();
                ckStatus.Enabled = true;
                lbTitulo.Text = "Atualização de Produto";
                cbMarca.SelectedValue = marca;
                cbCategoria.SelectedValue = categoria;
                btcadastrar.Enabled = false;
                btExcluir.Enabled = true;
            }
            else
            {
                btAtualizar.Enabled = false;
                btExcluir.Enabled = false;
            }
        }

        // CALCULO PARA GERAR O PRECO VENDA
        private void CalcularPrecoVenda()
        {
            if (decimal.TryParse(txtCusto.Text, out decimal custo) &&
                decimal.TryParse(txtLucro.Text, out decimal lucro))
            {
                decimal precoVenda = custo +(custo * (lucro / 100) );
                txtVenda.Text = precoVenda.ToString("F2");
            }
            else
            {
                txtVenda.Text = ""; 
            }
        }
         
        //SE FOR ESCOLHIDO O CAMPO DE PROMOCAO VAI FAZER UMA CONTA PARECIDA COM A DE VENDA MAS COM O DESCONTO COLOCADO
        private void CalcularPromocao()
        {
            if (!rbPromocaoSim.Checked)
                return;

            if (decimal.TryParse(txtVenda.Text, out decimal precoVenda) &&
                decimal.TryParse(txtDesconto.Text, out decimal desconto) &&
                decimal.TryParse(txtCusto.Text, out decimal precoCusto))
            {
                decimal precoFinal = precoVenda -(precoVenda *(desconto/100));

                //CASO O PREÇO FINAL FOR MENOR QUE O PREÇO DE CUSTO, VAI APARECER UMA MENSAGEM FALANDO QUE NÃO PODE SER FEITO DESSE JEITO E VAI LIMPAR O CAMPO DE DESCONTO E O PREÇO FINAL
                if (precoFinal < precoCusto)
                {
                    MessageBox.Show("O preço final com desconto não pode ser menor que o preço de custo!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                    //LIMPANDO
                    txtPromoFinal.Text = "";
                    txtDesconto.Text = ""; 
                }
                else
                {
                    txtPromoFinal.Text = precoFinal.ToString("F2");
                }
            }
            else
            {
                txtPromoFinal.Text = "";
            }
        }

        //MÉTODO LIMPAR PARA QUANDO FOR FEITO O CADASTRO NÃO FICAR AS INFORMAÇÕES MOSCANDO NA TELA DESAPARECENDO TUDO E FAZENDO ALGUMAS COISA JÁ PRÉ SELECIONADA
        public void Limpar()
        {
            txtNome.Clear();
            txtObservacao.Clear();
            cbCategoria.SelectedIndex = -1;
            cbMarca.SelectedIndex = -1;
            txtCusto.Clear();
            txtLucro.Clear();
            txtVenda.Clear();
            txtQuantidade.Clear();
            rbPromocaoNao.Checked = true;
            txtDescricao.Clear();
            txtObservacao.Clear();
        }

        //BOTÃO DE CADASTAR PRODUTO
        private void btcadastrar_Click(object sender, EventArgs e)
        {
           //IF VERIFICANDO SE OS CAMPOS NÃO ESTIVER VAZIO, CASO NÃO ESTEJA VAI MANDAR AS INFORMAÇÕES PRO BANCO
            if (txtNome.Text != "" && txtCusto.Text !="")
            {
                ClassProduto cProduto = new ClassProduto();

                cProduto.nome_produto = txtNome.Text;
                cProduto.codigo_marca = Convert.ToInt32(cbMarca.SelectedValue);
                cProduto.codigo_categoria = Convert.ToInt32(cbCategoria.SelectedValue);
                cProduto.preco_custo = Convert.ToDecimal(txtCusto.Text);
                cProduto.preco_lucro = Convert.ToDecimal(txtLucro.Text);
                cProduto.preco_venda = Convert.ToDecimal(txtVenda.Text);
                
                //VENDO SE O CAMPO ESTIVER VAZIO MANDE 0 PRO BANCO E NÃO ESTIVER VAI MANDAR O QUE ESTÁ ESCRITO 
                if (txtDesconto.Text != "")
                {
                   cProduto.preco_desconto = Convert.ToDecimal(txtDesconto.Text);
                }
                else
                {
                    cProduto.preco_desconto = 0;
                }
                if (txtPromoFinal.Text != "")
                {
                    cProduto.preco_final_promo = Convert.ToDecimal(txtPromoFinal.Text);
                }
                else
                {
                    cProduto.preco_final_promo = 0;
                }

                //SE O RADIO BUTTON FOR SIM PARA PROMOÇÃO VAI SER MANDADO 1 PARA O BANCO SE FOR SELECIONADO NAO VAi MANDAR 0
                if (rbPromocaoSim.Checked)
                {
                    cProduto.preco_promocao = 1;
                }
                else
                {
                    cProduto.preco_promocao = 0;
                }

                cProduto.quantidade = Convert.ToInt32(txtQuantidade.Text); 
                cProduto.descricao = txtDescricao.Text;
                cProduto.observacao = txtObservacao.Text;

                //ESSE SERIA O MÉTODO DE CADASTRAR O PRODUTO
                int resp = cProduto.CadastrarProduto();
                 
                // 1 SERIA SE FOI CADASTRADO E GERA UMA MENSAGEM E FAZENDO O MÉTODO LIMPAR, SE NÃO IERIA APARECER UMA MENSAGEM DE ERRO OU PARA PREENCHER OS CAMPOS OBRIGATÓRIOS
                if (resp == 1)
                {
                    MessageBox.Show("Produto: " + cProduto.nome_produto + " cadastrado com sucesso", "Sistema Drop to Paradise", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Limpar();
                }
                else
                {
                    MessageBox.Show("Erro ao realizar cadastro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Favor preencher todos os campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.BackColor = Color.LightSteelBlue;
                cbCategoria.BackColor = Color.LightSteelBlue;
                cbMarca.BackColor = Color.LightSteelBlue;
                txtCusto.BackColor = Color.LightSteelBlue;
                txtLucro.BackColor = Color.LightSteelBlue;
                txtVenda.BackColor = Color.LightSteelBlue;
                txtQuantidade.BackColor = Color.LightSteelBlue;
            }
        }

        //O BUTTON4 SERIA O BOTÃO DE SAIR QUIE EU FIQUEI COM PREGUIÇA DE NOMEAR E QUANDO CLICA NELE ELE SAI 
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // AQUI ESTA SENDO FEITO QUE QUANDO FOR CLICADO O SIM DA PROMOÇÃO SEJA FEITA A CONTA E QUANDO CLIQUE NO NÃO FIQUE IMPOSSIVEL DE CLICAR E FICA VAZIO
        private void rbPromocaoSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPromocaoSim.Checked)
            {
                txtDesconto.Enabled = true;
               
                CalcularPromocao(); 
            }
        }

        private void rbPromocaoNao_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbPromocaoNao.Checked)
            {
                txtDesconto.Enabled = false;
                txtPromoFinal.Enabled = false;
                txtDesconto.Text = "";
                txtPromoFinal.Text = "";
            }
        }

        //QUANDO DIGITAR JÁ FAÇA A CONTA
        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
                CalcularPromocao();
        }

        //AQUI FUNCIONA DO MESMO MODO QUE O CADASTRAS, MUDANDO SÓ QUE PODE INATIVAR UM PRODUUTO
        private void btAtualizar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
            {
                ClassProduto CProduto = new ClassProduto();
                CProduto.nome_produto = txtNome.Text; 
                CProduto.codigo_marca = Convert.ToInt32(cbMarca.SelectedValue);
                CProduto.codigo_categoria = Convert.ToInt32(cbCategoria.SelectedValue);
                CProduto.preco_custo = Convert.ToDecimal(txtCusto.Text);
                CProduto.preco_lucro = Convert.ToDecimal(txtLucro.Text);
                CProduto.preco_venda = Convert.ToDecimal(txtVenda.Text);
                if (txtDesconto.Text != "")
                {
                    CProduto.preco_desconto = Convert.ToDecimal(txtDesconto.Text);
                }
                else
                {
                    CProduto.preco_desconto = 0;
                }

                if (txtPromoFinal.Text != "")
                {
                    CProduto.preco_final_promo = Convert.ToDecimal(txtPromoFinal.Text);
                }
                else
                {
                    CProduto.preco_final_promo = 0;
                }

                if (rbPromocaoSim.Checked)
                {
                    CProduto.preco_promocao = 1;
                }
                else
                {
                    CProduto.preco_promocao = 0;
                }
                
                if (ckStatus.Checked)
                {
                    CProduto.status = 1;
                }
                else
                {
                    CProduto.status = 0;
                }

                CProduto.quantidade = Convert.ToInt32(txtQuantidade.Text);
                CProduto.descricao = txtDescricao.Text;
                CProduto.observacao = txtObservacao.Text;
                CProduto.codigo_produto = Convert.ToInt32(txtCodigoProduto.Text);

                int resp = CProduto.AtualizarProduto();

                //SE O CADASTRO DEU CERTO RESP = 1 
                if (resp == 1)
                {
                    MessageBox.Show("Produto:" + CProduto.nome_produto + "atualizado com sucesso", "Sistema Drop to Paraidse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else //CAMPOS OBRIGATÓRIOS
            {
                MessageBox.Show("Verificar campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.BackColor = Color.LightSteelBlue;


            }
        }

        //BOTÃO É PARA DELETAR O PRODUTO
        private void btExcluir_Click(object sender, EventArgs e)
        {
            ClassProduto cProduto = new ClassProduto();
            //PERGUNTAR PARA O USUARIO SE QUER EXCLUIR O PRODUTO
            if (MessageBox.Show($"Deseja excluir o produto {cProduto.nome_produto}?", "Sistema Drop to Paradise", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cProduto.codigo_produto = Convert.ToInt32(txtCodigoProduto.Text);
                //CHAMAR O METODO DA CLASSE PARA EXCLUIR
                int resp = cProduto.ExcluirProduto();
                if (resp ==1)
                {
                    MessageBox.Show($"Produto: {cProduto.nome_produto} excluido com sucesso", "Sistema Drop To Paradise", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }

        private void txtCusto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Sistema Drop to Paradise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtLucro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Sistema Drop to Paradise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Sistema Drop to Paradise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Sistema Drop to Paradise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
