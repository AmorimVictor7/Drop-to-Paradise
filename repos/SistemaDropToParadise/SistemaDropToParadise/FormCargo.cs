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
    public partial class FormCargo : Form
    {
        public FormCargo()
        {
            InitializeComponent();

            //AQUI É PARA QUANDO CLICAR NO FORMS ELE SEJA INICIADO NO CENTRO DA TELA
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        
        //METODO LIMPAR
        public void Limpar()
        {
            txtNomeCargo.Clear();
            txtObservacao.Clear();
        }

        private void btcadastrar_Click(object sender, EventArgs e)
        {
            //VALIDAR OS CAMPOS OBRIGATÓRIOS
            if(txtNomeCargo.Text != "")
            {
                //MANDAR O CONTEÚDO DIGITADO PELO USUÁRIO NO FORM CARGO (TODOS OS ELEMENTOS QUE O USUÁRIO PODE DIGITAR) PARA PROPRIEDADES DA CLASSE CARGO
             
                ClassCargo cCargo = new ClassCargo();  //OBJETO DA CLASSSE CARGO PARA USAR AS PROPRIEDADES E MÉTODO CADASTRAR DA CLASSE
                cCargo.nome_cargo = txtNomeCargo.Text;
                cCargo.observacao = txtObservacao.Text;

                //CHAMAR O MÉTODO CADASTRAR DE CLASSE CARGO
                int resp = cCargo.CadastrarCargo();

                //VERIFICAR SE O CADASTRO FOI REALIZADO 
                if(resp == 1) //CADASTRO REALIZADO 
                {
                    MessageBox.Show("Cargo:" + cCargo.nome_cargo + "Cadastro com sucesso", "Sistema Drop to Paradise", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                }
                else // CADASTRO NAO FOI REALIZADO RESP 0
                {
                    MessageBox.Show("erro ao realizar cadastro", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else //CAMPOS OBRIGATÓRIOS - USUÁRIO NÃO PREENCHEU TODOS OS CAMPOS
            {
                MessageBox.Show("Favor preencher todos os campos obrigatórios", "atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeCargo.BackColor = Color.LightSteelBlue; 
            }
        }

        //\BOTAO PARA SAIR
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
