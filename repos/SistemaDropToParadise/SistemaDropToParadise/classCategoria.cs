using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaDropToParadise
{
    class classCategoria
    {
        public classCategoria()
        {
            codigo_categoria = 0;
            status = 0;
            nome_categoria = null;
            data_cadastro = DateTime.Now;
            observacao = null;


        }
        public int codigo_categoria { get; set; } 

        public int status { get; set; }

        public string nome_categoria { get; set; }

        public DateTime data_cadastro { get; set; }

        public string observacao { get; set; }

        public int CadastrarCategoria()
        {
            //VARIAVEL PARA ARMAZENAR O COMANDO QUE SERÁ EXECUTADO PELO BANCO
            string query = $"INSERT INTO categoria (codigo_categoria, status, nome_categoria, data_cadastro, observacao) " +
                   $"VALUES (0, 1, '{nome_categoria}', NOW(), '{observacao}')";

            //CRIAR UM OBJETO DA CLASSE CONEXAO PARA USAR O METODO QUE VAI EXECUTAR O COMANDO DO BANCO (INSERT)
            classConexao cConexao = new classConexao();
            //EXECUTA INSERT E RETORNA 0 SE DER ERRADO E 1 SE DER CERTO
            return cConexao.ExecutaQuery(query);

        }

        //CRIAR  MÉTODOS PARA CARREGAR COMBO DE CARGO NO FORM CADASTRO DE FUNCIOÁRIOS
        public DataTable BuscarCategoria()
        {
            string query = "SELECT codigo_categoria, nome_categoria FROM categoria WHERE status = 1 ORDER BY nome_categoria;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

    }
}
