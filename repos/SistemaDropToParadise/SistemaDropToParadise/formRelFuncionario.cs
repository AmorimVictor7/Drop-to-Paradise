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
    public partial class formRelFuncionario : Form
    {
        public formRelFuncionario()
        {
            InitializeComponent();
        }

        private void formRelFuncionario_Load(object sender, EventArgs e)
        {
            //CARREGAR COMBO TIPO DE RELATÓRIO
            cbTipoRel.Items.Add("Aniversariantes do Mês");
            cbTipoRel.Items.Add("Funcionários por Idade");
            cbTipoRel.Items.Add("Cargo");
            cbTipoRel.Items.Add("Cidade");
            cbTipoRel.Items.Add("Data de Admissão");
            cbTipoRel.Items.Add("Sexo");
            cbTipoRel.Items.Add("Status");
            cbTipoRel.SelectedIndex = 2;

            //CARREGAR COMBO MÊS
            cbMes.Items.Add("Escolha um Mês");
            cbMes.Items.Add("Janeiro");
            cbMes.Items.Add("Fevereiro");
            cbMes.Items.Add("Março");
            cbMes.Items.Add("Abril");
            cbMes.Items.Add("Maio");
            cbMes.Items.Add("Junho");
            cbMes.Items.Add("Julho");
            cbMes.Items.Add("Agosto");
            cbMes.Items.Add("Setembro");
            cbMes.Items.Add("Outubro");
            cbMes.Items.Add("Novembro");
            cbMes.Items.Add("Dezembro");
            cbMes.SelectedIndex = 0;

            //CARREGAR COMBO SEXO
            cbSexo.Items.Add("Escolha um Sexo");
            cbSexo.Items.Add("Feminino");
            cbSexo.Items.Add("Masculino");
            cbSexo.Items.Add("Não Informado");
            cbSexo.SelectedIndex = 0;

            //COMBO CARGO
            ClassCargo cCargo = new ClassCargo();
            cbCargo.DataSource = cCargo.BuscarCargo();
            cbCargo.DisplayMember = "nome_cargo";
            cbCargo.ValueMember = "codigo_cargo";
            cbCargo.SelectedIndex = -1;

            classFuncionario cFuncionario = new classFuncionario();
            cbCidade.DataSource = cFuncionario.BuscarCidade();
            cbCidade.DisplayMember = "cidade";
            cbCidade.ValueMember = "cidade";
            cbCidade.SelectedIndex = -1;

            this.rptvFuncionario.RefreshReport();
          
        }

        private void cbTipoRel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoRel.SelectedIndex == 0)//Aniversariantes do Mês
            {
                gbAniversariantes.Enabled = true;
                gbIdade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCargo.Enabled = false;
                gbCidade.Enabled = false;
            }
            if (cbTipoRel.SelectedIndex == 1)//Funcionários por Idade
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = true;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCargo.Enabled = false;
                gbCidade.Enabled = false;
            }
            if (cbTipoRel.SelectedIndex == 2)//Cargo
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCargo.Enabled = true;
                gbCidade.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 3)//Cidade
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCargo.Enabled = false;
                gbCidade.Enabled = true;
            }

            if (cbTipoRel.SelectedIndex == 4)//Data de Admissão
            {
                gbAniversariantes.Enabled = false;
                gbDataAdmissao.Enabled = true;
                gbStatus.Enabled = false;
                gbSexo.Enabled = false;
                gbCargo.Enabled = false;
                gbCidade.Enabled = false;
            }

            if (cbTipoRel.SelectedIndex == 5)//Sexo
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = false;
                gbSexo.Enabled = true;
                gbCargo.Enabled = false;
                gbCidade.Enabled = false;
            }
            if (cbTipoRel.SelectedIndex == 6)//Status
            {
                gbAniversariantes.Enabled = false;
                gbIdade.Enabled = false;
                gbDataAdmissao.Enabled = false;
                gbStatus.Enabled = true;
                gbSexo.Enabled = false;
                gbCargo.Enabled = false;
                gbCidade.Enabled = false;
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja fechar?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btGerarRelatorio_Click(object sender, EventArgs e)
        {
            classFuncionario cFuncionario = new classFuncionario();

            int relatorio = Convert.ToInt32(cbTipoRel.SelectedIndex);

            switch(relatorio)
            {
                case 0:
                    if(cbMes.SelectedIndex!= 0)
                    {
                        classFuncionarioBindingSource.DataSource = cFuncionario.RelFuncionarioMesAniversario(cbMes.SelectedIndex);
                        this.rptvFuncionario.RefreshReport();
                    }
                    else
                    {
                        MessageBox.Show("Favor escolher um um mês", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        gbAniversariantes.BackColor = Color.Lavender;
                    }
                    break;

                case 1:
                    if(txtIdadeInicial.Text!="" && txtIdadeFinal.Text!="")
                    {
                        classFuncionarioBindingSource.DataSource = cFuncionario.RelFuncionarioIdade(Convert.ToInt32(txtIdadeInicial.Text),Convert.ToInt32(txtIdadeFinal.Text)); 
                        this.rptvFuncionario.RefreshReport();

                    }
                    else
                    {
                        MessageBox.Show("Favor informar idade inicial e idade final", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        gbIdade.BackColor = Color.Lavender;
                        txtIdadeInicial.Focus();
                    }
                    break;

                case 2:
                    if (cbCargo.SelectedIndex != -1)
                    {
                        classFuncionarioBindingSource.DataSource = cFuncionario.RelFuncionarioCargo(Convert.ToInt32(cbCargo.SelectedValue));
                        this.rptvFuncionario.RefreshReport();
                    }

                    else
                    {
                        MessageBox.Show("Favor escolher um cargo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        gbCargo.BackColor = Color.LightSteelBlue;

                    }
                    break;

                case 3:
                    if (cbCidade.SelectedIndex != -1)
                    {
                        classFuncionarioBindingSource.DataSource = cFuncionario.RelFuncionarioCidade(cbCidade.SelectedValue.ToString());
                        this.rptvFuncionario.RefreshReport();
                    }

                    else
                    {
                        MessageBox.Show("Favor escolher uma cidade", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        gbCidade.BackColor = Color.LightSteelBlue;

                    }

                    break;

                case 4:
                    classFuncionarioBindingSource.DataSource = cFuncionario.RelFuncionarioAdmissao(Convert.ToDateTime(dtpDataInicial.Text), Convert.ToDateTime(dtpDataFinal.Text));
                    this.rptvFuncionario.RefreshReport();
                    break;

                case 5:

                    if (cbSexo.SelectedItem.ToString() == "Masculino")
                    {
                        classFuncionarioBindingSource.DataSource = cFuncionario.RelFuncionarioSexo("M");
                        this.rptvFuncionario.RefreshReport();
                    }
                    else if (cbSexo.SelectedItem.ToString() == "Feminino")
                    {
                        classFuncionarioBindingSource.DataSource = cFuncionario.RelFuncionarioSexo("F");
                        this.rptvFuncionario.RefreshReport();
                    }
                    else
                    {
                        classFuncionarioBindingSource.DataSource = cFuncionario.RelFuncionarioSexo("N");
                        this.rptvFuncionario.RefreshReport();
                    }
                    

                    break;

                case 6:
                    if (rbAtivo.Checked)
                    {
                        classFuncionarioBindingSource.DataSource = cFuncionario.RelFuncionarioStatus(1);
                        this.rptvFuncionario.RefreshReport();
                    }
                    else
                    {
                        classFuncionarioBindingSource.DataSource = cFuncionario.RelFuncionarioStatus(0);
                        this.rptvFuncionario.RefreshReport();
                    }
                    break;
            }
        }

        private void gbIdade_Enter(object sender, EventArgs e)
        {

        }

        private void rptvFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void txtIdadeInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Sistema Drop to Paradise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtIdadeFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08 && e.KeyChar != 13 && e.KeyChar != 32)
            {
                e.Handled = true;
                MessageBox.Show("Este Campo aceita apenas Números!", "Sistema Drop to Paradise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
