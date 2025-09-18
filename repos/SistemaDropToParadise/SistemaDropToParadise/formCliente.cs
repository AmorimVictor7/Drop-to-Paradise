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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public string tipo, estado;
        public DateTime data_cad;

        private void FormCliente_Load(object sender, EventArgs e)
        {
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

            if (tipo == "Atualização")
            {
                lbDataCadastro.Text = data_cad.ToString();
                ckStatus.Enabled = true;
                lbTitulo.Text = "Atualização de Cliente";
                cbEstado.SelectedItem = estado;
                btcadastrar.Enabled = false;

      

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
            mskRg.Clear();
            mskCpf.Clear();
            mskcep.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            cbEstado.SelectedItem = "SP";
            mskTelefoneResidencial.Clear();
            mskTelefoneCelular.Clear();
            txtEmail.Clear();
            txtNome.Clear();
        }

        public void CamposObrigatorios()
        {
            txtNome.BackColor = Color.LightSteelBlue;
            gbsexo.BackColor = Color.LightSteelBlue;
            mskCpf.BackColor = Color.LightSteelBlue;
            mskTelefoneResidencial.BackColor = Color.LightSteelBlue;
            mskTelefoneCelular.BackColor = Color.LightSteelBlue;
            mskcep.BackColor = Color.LightSteelBlue;
            txtEndereco.BackColor = Color.LightSteelBlue;
            txtNumero.BackColor = Color.LightSteelBlue;
            txtCidade.BackColor = Color.LightSteelBlue;
            txtBairro.BackColor = Color.LightSteelBlue;
        }



        private void btcadastrar_Click(object sender, EventArgs e)
        {
            ClassCliente cCliente = new ClassCliente();
            //VERIFICAR SE TODOS OS CAMPOS OBRIGATÓRIOS FORAM PREENCHIDOS 
            if (txtNome.Text != "" && mskDataNascimento.Text != " /  /" && mskCpf.Text != "   .   .   -" && txtEndereco.Text != "" && txtNumero.Text != "" && txtBairro.Text != "" && txtCidade.Text != "" && (mskTelefoneResidencial.Text != "(  )   -" || mskTelefoneCelular.Text != "(  )   -") )
            {
                //LERAS CAIXINHAS DO FORM E MANDAR PARA AS PROPRIEDADES DA CLASSE FUNCIONÁRIO
                cCliente.nome = txtNome.Text;
                cCliente.nome_social = txtNomeSocial.Text;
                cCliente.data_nascimento = Convert.ToDateTime(mskDataNascimento.Text);
                //SEXO - RÁDIO BUTTON - F/M/N
                if (rbFeminino.Checked == true)
                {
                    cCliente.sexo = "F";
                }
                else if (rbMasculino.Checked)
                {
                    cCliente.sexo = "M";
                }
                else
                {
                    cCliente.sexo = "N";
                }

                cCliente.cpf = mskCpf.Text;
                // RG - CAMPO MÁSCARA - NÃO OBRIGATÓRIO - FAZER IF PARA NÃO IR A MÁSCARA VAZIA PARA O BD SE O USUÁRIO NÃO PROEENCHER

                if (mskRg.Text != "   .   .   -")
                {
                    cCliente.rg = mskRg.Text;
                }
                else
                {
                    cCliente.rg = "";

                }


                cCliente.endereco = txtEndereco.Text;
                cCliente.numero = Convert.ToInt32(txtNumero.Text);
                cCliente.complemento = txtComplemento.Text;
                cCliente.bairro = txtBairro.Text;
                cCliente.cidade = txtCidade.Text;
                //ESTADO COMBOBOX -  MANDAR ITEM SELECIONADO PELO USUÁRIO
                cCliente.estado = cbEstado.SelectedItem.ToString();
                //MASCARA
                cCliente.cep = mskcep.Text;
                //TELEFONE RESIDENCIAL - MÁSCARA NÃO OBRIGATÓRIO
                if (mskTelefoneResidencial.Text != "(  )     -")
                {
                    cCliente.telefone_residencial = mskTelefoneResidencial.Text;
                }
                else
                {
                    cCliente.telefone_residencial = "";
                }

                //TELEFONE CELULAR - MÁSCARA NÃO OBRIGATÓRIO
                if (mskTelefoneCelular.Text != "(  )     -")
                {
                    cCliente.telefone_celular = mskTelefoneCelular.Text;

                }
                else
                {
                    cCliente.telefone_celular = "";
                }

                cCliente.email = txtEmail.Text;


                int resp = cCliente.CadastrarCliente();


                //SE O CADASTRO DEU CERTO RESP = 1 
                if (resp == 1)
                {
                    MessageBox.Show("Cliente:" + cCliente.nome + "cadastrado com sucesso", "Sistema Drop to Paradise", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Cliente", "atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else //CAMPOS OBRIGATÓRIOS
            {
                MessageBox.Show("Verificar campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CamposObrigatorios();


            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAtualizar_Click(object sender, EventArgs e)
        {
           ClassCliente cCliente = new ClassCliente();
            //VERIFICAR SE TODOS OS CAMPOS OBRIGATÓRIOS FORAM PREENCHIDOS 
            if (txtNome.Text != "" && mskDataNascimento.Text != " /  /" && mskCpf.Text != "   .   .   -" && txtEndereco.Text != "" && txtNumero.Text != "" && txtBairro.Text != "" && txtCidade.Text != "" && (mskTelefoneResidencial.Text != "(  )   -" || mskTelefoneCelular.Text != "(  )   -"))
            {
                //LERAS CAIXINHAS DO FORM E MANDAR PARA AS PROPRIEDADES DA CLASSE FUNCIONÁRIO
                cCliente.nome = txtNome.Text;
                cCliente.nome_social = txtNomeSocial.Text;
                cCliente.data_nascimento = Convert.ToDateTime(mskDataNascimento.Text);
                //SEXO - RÁDIO BUTTON - F/M/N
                if (rbFeminino.Checked == true)
                {
                    cCliente.sexo = "F";
                }
                else if (rbMasculino.Checked)
                {
                    cCliente.sexo = "M";
                }
                else
                {
                    cCliente.sexo = "N";
                }

               
                cCliente.cpf = mskCpf.Text;
                // RG - CAMPO MÁSCARA - NÃO OBRIGATÓRIO - FAZER IF PARA NÃO IR A MÁSCARA VAZIA PARA O BD SE O USUÁRIO NÃO PROEENCHER

                if (mskRg.Text != "   .   .   -")
                {
                    cCliente.rg = mskRg.Text;
                }
                else
                {
                    cCliente.rg = "";

                }

               
                cCliente.endereco = txtEndereco.Text;
                cCliente.numero = Convert.ToInt32(txtNumero.Text);
                cCliente.complemento = txtComplemento.Text;
                cCliente.bairro = txtBairro.Text;
                cCliente.cidade = txtCidade.Text;
                //ESTADO COMBOBOX -  MANDAR ITEM SELECIONADO PELO USUÁRIO
                cCliente.estado = cbEstado.SelectedItem.ToString();
                //MASCARA
                cCliente.cep = mskcep.Text;
                //TELEFONE RESIDENCIAL - MÁSCARA NÃO OBRIGATÓRIO
                if (mskTelefoneResidencial.Text != "(  )     -")
                {
                    cCliente.telefone_residencial = mskTelefoneResidencial.Text;
                }
                else
                {
                    cCliente.telefone_residencial = "";
                }

                //TELEFONE CELULAR - MÁSCARA NÃO OBRIGATÓRIO
                if (mskTelefoneCelular.Text != "(  )     -")
                {
                    cCliente.telefone_celular = mskTelefoneResidencial.Text;
                }
                else
                {
                    cCliente.telefone_celular = "";
                }

                cCliente.email = txtEmail.Text;

                //STATUS
                if (ckStatus.Checked)
                {
                    cCliente.status = 1;
                }
                else
                {
                    cCliente.status = 0;
                }

                //CÓDIGO FUNCIONÁRIO - PARA ALIMENTAR O WHERE DO UPDATE
                cCliente.codigo_cliente = Convert.ToInt32(txtCodigoCliente.Text);



                //CHAMAR MÉTODO ATUALIZAR DA CLASSE FUNCIONARIO 
                int resp = cCliente.AtualizarCliente();

                //SE O CADASTRO DEU CERTO RESP = 1 
                if (resp == 1)
                {
                    MessageBox.Show("Cliente:" + cCliente.nome + "atualizado com sucesso", "Sistema Drop to Paraidse", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar Cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else //CAMPOS OBRIGATÓRIOS
            {
                MessageBox.Show("Verificar campos obrigatórios", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.BackColor = Color.LightSteelBlue;
               
                gbsexo.BackColor = Color.LightSteelBlue;
                mskCpf.BackColor = Color.LightSteelBlue;
                mskTelefoneResidencial.BackColor = Color.LightSteelBlue;
                mskTelefoneCelular.BackColor = Color.LightSteelBlue;
                mskcep.BackColor = Color.LightSteelBlue;
                txtEndereco.BackColor = Color.LightSteelBlue;
                txtNumero.BackColor = Color.LightSteelBlue;
                txtCidade.BackColor = Color.LightSteelBlue;
                txtBairro.BackColor = Color.LightSteelBlue;
            }
        }

        private void dataNascimento_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
                MessageBox.Show("Data Inválida.", "Sistema Drop to Paradise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

       
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Sistema Drop to Paradise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            ClassCliente cCliente = new ClassCliente();
            //PERGUNTAR PARA O USUARIO SE QUER EXCLUIR O FUNCIONÁRIO
            if (MessageBox.Show($"Deseja excluir o Cliente{cCliente.nome}?", "Sistema Drop to Paradise", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cCliente.codigo_cliente = Convert.ToInt32(txtCodigoCliente.Text);
                //chamar o método PARA EXCLUIR
                int resp = cCliente.ExcluirCliente();
                if (resp == 1)
                {
                    MessageBox.Show($"Cliente: {cCliente.nome} excluido com sucesso", "Sistema Drop To Paradise", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }

}
