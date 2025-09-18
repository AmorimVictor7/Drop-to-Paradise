using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaDropToParadise
{
    class ClassCliente
    {
        public ClassCliente()
        {
            codigo_cliente = 0;
            nome = null;
            nome_social = null;
            sexo = null;
            rg = null;
            cpf = null;
            telefone_residencial = null;
            telefone_celular = null;
            cidade = null;
            estado = null;
            bairro = null;
            cep = null;
            endereco = null;
            numero = 0;
            complemento = null;
            email = null;
            status = 0;
            data_cadastro = DateTime.Now;
            data_nascimento = DateTime.Now;
           



        }

        //PROPRIEDADES
        public int codigo_cliente { get; set; }
        public string nome { get; set; }

        public string nome_social { get; set; }

       
        public string sexo { get; set; }


        public string rg { get; set; }

        public string cpf { get; set; }

 
        public string telefone_residencial { get; set; }

        public string telefone_celular { get; set; }
        public string cidade { get; set; }

        public string estado { get; set; }
        
        public string bairro { get; set; }
        public string cep { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
   
        public string email { get; set; }

        public int status { get; set; }

        public DateTime data_cadastro { get; set; }

        public DateTime data_nascimento { get; set; }




        //MÉTODOS

        //METODOS PARA CADASTRAR FUNCIONÁRIO
        //NÃO PODE MANDAR ASPAS SIMPLES EM CAMPOS DO TIPO BIT
        //CAMPOS DATE: propriedade.ToString("yyyy-MM-dd")
        //CAMPOS DECIMAL: propriedqade.ToString().Replace("," ,".")
        public int CadastrarCliente()
        {
            //CRIAR VARIAVEL PARA ARMAZENAR O INSERT
            string query = " INSERT INTO cliente VALUES(0, '" + nome + "', '" + nome_social + "','" + sexo + "', '" + rg + "','" + cpf + "',  '" + telefone_residencial + "','" + telefone_celular + "',  '" + cidade + "', '" + estado + "', '" + bairro + "', '" + cep + "','" + endereco + "'," + numero + ",'" + complemento + "',  '" + email + "', 1,NOW(), '" + data_nascimento.ToString("yyyy-MM-dd") + "')";

            //CLASSE CONEXÃO
            classConexao cConexao = new classConexao();
            //CHAMA O MÉTODO QUE VAI EXECUTAR O COMANDO 
            return cConexao.ExecutaQuery(query);

        }

        public DataTable ConsClienteCidade(string cidade)
        {
            string query = "SELECT cliente.codigo_cliente 'COD', cliente.CPF 'CPF', cliente.nome 'NOME', cliente.sexo 'SEXO', cliente.cidade  'CIDADE' FROM cliente WHERE cliente.status = 1 AND cliente.cidade = '" + cidade + "'";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);

        }

        public DataTable ConsClienteSexo(string sexo)
        {
            string query = "SELECT cliente.codigo_cliente 'COD', cliente.CPF 'CPF', cliente.nome 'NOME', cliente.sexo 'SEXO', cliente.cidade  'CIDADE' FROM cliente WHERE cliente.status = 1 AND cliente.sexo ='" + sexo + "' ";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }
        public DataTable ConsClienteCpf(string cpf)
        {
            string query = "SELECT cliente.codigo_cliente 'COD', cliente.CPF 'CPF', cliente.nome 'NOME', cliente.sexo 'SEXO', cliente.cidade  'CIDADE' FROM cliente WHERE cliente.status = 1 AND cliente.cpf  = '" + cpf + "'";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }
        public DataTable ConsClienteStatus(int status)
        {
            string query = "SELECT cliente.codigo_cliente 'COD', cliente.CPF 'CPF', cliente.nome 'NOME', cliente.sexo 'SEXO', cliente.cidade  'CIDADE' FROM cliente WHERE cliente.status =  " + status + "";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable ConsClienteEstado(string estado)
        {
            string query = "SELECT cliente.codigo_cliente 'COD', cliente.CPF 'CPF', cliente.nome 'NOME', cliente.sexo 'SEXO', cliente.cidade  'CIDADE' FROM cliente WHERE cliente.status = 1 AND cliente.estado ='" + estado + "'";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable ConsClienteNomeInicio(string nomeInicio)
        {
            string query = "SELECT cliente.codigo_cliente 'COD', cliente.CPF 'CPF', cliente.nome 'NOME', cliente.sexo 'SEXO', cliente.cidade  'CIDADE' FROM cliente WHERE cliente.status = 1 AND cliente.nome LIKE '" + nomeInicio + "%' ORDER BY cliente.nome;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);

        }


        // CONSULTA DE FUNCIONÁRIO POR NOME CONTÉM
        public DataTable ConsClienteNomeContem(string nomeContem)
        {
            string query = "SELECT cliente.codigo_cliente 'COD', cliente.CPF 'CPF', cliente.nome 'NOME', cliente.sexo 'SEXO', cliente.cidade  'CIDADE' FROM cliente WHERE cliente.status = 1 AND cliente.nome LIKE '%" + nomeContem + "%' ORDER BY cliente.nome;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);

        }


        public int AtualizarCliente()
        {
            
            string query = "UPDATE cliente SET nome = '"+ nome +"', nome_social = '" + nome_social + "',  sexo = '" + sexo + "',  rg =  '" + rg + "', cpf = '" + cpf + "', telefone_residencial = '" + telefone_residencial + "', telefone_celular = '" + telefone_celular + "',  cidade = '" + cidade + "', estado = '" + estado + "', bairro = '" + bairro + "',  cep = '" + cep + "',  endereco = '" + endereco + "', numero = " + numero + ", complemento = '" + complemento + "', email = '" + email + "', status =  " + status + ",  data_nascimento = '" + data_nascimento.ToString("yyyy-MM-dd") + "' WHERE codigo_cliente = " + codigo_cliente + ";";
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);

        }

        public int ExcluirCliente()
        {
            string query = " DELETE FROM cliente WHERE codigo_cliente = " + codigo_cliente + "; ";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }

        public bool ConsultaCliente(int cod)
        {
            //EXIBIR TODOS OS DADOS DO FUNCIONÁRIO ESCOLHIDO PELO USUÁRIO NA GRID DE CONSULTA
            string query = "SELECT * FROM cliente WHERE codigo_cliente =" + cod + " ";

            classConexao cConexao = new classConexao();
            //MONTAR O DATA TABLE - RECEBER TODOS OS DADOS DO BANCO QUE DEPOIS SERÃO EXIBIDOS NOS CAMPOS DO FORM DE CADASTRO/ATUALIZAÇÃO DO FUNCIONÁRIO
            DataTable dt = cConexao.RetornaDados(query);

            //SE A CONSULTA DER CERTO 
            if (dt.Rows.Count > 0)
            {
                codigo_cliente = Convert.ToInt32(dt.Rows[0]["codigo_cliente"]);
                nome = Convert.ToString(dt.Rows[0]["nome"]);
                nome_social = Convert.ToString(dt.Rows[0]["nome_social"]);
                data_nascimento = Convert.ToDateTime(dt.Rows[0]["data_nascimento"]);
                sexo = Convert.ToString(dt.Rows[0]["sexo"]);
                cpf = Convert.ToString(dt.Rows[0]["cpf"]);
                rg = Convert.ToString(dt.Rows[0]["rg"]);        
                endereco = Convert.ToString(dt.Rows[0]["endereco"]);
                numero = Convert.ToInt32(dt.Rows[0]["numero"]);
                complemento = Convert.ToString(dt.Rows[0]["complemento"]);
                bairro = Convert.ToString(dt.Rows[0]["bairro"]);
                cidade = Convert.ToString(dt.Rows[0]["cidade"]);
                estado = Convert.ToString(dt.Rows[0]["estado"]);
                cep = Convert.ToString(dt.Rows[0]["cep"]);
                telefone_residencial = Convert.ToString(dt.Rows[0]["telefone_residencial"]);
                telefone_celular = Convert.ToString(dt.Rows[0]["telefone_celular"]);
                email = Convert.ToString(dt.Rows[0]["email"]);
                status = Convert.ToInt32(dt.Rows[0]["status"]);
                data_cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);
               

                return true;
            }
            else
            {
                return false;
            }
        }

        //MÉTODO PARA CARREGAR A COMBO DE CIDADE NO FORM DE CONSULTA 

        public DataTable BuscarCidade()
        {
            string query = " SELECT DISTINCT cidade FROM cliente WHERE status = 1 ORDER BY cidade;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable BuscarEstado()
        {
            string query = " SELECT DISTINCT estado FROM cliente WHERE status = 1 ORDER BY estado;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable RelClienteStatus(int status)
        {
            string query = "SELECT cliente.codigo_cliente, cliente.cpf, cliente.data_nascimento, cliente.data_cadastro, cliente.cidade, cliente.estado, cliente.nome, cliente.sexo , cliente.cidade  FROM cliente WHERE cliente.status =  " + status + " ORDER BY cliente.nome;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable RelClienteSexo(string sexo)
        {
            string query = "SELECT cliente.codigo_cliente, cliente.cpf, cliente.data_nascimento, cliente.data_cadastro, cliente.cidade, cliente.estado, cliente.nome, cliente.sexo , cliente.cidade  FROM cliente WHERE cliente.status = 1 AND cliente.sexo = '" + sexo + "' ORDER BY cliente.nome;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable RelClienteAdmissao(DateTime dataInicio, DateTime dataFinal)
        {
            string query = "SELECT cliente.codigo_cliente, cliente.cpf, cliente.data_nascimento, cliente.data_cadastro, cliente.cidade, cliente.estado, cliente.nome, cliente.sexo , cliente.cidade  FROM cliente WHERE cliente.status = 1 AND cliente.data_cadastro BETWEEN '" + dataInicio.ToString("yyyy-MM-dd") + "' AND '" + dataFinal.ToString("yyyy-MM-dd") + "' ORDER BY cliente.nome;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable RelClienteCidade(string cidade)
        {
            string query = "SELECT cliente.codigo_cliente, cliente.cpf, cliente.data_nascimento, cliente.data_cadastro, cliente.cidade, cliente.estado, cliente.nome, cliente.sexo , cliente.cidade  FROM cliente WHERE cliente.status = 1 AND cliente.cidade = '" + cidade + "' ORDER BY cliente.nome;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable RelClienteEstado(string estado)
        {
            string query = "SELECT cliente.codigo_cliente, cliente.cpf, cliente.data_nascimento, cliente.data_cadastro, cliente.cidade, cliente.estado, cliente.nome, cliente.sexo , cliente.cidade  FROM cliente WHERE cliente.status = 1 AND cliente.estado = '" + estado + "' ORDER BY cliente.nome;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable RelClienteMesAniversario(int mes)
        {
            string query = "SELECT cliente.codigo_cliente, cliente.cpf, cliente.data_nascimento, cliente.data_cadastro, cliente.cidade, cliente.estado, cliente.nome, cliente.sexo , cliente.cidade  FROM cliente WHERE cliente.status = 1 AND MONTH(cliente.data_nascimento) =" + mes + " ORDER BY cliente.nome;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable RelClienteIdade(int idadei, int idadef)
        {
            string query = "SELECT cliente.codigo_cliente, cliente.cpf, cliente.data_nascimento, cliente.data_cadastro, cliente.cidade, cliente.estado, cliente.nome, cliente.sexo , cliente.cidade  FROM cliente WHERE cliente.status = 1 AND TIMESTAMPDIFF (YEAR, cliente.data_nascimento, NOW()) BETWEEN " + idadei + " AND " + idadef + " ORDER BY cliente.nome;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable CarregaGridCliente(string nomeC)
        {
            string query = "SELECT cliente.codigo_cliente 'COD', cliente.CPF 'CPF', cliente.nome 'NOME' FROM cliente WHERE cliente.status = 1 AND cliente.nome LIKE '%" + nomeC + "%' ORDER BY cliente.nome;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);

        }
    } 

}