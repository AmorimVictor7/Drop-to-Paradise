using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaDropToParadise
{
    class ClassCargo
    {
        //CONSTRUTOR DA CLASSE
        //TEM QUE TER O MESMO NOME DO ELEMENTO QUE ESTOU MANIPULANDO - CLASSE
        //INICIALIZAR TODAS AS PROPRIEDADES E MÉTODOS DA CLASSE
        //INICIALIZAR TODAS AS PROPRIEDADES E MÉTODOS DA CLASSE
        public ClassCargo() //CONSTRUTOR DA CLASSE
        {
            codigo_cargo = 0;
            observacao = null;
            status = 0;
            data_cadastro = DateTime.Now; //1900/01/
            nome_cargo = null;

        }

        //PROPRIEDADES (ATRIBUTOS) DA CLASS
        //LER E GRAVAR OS DADOS NO BD
        //NOME DAS PROPRIEDADES TEM QUE SER IGUAL  O NOME DOS CAMPOS DO BD
        //ATALHO PARA CRIAR VS CRIAR AS PROPRIEDADES PROP TAB TAB
        
        public int codigo_cargo { get; set; }

        public string observacao { get; set; }

        public int status { get; set; }

        public DateTime data_cadastro { get; set; }

        public string nome_cargo { get; set; }

        //MÉTODOS
        //TIPO DO MÉTODO - TIPO DE RETORNO OU VOID - NOME DO MÉTODO - PARÂMETROS()
        //MÉTODO PARA CADASTRAR CARGO

        public int CadastrarCargo()
        {
            //VARIAVEL PARA ARMAZENAR O COMANDO QUE SERÁ EXECUTADO PELO BANCO
            string query = "INSERT INTO cargo VALUES(0, '"+observacao+"', 1, NOW(),'"+nome_cargo+"')";
            //CRIAR UM OBJETO DA CLASSE CONEXAO PARA USAR O METODO QUE VAI EXECUTAR O COMANDO DO BANCO (INSERT)
            classConexao cConexao = new classConexao();
            //EXECUTA INSERT E RETORNA 0 SE DER ERRADO E 1 SE DER CERTO
            return cConexao.ExecutaQuery(query);

        }

        //CRIAR MÉTODOS PARA CARREGAR COMBO DE CARGO NO FORM CADASTRO DE FUNCIONÁRIOS
        public DataTable BuscarCargo()
        {
            string query = "SELECT codigo_cargo, nome_cargo FROM cargo WHERE status = 1 ORDER BY nome_cargo;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }


    }
}
