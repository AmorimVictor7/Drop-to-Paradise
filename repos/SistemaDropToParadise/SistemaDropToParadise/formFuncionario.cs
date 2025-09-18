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
    public partial class formFuncionario : Form
    {
        public formFuncionario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }



        //VARIÁVEIS QUE SERÃO USADAS NO FORM DA CONSULTA PARA CARREGAR AS INFORMAÇÕES DO BD
        //ALÉM DA VARIÁVEL TIPO (PARA VERIFICAR SE FORM SERÁ ABERTO PARA CADASTRO OU ATUALIZAÇÃO) , TUDO QUE FOR CAREGADO EM CAMBOBOX TAMBÉM TERÁ QUE TER VARIÁVEL 
        public string tipo, estado_civil, estado;
        public int cargo, tipo_acesso;
        public DateTime data_cad;
        private void formFuncionario_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBOS - MANUALMENTE
            cbEstadoCivil.Items.Add("Solteiro(a)");
            cbEstadoCivil.Items.Add("Casado(a)");
            cbEstadoCivil.Items.Add("Separado(a)");
            cbEstadoCivil.Items.Add("Divorciado(a)");
            cbEstadoCivil.Items.Add("Viúvo(a)");

            //DEIXAR UMA OPÇÃO PRÉ SELECIONADA
            cbEstadoCivil.SelectedItem = "Solteiro(a)";

            //CARREGAR COMBO TIPO ACCESSO
            cbTipoAcesso.Items.Add("Comum");
            cbTipoAcesso.Items.Add("Administrador");
            cbTipoAcesso.SelectedIndex = 1;

            //CARREGAR COMBO ESTADO
            //CARREGAR COMBO ESTADO
            cbEstado.Items.Add("AC");
            cbEstado.Items.Add("AL");
            cbEstado.Items.Add("AP");
            cbEstado.Items.Add("AM");
            cbEstado.Items.Add("BA");
            cbEstado.Items.Add("CE");
            cbEstado.Items.Add("DF");
            cbEstado.Items.Add("ES");
            cbEstado.Items.Add("GO");
            cbEstado.Items.Add("MA");
            cbEstado.Items.Add("MT");
            cbEstado.Items.Add("MS");
            cbEstado.Items.Add("MG");
            cbEstado.Items.Add("PA");
            cbEstado.Items.Add("PB");
            cbEstado.Items.Add("PR");
            cbEstado.Items.Add("PE");
            cbEstado.Items.Add("PI");
            cbEstado.Items.Add("RJ");
            cbEstado.Items.Add("RN");
            cbEstado.Items.Add("RS");
            cbEstado.Items.Add("RO");
            cbEstado.Items.Add("RR");
            cbEstado.Items.Add("SC");
            cbEstado.Items.Add("SP");
            cbEstado.Items.Add("SE");
            cbEstado.Items.Add("TO");
            cbEstado.Sorted = true;
            cbEstado.SelectedItem = "SP";

            //COLOCAR ME ORDEM ALFABÉTICA
            cbEstado.Sorted = true;
            cbEstado.SelectedItem = "SP";

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
           
            if (tipo =="Atualização")
            {
                lbDataCadastro.Text = data_cad.ToString();
                    ckStatus.Enabled = true;
                lbTitulo.Text = "Atualização de Funcionário";
                cbEstadoCivil.SelectedItem = estado_civil;
                cbCargo.SelectedValue= cargo;
                cbEstado.SelectedItem = estado;
                btcadastrar.Enabled = false;
                btExcluir.Enabled = true;

                if (tipo_acesso == 0)
                {
                    cbTipoAcesso.SelectedItem = "Comum";
                }
                else
                {
                    cbTipoAcesso.SelectedItem = "Administrador";
                }
                      

            }
            else
            {
                btAtualizar.Enabled = false;
                btExcluir.Enabled = false;
            }

        }

       public void Limpar()
        {
            txtNome.Clear();
            txtNomeSocial.Clear();
            rbFeminino.Checked = true;
            mskDataNascimento.Clear();
            cbEstadoCivil.SelectedItem = "Solteiro(a)";
            mskRg.Clear();
            mskCpf.Clear();
            cbCargo.SelectedIndex = -1;
            txtSalario.Clear();
            mskCep.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            cbEstado.SelectedItem = "SP";
            mskTelefoneResidencial.Clear();
            mskTelefoneCelular.Clear();
            txtEmail.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
            cbTipoAcesso.SelectedItem = "Comum";
            txtNome.Focus();
        }
        private void btcadastrar_Click(object sender, EventArgs e)
        {
            classFuncionario cFuncionario = new classFuncionario();
            //VERIFICAR SE TODOS OS CAMPOS OBRIGATÓRIOS FORAM PREENCHIDOS 
            if (txtNome.Text != "" && mskDataNascimento.Text != " /  /" && mskCpf.Text != "   .   .   -" && txtEndereco.Text != "" && txtNumero.Text != "" && txtBairro.Text != "" && txtCidade.Text != "" && (mskTelefoneResidencial.Text != "(  )   -" || mskTelefoneCelular.Text != "(  )   -") && txtUsuario.Text != "" && txtSenha.Text != "" && cbCargo.SelectedIndex != -1)
            {
                //LERAS CAIXINHAS DO FORM E MANDAR PARA AS PROPRIEDADES DA CLASSE FUNCIONÁRIO
                cFuncionario.nome = txtNome.Text;
                cFuncionario.nome_social = txtNomeSocial.Text;
                cFuncionario.data_nascimento = Convert.ToDateTime(mskDataNascimento.Text);
                //SEXO - RÁDIO BUTTON - F/M/N
                if (rbFeminino.Checked == true)
                {
                    cFuncionario.sexo = "F";
                }
                else if (rbMasculino.Checked)
                {
                    cFuncionario.sexo = "M";
                }
                else
                {
                    cFuncionario.sexo = "N";
                }

                cFuncionario.estado_civil = cbEstadoCivil.SelectedItem.ToString();
                cFuncionario.cpf = mskCpf.Text;
                // RG - CAMPO MÁSCARA - NÃO OBRIGATÓRIO - FAZER IF PARA NÃO IR A MÁSCARA VAZIA PARA O BD SE O USUÁRIO NÃO PROEENCHER

                if (mskRg.Text != "   .   .   -")
                {
                    cFuncionario.rg = mskRg.Text;
                }
                else
                {
                    cFuncionario.rg = "";

                }

                if (txtSalario.Text != "")

                {

                    cFuncionario.salario = Convert.ToDecimal(txtSalario.Text);

                }

                else

                {

                    cFuncionario.salario = 0;

                }

                cFuncionario.endereco = txtEndereco.Text;
                cFuncionario.numero = Convert.ToInt32(txtNumero.Text);
                cFuncionario.complemento = txtComplemento.Text;
                cFuncionario.bairro = txtBairro.Text;
                cFuncionario.cidade = txtCidade.Text;
                //ESTADO COMBOBOX -  MANDAR ITEM SELECIONADO PELO USUÁRIO
                cFuncionario.estado = cbEstado.SelectedItem.ToString();
                //MASCARA
                cFuncionario.cep = mskCpf.Text;
                //TELEFONE RESIDENCIAL - MÁSCARA NÃO OBRIGATÓRIO
                if (mskTelefoneResidencial.Text != "(  )     -")
                {
                    cFuncionario.telefone_residencial = mskTelefoneResidencial.Text;
                }
                else
                {
                    cFuncionario.telefone_residencial = "";
                }

                //TELEFONE CELULAR - MÁSCARA NÃO OBRIGATÓRIO
                if (mskTelefoneCelular.Text != "(  )     -")
                {
                    cFuncionario.telefone_celular = mskTelefoneResidencial.Text;
                }
                else
                {
                    cFuncionario.telefone_celular = "";
                }

                cFuncionario.email = txtEmail.Text;
                cFuncionario.usuario = txtUsuario.Text;
                cFuncionario.senha = txtSenha.Text;

                //TIPO DE ACESSO - COMBO - BD (CAMPO BIT) 0 COMUM 1 ADM
                if (cbTipoAcesso.SelectedItem.ToString() == "Comum")
                {
                    cFuncionario.tipo_acesso = 0; // COMUM

                }
                else
                {
                    cFuncionario.tipo_acesso = 1; //ADMINISTRADOR
                }

                cFuncionario.foto = "";

                //CARGO - COMBO - CHAVE ESTRANGEIRA - SELECTDVALUE = MANDA O VALOR DO BANCO DE DADOS
                cFuncionario.codigo_cargo = Convert.ToInt32(cbCargo.SelectedValue);

                //CHAMAR MÉTODO CADASTRAR DA CLASSE FUNCIONARIO 
                int resp = cFuncionario.CadastrarFuncionario();

                //SE O CADASTRO DEU CERTO RESP = 1 
                if (resp == 1)
                {
                    MessageBox.Show("Funcionario:" + cFuncionario.nome + "cadastrado com sucesso", "Sistema Drop to Paraidse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar funcionário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else //CAMPOS OBRIGATÓRIOS
            {
                MessageBox.Show("Verificar campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.BackColor = Color.LightSteelBlue;
                gbSexo.BackColor = Color.LightSteelBlue;
                gbSexo.BackColor = Color.LightSteelBlue;
                mskCpf.BackColor = Color.LightSteelBlue;
                txtUsuario.BackColor = Color.LightSteelBlue;
                txtSenha.BackColor = Color.LightSteelBlue;
                cbTipoAcesso.BackColor = Color.LightSteelBlue;
                mskTelefoneResidencial.BackColor = Color.LightSteelBlue;
                mskTelefoneCelular.BackColor = Color.LightSteelBlue;
                mskCep.BackColor = Color.LightSteelBlue;
                txtEndereco.BackColor = Color.LightSteelBlue;
                txtNumero.BackColor = Color.LightSteelBlue;
                txtCidade.BackColor = Color.LightSteelBlue;
                txtBairro.BackColor = Color.LightSteelBlue;
            }


        }

   

        private void mskDataNascimento_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            {
                if (!e.IsValidInput)
                    MessageBox.Show("Data Inválida.", "Sistema Drop to Paradise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
            }
        }

     

        private void btAtualizar_Click(object sender, EventArgs e)
        {
            classFuncionario cFuncionario = new classFuncionario();
            //VERIFICAR SE TODOS OS CAMPOS OBRIGATÓRIOS FORAM PREENCHIDOS 
            if (txtNome.Text != "" && mskDataNascimento.Text != " /  /" && mskCpf.Text != "   .   .   -" && txtEndereco.Text != "" && txtNumero.Text != "" && txtBairro.Text != "" && txtCidade.Text != "" && (mskTelefoneResidencial.Text != "(  )   -" || mskTelefoneCelular.Text != "(  )   -") && txtUsuario.Text != "" && txtSenha.Text != "" && cbCargo.SelectedIndex != -1)
            {
                //LERAS CAIXINHAS DO FORM E MANDAR PARA AS PROPRIEDADES DA CLASSE FUNCIONÁRIO
                cFuncionario.nome = txtNome.Text;
                cFuncionario.nome_social = txtNomeSocial.Text;
                cFuncionario.data_nascimento = Convert.ToDateTime(mskDataNascimento.Text);
                //SEXO - RÁDIO BUTTON - F/M/N
                if (rbFeminino.Checked == true)
                {
                    cFuncionario.sexo = "F";
                }
                else if (rbMasculino.Checked)
                {
                    cFuncionario.sexo = "M";
                }
                else
                {
                    cFuncionario.sexo = "N";
                }

                cFuncionario.estado_civil = cbEstadoCivil.SelectedItem.ToString();
                cFuncionario.cpf = mskCpf.Text;
                // RG - CAMPO MÁSCARA - NÃO OBRIGATÓRIO - FAZER IF PARA NÃO IR A MÁSCARA VAZIA PARA O BD SE O USUÁRIO NÃO PROEENCHER

                if (mskRg.Text != "   .   .   -")
                {
                    cFuncionario.rg = mskRg.Text;
                }
                else
                {
                    cFuncionario.rg = "";

                }

                if (txtSalario.Text != "")

                {

                    cFuncionario.salario = Convert.ToDecimal(txtSalario.Text);

                }

                else

                {

                    cFuncionario.salario = 0;

                }
                cFuncionario.endereco = txtEndereco.Text;
                cFuncionario.numero = Convert.ToInt32(txtNumero.Text);
                cFuncionario.complemento = txtComplemento.Text;
                cFuncionario.bairro = txtBairro.Text;
                cFuncionario.cidade = txtCidade.Text;
                //ESTADO COMBOBOX -  MANDAR ITEM SELECIONADO PELO USUÁRIO
                cFuncionario.estado = cbEstado.SelectedItem.ToString();
                //MASCARA
                cFuncionario.cep = mskCpf.Text;
                //TELEFONE RESIDENCIAL - MÁSCARA NÃO OBRIGATÓRIO
                if (mskTelefoneResidencial.Text != "(  )     -")
                {
                    cFuncionario.telefone_residencial = mskTelefoneResidencial.Text;
                }
                else
                {
                    cFuncionario.telefone_residencial = "";
                }

                //TELEFONE CELULAR - MÁSCARA NÃO OBRIGATÓRIO
                if (mskTelefoneCelular.Text != "(  )     -")
                {
                    cFuncionario.telefone_celular = mskTelefoneResidencial.Text;
                }
                else
                {
                    cFuncionario.telefone_celular = "";
                }

                cFuncionario.email = txtEmail.Text;
                cFuncionario.usuario = txtUsuario.Text;
                cFuncionario.senha = txtSenha.Text;

                //TIPO DE ACESSO - COMBO - BD (CAMPO BIT) 0 COMUM 1 ADM
                if (cbTipoAcesso.SelectedItem.ToString() == "Comum")
                {
                    cFuncionario.tipo_acesso = 0; // COMUM

                }
                else
                {
                    cFuncionario.tipo_acesso = 1; //ADMINISTRADOR
                }

                cFuncionario.foto = "";

                //CARGO - COMBO - CHAVE ESTRANGEIRA - SELECTDVALUE = MANDA O VALOR DO BANCO DE DADOS
                cFuncionario.codigo_cargo = Convert.ToInt32(cbCargo.SelectedValue);


                //STATUS
                if(ckStatus.Checked)
                {
                    cFuncionario.status = 1;
                }
                else
                {
                    cFuncionario.status = 0;
                }

                //CÓDIGO FUNCIONÁRIO - PARA ALIMENTAR O WHERE DO UPDATE
                cFuncionario.codigo_funcionario = Convert.ToInt32(txtCodigoFuncionario.Text);



                //CHAMAR MÉTODO ATUALIZAR DA CLASSE FUNCIONARIO 
                int resp = cFuncionario.AtualizarFuncionario();

                //SE O CADASTRO DEU CERTO RESP = 1 
                if (resp == 1)
                {
                    MessageBox.Show("Funcionario:" + cFuncionario.nome + "atualizado com sucesso", "Sistema Drop to Paraidse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar funcionário", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else //CAMPOS OBRIGATÓRIOS
            {
                MessageBox.Show("Verificar campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.BackColor = Color.LightSteelBlue;
                gbSexo.BackColor = Color.LightSteelBlue;
                gbSexo.BackColor = Color.LightSteelBlue;
                mskCpf.BackColor = Color.LightSteelBlue;
                txtUsuario.BackColor = Color.LightSteelBlue;
                txtSenha.BackColor = Color.LightSteelBlue;
                cbTipoAcesso.BackColor = Color.LightSteelBlue;
                mskTelefoneResidencial.BackColor = Color.LightSteelBlue;
                mskTelefoneCelular.BackColor = Color.LightSteelBlue;
                mskCep.BackColor = Color.LightSteelBlue;
                txtEndereco.BackColor = Color.LightSteelBlue;
                txtNumero.BackColor = Color.LightSteelBlue;
                txtCidade.BackColor = Color.LightSteelBlue;
                txtBairro.BackColor = Color.LightSteelBlue;
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            classFuncionario cFuncionario = new classFuncionario();
            //PERGUNTAR PARA O USUARIO SE QUER EXCLUIR O FUNCIONÁRIO
            if(MessageBox.Show($"Deseja excluir o funcionário{cFuncionario.nome}?","Sistema Drop to Paradise", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                cFuncionario.codigo_funcionario = Convert.ToInt32(txtCodigoFuncionario.Text);
                //chamar o método PARA EXCLUIR
                int resp = cFuncionario.ExcluirFuncionario();
                if(resp ==1)
                {
                    MessageBox.Show($"Funcionário: {cFuncionario.nome} excluido com sucesso", "Sistema Drop To Paradise", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Sistema Drop to Paradise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar !=13 &&e.KeyChar !=32)
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Sistema Drop to Paradise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

