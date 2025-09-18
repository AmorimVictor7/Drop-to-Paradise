using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaDropToParadise
{
    class ClassMarca
    {
        public ClassMarca()
        {
            codigo_marca = 0;
            status = 0;
            nome_marca = null;
            data_cadastro = DateTime.Now;
            observacao = null;


        }
        public int codigo_marca { get; set; }

        public int status { get; set; }

        public string nome_marca { get; set; }

        public DateTime data_cadastro { get; set; }

        public string observacao { get; set; }

        public int CadastrarMarca()
        {
            //VARIAVEL PARA ARMAZENAR O COMANDO QUE SERÁ EXECUTADO PELO BANCO
            string query = $"INSERT INTO marca (codigo_marca, status, nome_marca, data_cadastro, observacao) " +
                   $"VALUES (0, 1, '{nome_marca}', NOW(), '{observacao}')";

            //CRIAR UM OBJETO DA CLASSE CONEXAO PARA USAR O METODO QUE VAI EXECUTAR O COMANDO DO BANCO (INSERT)
            classConexao cConexao = new classConexao();
            //EXECUTA INSERT E RETORNA 0 SE DER ERRADO E 1 SE DER CERTO
            return cConexao.ExecutaQuery(query);

        }

        //CRIAR  MÉTODOS PARA CARREGAR COMBO DE CARGO NO FORM CADASTRO 
        public DataTable BuscarMarca()
        {
            string query = "SELECT codigo_marca, nome_marca FROM marca WHERE status = 1 ORDER BY nome_marca;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }
    }
}
