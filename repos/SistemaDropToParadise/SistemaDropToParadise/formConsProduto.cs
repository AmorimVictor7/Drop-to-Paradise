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
    public partial class formConsProduto : Form
    {
        public formConsProduto()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void formConsProduto_Load(object sender, EventArgs e)
        {
            //COMBO DE OPÇÕES DE CONSULTA
            cbOpcoes.Items.Add("Nome");
            cbOpcoes.Items.Add("Marca");
            cbOpcoes.Items.Add("Categoria");
            cbOpcoes.Items.Add("Quantidade");
            cbOpcoes.Items.Add("Promoção");
            cbOpcoes.Items.Add("Status");

            cbOpcoes.SelectedItem = "Nome";

            ClassMarca cMarca = new ClassMarca();
            //CHAMAR MÉTODO NA COMBO
            cbMarca.DataSource = cMarca.BuscarMarca();
            //MOSTRAR NA COMBO A LISTA DE CARGOS - NOME - O QUE VOU EXIBIR NA COMBO
            cbMarca.DisplayMember = "nome_marca";
            //VALOR ARMAZENADO PELA TABELA FUNCIONÁRIO - CÓDIGO
            cbMarca.ValueMember = "codigo_marca";
            cbMarca.SelectedIndex = -1;

            classCategoria cCategoria = new classCategoria();
            //CHAMAR MÉTODO NA COMBO
            cbCategoria.DataSource = cCategoria.BuscarCategoria();
            //MOSTRAR NA COMBO A LISTA DE CARGOS - NOME - O QUE VOU EXIBIR NA COMBO
            cbCategoria.DisplayMember = "nome_categoria";
            //VALOR ARMAZENADO PELA TABELA FUNCIONÁRIO - CÓDIGO
            cbCategoria.ValueMember = "codigo_categoria";
            cbCategoria.SelectedIndex = -1;
        }

        private void cbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOpcoes.SelectedIndex == 0)
            {
                gbNome.Enabled = true;
                gbQuantidade.Enabled = false;
                gbTipoPesquisa.Enabled = true;
                cbMarca.Enabled = false;
                cbCategoria.Enabled = false;
                gbPromocao.Enabled = false;         
                gbStatus.Enabled = false;
            }

            if (cbOpcoes.SelectedIndex == 1)
            {
                gbNome.Enabled = false;
                gbQuantidade.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                cbMarca.Enabled = true;
                cbCategoria.Enabled = false;
                gbPromocao.Enabled = false;
                gbStatus.Enabled = false;
            }

            if (cbOpcoes.SelectedIndex == 2)
            {
                gbNome.Enabled = true;
                gbQuantidade.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                cbMarca.Enabled = false;
                cbCategoria.Enabled = true;
                gbPromocao.Enabled = false;
                gbStatus.Enabled = false;
            }

            if (cbOpcoes.SelectedIndex == 3)
            {
                gbNome.Enabled = false;
                gbQuantidade.Enabled = true;
                gbTipoPesquisa.Enabled = false;
                cbMarca.Enabled = false;
                cbCategoria.Enabled = false;
                gbPromocao.Enabled = false;
                gbStatus.Enabled = false;
            }

            if (cbOpcoes.SelectedIndex == 4)
            {
                gbNome.Enabled = false;
                gbQuantidade.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbMarca.Enabled = false;
                cbCategoria.Enabled = false;
                gbPromocao.Enabled = true;
                gbStatus.Enabled = false;
            }

            if (cbOpcoes.SelectedIndex == 5)
            {
                gbNome.Enabled = false;
                gbQuantidade.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                cbMarca.Enabled = false;
                cbCategoria.Enabled = false;
                gbPromocao.Enabled = false;
                gbStatus.Enabled = true;
            }
          

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            ClassProduto cProduto = new ClassProduto();

            //VARIÁVEL QUE VAI ALIMENTAR O SWITCH
            string filtro = cbOpcoes.SelectedItem.ToString();

            switch (filtro)
            {
                case "Status":
                    if (rbAtivo.Checked)
                    {
                        dgvProduto.DataSource = cProduto.ConsProdutoStatus(1);
                    }
                    else
                    {
                        dgvProduto.DataSource = cProduto.ConsProdutoStatus(0);
                    }

                    break;

                        case "Marca":
                    if (cbMarca.SelectedIndex != -1)
                    {
                        dgvProduto.DataSource = cProduto.ConsprodutoMarca(Convert.ToInt32(cbMarca.SelectedValue));
                    }

                    else
                    {
                        MessageBox.Show("Favor escolher uma marca", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        gbMarca.BackColor = Color.LightSteelBlue;
                    }

                    break;

                     case "Categoria":

                    if (cbCategoria.SelectedIndex != -1)
                    {
                        dgvProduto.DataSource = cProduto.ConsprodutoCategoria(Convert.ToInt32(cbCategoria.SelectedValue));
                    }

                    else
                    {
                        MessageBox.Show("Favor escolher uma categoria", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        gbCategoria.BackColor = Color.LightSteelBlue;
                    }


                    break;

                case "Promoção":
                    if (rbCom.Checked)
                    {
                        dgvProduto.DataSource = cProduto.ConsProdutoPromo(1);
                    }

                    else
                    {
                        dgvProduto.DataSource = cProduto.ConsProdutoPromo(0);
                    }
                        break;

                case "Quantidade":
                    dgvProduto.DataSource = cProduto.ConsprodutoQuantidade(Convert.ToInt32(dtpMin.Text), Convert.ToInt32(dtpMax.Text));
                    break;

           

                default:
                    if (txtNome.Text != "")
                    {
                        if (rbInicio.Checked)
                        {
                            dgvProduto.DataSource = cProduto.ConsprodutoNomeInicio(txtNome.Text);
                        }

                        else
                        {
                            dgvProduto.DataSource = cProduto.ConsprodutoNomeContem(txtNome.Text);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Favor preenchar um nome", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNome.BackColor = Color.LightSteelBlue;
                    }
                    break;

            }
        }

    

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //CLICAR NA GRID DE PRODUTO E EDITAR OU EXCULIR O PRODUTO 
            if (MessageBox.Show("Deseja alterar o produto selecionado?", "Sistema Drop to Paradise", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //CRIAR OBJETO DA CLASSE FUNCIONÁRIO PARA USAR MÉTODO E PROPRIEDADES
                ClassProduto cproduto = new ClassProduto();

                //CRIAR OBJETO DO FORM DE CADASTRO PARA MANDAR AS INFORMAÇÕES DO BD PARA O FORM - NÃO ESQUECER DE MUDAR AS PROPRIEDADE MODIFIERS DE TODOS OS ELEMENTOS QUE VÃO RECEBER DADOS DO FORM DE CADASTRO 
                FormProduto fProduto = new FormProduto();

                //LER O CÓDIGO O FUNCIONÁRIO QUE SERÁ ALTERADO, DE ACORDO COM A ESCOLHA DO USUÁRIO NA GRID
                cproduto.ConsultaProduto(Convert.ToInt32(dgvProduto.SelectedRows[0].Cells[0].Value));
                //PASSAR PARA O FORM DE CADASTRO AS INFORMAÇÕES DO BANCO DE DADOS DE ACORDO COM O PRODUTO ESCOLHIDO
                fProduto.txtCodigoProduto.Text = cproduto.codigo_produto.ToString();
                fProduto.txtNome.Text = cproduto.nome_produto.ToString();
                fProduto.txtCusto.Text = cproduto.preco_custo.ToString();
                fProduto.txtLucro.Text = cproduto.preco_lucro.ToString();
                fProduto.txtVenda.Text = cproduto.preco_venda.ToString();

                if (cproduto.preco_promocao == 1)
                {
                    fProduto.rbPromocaoSim.Checked = true;
                    fProduto.rbPromocaoNao.Checked = false;
                }
                else
                {
                    fProduto.rbPromocaoSim.Checked = false;
                    fProduto.rbPromocaoNao.Checked = true;
                }
                fProduto.txtDesconto.Text = cproduto.preco_desconto.ToString();
                fProduto.txtVenda.Text = cproduto.preco_venda.ToString();
                fProduto.txtPromoFinal.Text = cproduto.preco_final_promo.ToString();
                fProduto.txtQuantidade.Text = cproduto.quantidade.ToString();
                fProduto.txtObservacao.Text = cproduto.observacao.ToString();
                fProduto.txtDescricao.Text = cproduto.descricao.ToString();

                if (cproduto.status == 1)
                {
                    fProduto.ckStatus.Checked = true;
                }
                else
                {
                    fProduto.ckStatus.Checked = false;
                }

                fProduto.data_cad = cproduto.data_cadastro;
                fProduto.marca = cproduto.codigo_marca;
                fProduto.categoria = cproduto.codigo_categoria;
                //MANDAR PARA A VARIAVEL TIPO A INFORMAÇÃO ATUALIZAÇÃO
                fProduto.tipo = "Atualização";

                //ABRIR O FORM DE CADASTRO EM MODO EXCLUSIVO 
                fProduto.ShowDialog();

                //CHAMAR O EVENTO CLICK DO BOTÃO PESQUISAR
                btPesquisar_Click(this, new EventArgs());

            }

            else
            {

            }

        }

        private void dtpMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Sistema Drop to Paradise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dtpMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Sistema Drop to Paradise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
