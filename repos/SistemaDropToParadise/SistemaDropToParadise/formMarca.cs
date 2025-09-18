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
    public partial class formMarca : Form
    {
        public formMarca()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void Limpar()
        {
            txtNomeMarca.Clear();
            txtObservacao.Clear();
        }

        private void btcadastrar_Click(object sender, EventArgs e)
        {
            if (txtNomeMarca.Text != "")
            {
                //MANDAR O CONTEÚDO DIGITADO PELO USUÁRIO NO FORM CARGO (TODOS OS ELEMENTOS QUE O USUÁRIO PODE DIGITAR) PARA PROPRIEDADES DA CLASSE CARGO
                ClassMarca cMarca = new ClassMarca(); //OBJETO DA CLASSSE CARGO PARA USAR AS PROPRIEDADES E MÉTODO CADASTRAR DA CLASSE
                cMarca.nome_marca = txtNomeMarca.Text;
                cMarca.observacao = txtObservacao.Text;
                //CHAMAR O MÉTODO CADASTRAR DE CLASSE marca
                int resp = cMarca.CadastrarMarca();

                //VERIFICAR SE O CADASTRO FOI REALIZADO 
                if (resp == 1) //CADASTRO REALIZADO 
                {
                    MessageBox.Show("Marca:" + cMarca.nome_marca + "Cadastrado com sucesso", "Sistema Drop to Paradise", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                
                txtNomeMarca.BackColor = Color.LightSteelBlue;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void formMarca_Load(object sender, EventArgs e)
        {

        }

        private void txtObservacao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
