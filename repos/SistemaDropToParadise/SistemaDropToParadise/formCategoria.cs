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
    public partial class formCategoria : Form
    {
        public formCategoria()
        {
            InitializeComponent();
            //METODO PARA INICIAR O FORMS NO MEIO DA TELA
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        //METODO LIMPAR
        public void Limpar()
        {
            txtNomeCategoria.Clear();
            txtObservacao.Clear();
        }

        //BOTAO CADASTRAR
        private void btcadastrar_Click(object sender, EventArgs e)
        {
            //VALIDAR OS CAMPOS OBRIGATÓRIOS
            if (txtNomeCategoria.Text != "")
            {
                //MANDAR O CONTEÚDO DIGITADO PELO USUÁRIO NO FORM CARGO (TODOS OS ELEMENTOS QUE O USUÁRIO PODE DIGITAR) PARA PROPRIEDADES DA CLASSE CARGO
                classCategoria cCategoria = new classCategoria(); //OBJETO DA CLASSSE CARGO PARA USAR AS PROPRIEDADES E MÉTODO CADASTRAR DA CLASSE
                cCategoria.nome_categoria = txtNomeCategoria.Text;
                cCategoria.observacao = txtObservacao.Text;
                //CHAMAR O MÉTODO CADASTRAR DE CLASSE CARGO
                int resp = cCategoria.CadastrarCategoria();

                //VERIFICAR SE O CADASTRO FOI REALIZADO 
                if (resp == 1) //CADASTRO REALIZADO 
                {
                    MessageBox.Show("Categoria:" + cCategoria.nome_categoria + "Cadastro com sucesso", "Sistema Drop to Paradise", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
               
                txtNomeCategoria.BackColor = Color.LightSteelBlue;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
