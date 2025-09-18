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
    public partial class formConsCliente : Form
    {
        public formConsCliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void formConsCliente_Load(object sender, EventArgs e)
        {
            cbOpcoes.Items.Add("Nome");
            cbOpcoes.Items.Add("CPF"); 
            cbOpcoes.Items.Add("Sexo");
            cbOpcoes.Items.Add("Estado");
            cbOpcoes.Items.Add("Cidade");
            cbOpcoes.Items.Add("Status");
            
            cbOpcoes.SelectedItem = "Nome";

            cbSexo.Items.Add("Feminino");
            cbSexo.Items.Add("Masculino");
            cbSexo.Items.Add("Não Informado");
            cbSexo.Sorted = true;
            cbSexo.SelectedItem = "Masculino";

            ClassCliente cCliente = new ClassCliente();
            cbCidade.DataSource = cCliente.BuscarCidade();
            cbCidade.DisplayMember = "cidade";
            cbCidade.ValueMember = "cidade";
            cbCidade.SelectedIndex = -1;

            ClassCliente CCliente = new ClassCliente();
            cbEstado.DataSource = CCliente.BuscarEstado();
            cbEstado.DisplayMember = "estado";
            cbEstado.ValueMember = "estado";
            cbEstado.SelectedIndex = -1;
        }

        private void cbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbOpcoes.SelectedIndex == 0)
            {
                gbCPF.Enabled = false;
                gbTipoPesquisa.Enabled = true;
                gbNome.Enabled = true;
                gbSexo.Enabled = false;
                gbEstado.Enabled = false;
                gbCidade.Enabled = false;
                gbStatus.Enabled = false;
                gbCidade.Enabled = false;
            }

            if (cbOpcoes.SelectedIndex == 1)
            {
                gbCPF.Enabled = true;
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbSexo.Enabled = false;
                gbEstado.Enabled = false;
                gbStatus.Enabled = false;
                gbCidade.Enabled = false;
            }

            if (cbOpcoes.SelectedIndex == 2)
            {
                gbCPF.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbSexo.Enabled = true;
                gbEstado.Enabled = false;
                gbStatus.Enabled = false;
                gbCidade.Enabled = false;
            }
            if (cbOpcoes.SelectedIndex == 3)
            {
                gbCPF.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbSexo.Enabled = false;
                gbEstado.Enabled = true;
                gbStatus.Enabled = false;
                gbCidade.Enabled = false;
            }
            if (cbOpcoes.SelectedIndex == 4)
            {
                gbCPF.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbSexo.Enabled = false;
                gbEstado.Enabled = false;
                gbStatus.Enabled = false;
                gbCidade.Enabled = true;
            }

            if (cbOpcoes.SelectedIndex == 5)
            {
                gbCPF.Enabled = false;
                gbTipoPesquisa.Enabled = false;
                gbNome.Enabled = false;
                gbSexo.Enabled = false;
                gbEstado.Enabled = false;
                gbStatus.Enabled = true;
                gbCidade.Enabled = false;
            }           
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {

            ClassCliente cCliente = new ClassCliente();

            //VARIÁVEL QUE VAI ALIMENTAR O SWITCH
            string filtro = cbOpcoes.SelectedItem.ToString();

            switch (filtro)
            {
                case "Cidade":
                {
                        if (cbCidade.SelectedIndex != -1)
                        {
                            dgvCliente.DataSource = cCliente.ConsClienteCidade(cbCidade.SelectedValue.ToString());
                        }

                        else
                        {
                            MessageBox.Show("Favor escolher uma cidade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            cbCidade.BackColor = Color.LightSteelBlue;

                        }
                    }
                break;

                case "Estado":
                    {
                        if (cbEstado.SelectedIndex != -1)
                        {
                            dgvCliente.DataSource = cCliente.ConsClienteEstado(cbEstado.SelectedValue.ToString());
                        }

                        else
                        {
                            MessageBox.Show("Favor escolher um estado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            cbEstado.BackColor = Color.LightSteelBlue;

                        }
                    }
                    break;

                case "CPF":
                    //VERIFICAR SE USUÁRIO DIGITOU UM CPF
                    if (mskCpf.Text != "   .   .   -")
                    {
                         dgvCliente.DataSource = cCliente.ConsClienteCpf(mskCpf.Text);
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
                    if (cbSexo.SelectedItem.ToString() == "Masculino")
                    {
                        dgvCliente.DataSource = cCliente.ConsClienteSexo("M");
                    }
                    else if (cbSexo.SelectedItem.ToString() == "Feminino")
                    {
                        dgvCliente.DataSource = cCliente.ConsClienteSexo("F");
                    }
                    else
                    {
                        dgvCliente.DataSource = cCliente.ConsClienteSexo("N");
                    }
                    break;

                case "Status":
                    if (rbAtivo.Checked)
                    {
                        dgvCliente.DataSource = cCliente.ConsClienteStatus(1);
                    }
                    else
                    {
                        dgvCliente.DataSource = cCliente.ConsClienteStatus(0);
                    }

                    break;

                default:
                    if (txtNome.Text != "")
                    {
                        if (rbInicio.Checked)
                        {
                            dgvCliente.DataSource = cCliente.ConsClienteNomeInicio(txtNome.Text);

                        }

                        else
                        {
                            dgvCliente.DataSource = cCliente.ConsClienteNomeContem(txtNome.Text);
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

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //CLICAR NA GRID DE FUNCIONÁRIO E EDITAR OU EXCULIR U FUNCIONÁRIO
            //USAR O EVENTO cellClik (PODE CLICAR EM QUALQUER LUGAR DA CÉLULAR, NÃO SOMENTE NO TEXTO)
            //USANDO O EVENTO CellcontentClick ( TEM QUE CLICAR NO CONTEÚDO (TEXTO))
            if (MessageBox.Show("Deseja alterar o cliente selecionado?", "Sistema Drop to Paradise", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //CRIAR OBJETO DA CLASSE FUNCIONÁRIO PARA USAR MÉTODO E PROPRIEDADES
                ClassCliente cCliente = new ClassCliente();

                FormCliente fCliente = new FormCliente();

                cCliente.ConsultaCliente(Convert.ToInt32(dgvCliente.SelectedRows[0].Cells[0].Value));
                //PASSAR PARA O FORM DE CADASTRO AS INFORMAÇÕES DO BANCO DE DADOS DE ACORDO COM O CLIENTE ESCOLHIDO
                fCliente.txtCodigoCliente.Text = cCliente.codigo_cliente.ToString();
                fCliente.txtNome.Text = cCliente.nome.ToString();
                fCliente.txtNomeSocial.Text = cCliente.nome_social.ToString();
                fCliente.mskDataNascimento.Text = cCliente.data_nascimento.ToString();

                if (cCliente.sexo == "M")
                {
                    fCliente.rbMasculino.Checked = true;


                }
                else if (cCliente.sexo == "F")
                {
                    fCliente.rbFeminino.Checked = true;
                }
                else
                {
                    fCliente.rbNaoInformado.Checked = true;
                }
                //ESTADO CIVIL - COMBO BOX - CHAMAR A VARIÁVEL CRIADA NO FORM DE CADASRO 
      
                fCliente.mskCpf.Text = cCliente.cpf.ToString();
                fCliente.mskRg.Text = cCliente.rg.ToString();
              
                fCliente.mskCpf.Text = cCliente.cpf.ToString();
                fCliente.mskRg.Text = cCliente.rg.ToString();    
                fCliente.txtEndereco.Text = cCliente.endereco.ToString();
                fCliente.txtNumero.Text = cCliente.numero.ToString();
                fCliente.txtComplemento.Text = cCliente.complemento.ToString();
                fCliente.txtBairro.Text = cCliente.bairro.ToString();
                fCliente.txtCidade.Text = cCliente.cidade.ToString();
                fCliente.mskcep.Text = cCliente.cep.ToString();
                fCliente.estado = cCliente.estado;
                fCliente.mskTelefoneResidencial.Text = cCliente.telefone_residencial.ToString();
                fCliente.mskTelefoneCelular.Text = cCliente.telefone_celular.ToString();
                fCliente.txtEmail.Text = cCliente.email.ToString();
                if (cCliente.status == 1)
                {
                    fCliente.ckStatus.Checked = true;
                }
                else
                {
                    fCliente.ckStatus.Checked = false;
                }

                fCliente.data_cad = cCliente.data_cadastro;
           

                //MANDAR PARA A VARIAVEL TIPO A INFORMAÇÃO ATUALIZAÇÃO
                fCliente.tipo = "Atualização";

                //ABRIR O FORM DE CADASTRO EM MODO EXCLUSIVO 
                fCliente.ShowDialog();
                //CHAMAR O EVENTO CLICK DO BOTÃO PESQUISAR
                btPesquisar_Click(this, new EventArgs());

            }


            else
            {

            }



        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
