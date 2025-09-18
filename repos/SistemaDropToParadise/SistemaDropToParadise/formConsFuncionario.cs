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
    public partial class formConsFuncionario : Form
    {
        public formConsFuncionario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void formConsFuncionario_Load(object sender, EventArgs e)
        {
            //COMBO DE OPÇÕES DE CONSULTA
            cbOpcoes.Items.Add("Nome");
            cbOpcoes.Items.Add("CPF");
            cbOpcoes.Items.Add("Cidade");
            cbOpcoes.Items.Add("Sexo");
            cbOpcoes.Items.Add("Status");
            cbOpcoes.Items.Add("Cargo");
            cbOpcoes.Items.Add("Data de Admissão");
            cbOpcoes.Items.Add("Sexo e Cidade");
            // PARA DEIXAR EM ORDEM ALFABÉTICA
            //cbOpcoes.Sorted = true;
            cbOpcoes.SelectedItem = "Nome";

            //COMBO SEXO
            cbSexo.Items.Add("Feminino");
            cbSexo.Items.Add("Masculino");
            cbSexo.Items.Add("Não Informado");
            cbSexo.Sorted = true;
            cbSexo.SelectedItem = "Masculino";

            //COMBO CARGO
            //CARREGAR COMBO DE BD
            //CARREGAR COMBO DE CARGO
            ClassCargo cCargo = new ClassCargo();
            //CHAMAR MÉTODO NA COMBO
            cbCargo.DataSource = cCargo.BuscarCargo();
            //MOSTRAR NA COMBO A LISTA DE CARGOS - NOME - O QUE VOU EXIBIR NA COMBO
            cbCargo.DisplayMember = "nome_cargo";
            //VALOR ARMAZENADO PELA TABELA FUNCIONÁRIO - CÓDIGO
            cbCargo.ValueMember = "codigo_cargo";
            cbCargo.SelectedIndex = -1;

            //COMBO
            classFuncionario cFuncionario = new classFuncionario();
            cbCidade.DataSource = cFuncionario.BuscarCidade();
            cbCidade.DisplayMember = "cidade";
            cbCidade.ValueMember = "cidade";
            cbCidade.SelectedIndex = -1;


        }


        private void cbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
           //ATIVAR/ DESATIVAR ELEMENTOS DO FORM DE ACORDO COM A ESCOLHA DO USUÁRIO
           //0 - NOME
           if(cbOpcoes.SelectedIndex ==0)
            {
                gbCPF.Enabled = false;
                gbTipoPesquisa.Enabled = true;
                gbNome.Enabled = true;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbCargo.Enabled = false;
                gbStatus.Enabled = false;
            }

            if (cbOpcoes.SelectedIndex == 1)
            {
                gbCPF.Enabled = true;
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbCargo.Enabled = false;
                gbStatus.Enabled = false;
            }

            if (cbOpcoes.SelectedIndex ==2)
            {
                gbCPF.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbSexo.Enabled = false;
                gbCidade.Enabled = true;
                gbDataAdmissao.Enabled = false;
                gbCargo.Enabled = false;
                gbStatus.Enabled = false;
            }

            if (cbOpcoes.SelectedIndex == 3)
            {
                gbCPF.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbSexo.Enabled = true;
                gbCidade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbCargo.Enabled = false;
                gbStatus.Enabled = false;
            }

            if (cbOpcoes.SelectedIndex == 4)
            {
                gbCPF.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbCargo.Enabled = false;
                gbStatus.Enabled = true;
            }

            if (cbOpcoes.SelectedIndex == 5)
            {
                gbCPF.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbCargo.Enabled = true;
                gbStatus.Enabled = false;
            }

            if (cbOpcoes.SelectedIndex == 6)
            {
                gbCPF.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbSexo.Enabled = false;
                gbCidade.Enabled = false;
                gbDataAdmissao.Enabled = true;
                gbCargo.Enabled = false;
                gbStatus.Enabled = false;
            }
           
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            classFuncionario cFuncionario = new classFuncionario();

            //VARIÁVEL QUE VAI ALIMENTAR O SWITCH
            string filtro = cbOpcoes.SelectedItem.ToString();

            switch(filtro)
            {
                case "CPF":
                    //VERIFICAR SE USUÁRIO DIGITOU UM CPF
                    if(mskCpf.Text != "   .   .   -")
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsFuncionarioCPF(mskCpf.Text);
                    }
                    else
                    {
                        MessageBox.Show("Favor digitar um CPF completo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        gbCPF.BackColor = Color.LightSteelBlue;
                        mskCpf.Focus();
                    }
                    break;

                case "Sexo":
                    //SEXO = MASCULINO
                    if(cbSexo.SelectedItem.ToString()== "Masculino")
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsFuncionarioSexo("M");
                    }
                    else if (cbSexo.SelectedItem.ToString()=="Feminino")
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsFuncionarioSexo("F");
                    }
                    else
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsFuncionarioSexo("N");
                    }
                    break;

                case "Cidade":
                    //VERIFICAR SE ESCOLHEU CIDADE
                    if(cbCidade.SelectedIndex != -1)
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsFuncionarioCidade(cbCidade.SelectedValue.ToString());
                    }

                    else
                    {
                        MessageBox.Show("Favor escolher uma cidade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        gbCidade.BackColor = Color.LightSteelBlue;
                        
                    }

                    break;



                case "Cargo":
                    //VERIFICAR SE ESCOLHEU CIDADE
                    if (cbCargo.SelectedIndex != -1)
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsFuncionarioCargo(Convert.ToInt32(cbCargo.SelectedValue));
                    }

                    else
                    {
                        MessageBox.Show("Favor escolher um cargo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        gbCargo.BackColor = Color.LightSteelBlue;

                    }

                    break;


                case "Status":
                    if(rbAtivo.Checked)
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsFuncionarioStatus(1);
                    }
                    else
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsFuncionarioStatus(0);
                    }

                    break;
                case "Data de Admissão":
                    dgvFuncionario.DataSource = cFuncionario.ConsFuncionarioDataAdmissão(Convert.ToDateTime(dtpDataInicial.Text), Convert.ToDateTime(dtpDataFinal.Text));
                    break;

                case "Sexo e Cidade":
                    //VERIFICAR SE USUÁRIO DIGITOU UM SEXO E CIDADE
                    if (cbSexo.SelectedItem.ToString() == "Masculino" && cbCidade.SelectedIndex != -1)
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsFuncionarioSexoCidade("M", cbCidade.SelectedValue.ToString());
                    }
                    else if (cbSexo.SelectedItem.ToString() == "Feminino" && cbCidade.SelectedIndex != -1)
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsFuncionarioSexoCidade("F", cbCidade.SelectedValue.ToString());
                    }
                    else
                    {
                        dgvFuncionario.DataSource = cFuncionario.ConsFuncionarioSexoCidade("N", cbCidade.SelectedValue.ToString());
                    }

                    break;


                default:
                    if(txtNome.Text != "")
                    {
                        if (rbInicio.Checked)
                        {
                            dgvFuncionario.DataSource = cFuncionario.ConsFuncionarioNomeInicio(txtNome.Text);

                        }

                        else
                        {
                            dgvFuncionario.DataSource = cFuncionario.ConsFuncionarioNomeContem(txtNome.Text);
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

        

        private void dgvFuncionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //CLICAR NA GRID DE FUNCIONÁRIO E EDITAR OU EXCULIR U FUNCIONÁRIO
            //USAR O EVENTO cellClik (PODE CLICAR EM QUALQUER LUGAR DA CÉLULAR, NÃO SOMENTE NO TEXTO)
            //USANDO O EVENTO CellcontentClick ( TEM QUE CLICAR NO CONTEÚDO (TEXTO))
            if (MessageBox.Show("Deseja alterar o funcionário selecionado?", "Sistema Drop to Paradise", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //CRIAR OBJETO DA CLASSE FUNCIONÁRIO PARA USAR MÉTODO E PROPRIEDADES
                classFuncionario cfuncionario = new classFuncionario();

                //CRIAR OBJETO DO FORM DE CADASTRO PARA MANDAR AS INFORMAÇÕES DO BD PARA O FORM - NÃO ESQUECER DE MUDAR AS PROPRIEDADE MODIFIERS DE TODOS OS ELEMENTOS QUE VÃO RECEBER DADOS DO FORM DE CADASTRO 
                formFuncionario fFuncionario = new formFuncionario();

                //LER O CÓDIGO O FUNCIONÁRIO QUE SERÁ ALTERADO, DE ACORDO COM A ESCOLHA DO USUÁRIO NA GRID
                cfuncionario.ConsultaFuncionario(Convert.ToInt32(dgvFuncionario.SelectedRows[0].Cells[0].Value));
                //PASSAR PARA O FORM DE CADASTRO AS INFORMAÇÕES DO BANCO DE DADOS DE ACORDO COM O FUNCIONÁRIO ESCOLHIDO
                fFuncionario.txtCodigoFuncionario.Text = cfuncionario.codigo_funcionario.ToString();
                fFuncionario.txtNome.Text = cfuncionario.nome.ToString();
                fFuncionario.txtNomeSocial.Text = cfuncionario.nome_social.ToString();
                fFuncionario.mskDataNascimento.Text = cfuncionario.data_nascimento.ToString();
                //SEXO
                if(cfuncionario.sexo == "M")
                {
                    fFuncionario.rbMasculino.Checked = true;


                }
                else if(cfuncionario.sexo =="F")
                {
                    fFuncionario.rbFeminino.Checked = true;
                }
                else
                {
                    fFuncionario.rbNaoInformado.Checked = true;
                }
                //ESTADO CIVIL - COMBO BOX - CHAMAR A VARIÁVEL CRIADA NO FORM DE CADASRO 
                fFuncionario.estado_civil = cfuncionario.estado_civil;
                fFuncionario.mskCpf.Text = cfuncionario.cpf.ToString();
                fFuncionario.mskRg.Text = cfuncionario.rg.ToString();
                fFuncionario.txtSalario.Text = cfuncionario.salario.ToString();
                fFuncionario.txtEndereco.Text = cfuncionario.endereco.ToString();
                fFuncionario.txtNumero.Text = cfuncionario.numero.ToString();
                fFuncionario.txtComplemento.Text = cfuncionario.complemento.ToString();
                fFuncionario.txtBairro.Text = cfuncionario.bairro.ToString();
                fFuncionario.txtCidade.Text = cfuncionario.cidade.ToString();
                fFuncionario.mskCep.Text = cfuncionario.cep.ToString();
                fFuncionario.estado = cfuncionario.estado;
                fFuncionario.mskTelefoneResidencial.Text = cfuncionario.telefone_residencial.ToString();
                fFuncionario.mskTelefoneCelular.Text = cfuncionario.telefone_celular.ToString();
                fFuncionario.txtEmail.Text = cfuncionario.email.ToString();

                if( cfuncionario.status==1)
                {
                    fFuncionario.ckStatus.Checked = true;
                }
                else
                {
                    fFuncionario.ckStatus.Checked = false;
                }

                fFuncionario.data_cad = cfuncionario.data_cadastro;
                fFuncionario.cargo = cfuncionario.codigo_cargo;
                fFuncionario.txtUsuario.Text = cfuncionario.usuario.ToString();
                fFuncionario.txtSenha.Text = cfuncionario.senha.ToString();
                fFuncionario.tipo_acesso = cfuncionario.tipo_acesso;     
                fFuncionario.cargo = cfuncionario.codigo_cargo;

                //MANDAR PARA A VARIAVEL TIPO A INFORMAÇÃO ATUALIZAÇÃO
                fFuncionario.tipo = "Atualização";

                //ABRIR O FORM DE CADASTRO EM MODO EXCLUSIVO 
                fFuncionario.ShowDialog();

                //CHAMAR O EVENTO CLICK DO BOTÃO PESQUISAR
                btPesquisar_Click(this, new EventArgs());

            }
              
            else
            {

            }

        }

        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
