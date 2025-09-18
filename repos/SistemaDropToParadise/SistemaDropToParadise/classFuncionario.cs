using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaDropToParadise
{
    class classFuncionario
    {
        //CONTRUTOR

        public classFuncionario()
        {
            codigo_funcionario = 0;
            nome = null;
            nome_social = null;
            data_nascimento = DateTime.Now;
            sexo = null;
            estado_civil = null;
            cpf = null;
            rg = null;
            salario = 0; //99999.99
            endereco = null;
            numero = 0;
            complemento = null;
            bairro = null;
            cidade = null;
            estado = null;
            cep = null;
            telefone_residencial = null;
            telefone_celular = null;
            email = null;
            status = 0;
            data_cadastro = DateTime.Now;
            usuario = null;
            senha = null;
            tipo_acesso = 0;
            foto = null;
            codigo_cargo = 0;



        }

        //PROPRIEDADES
        public int codigo_funcionario { get; set; }
        public string nome { get; set; }

        public string nome_social { get; set; }

        public DateTime data_nascimento { get; set; }

        public string sexo { get; set; }

        public string estado_civil { get; set; }

        public string cpf { get; set; }

        public string rg { get; set; }

        public decimal salario { get; set; }

        public string endereco { get; set; }

        public int numero { get; set; }

        public string complemento { get; set; }

        public string bairro { get; set; }

        public string cidade { get; set; }

        public string estado { get; set; }
        public string cep { get; set; }

        public string telefone_residencial { get; set; }

        public string telefone_celular { get; set; }

        public string email { get; set; }

        public int status { get; set; }

        public DateTime data_cadastro { get; set; }

        public string usuario { get; set; }

        public string senha { get; set; }

        public int tipo_acesso { get; set; }

        public string foto { get; set; }

        public int codigo_cargo { get; set; }

        //MÉTODOS

        //METODOS PARA CADASTRAR FUNCIONÁRIO
        //NÃO PODE MANDAR ASPAS SIMPLES EM CAMPOS DO TIPO BIT
        //CAMPOS DATE: propriedade.ToString("yyyy-MM-dd")
        //CAMPOS DECIMAL: propriedqade.ToString().Replace("," ,".")
        public int CadastrarFuncionario()
        {
            //CRIAR VARIAVEL PARA ARMAZENAR O INSERT
            string query = " INSERT INTO funcionario VALUES(0, '" + nome + "', '" + nome_social + "', '" + data_nascimento.ToString("yyyy-MM-dd") + "', '" + sexo + "', '" + cpf + "','" + rg + "','" + estado_civil + "', '" + telefone_residencial + "','" + telefone_celular + "', '" + salario.ToString().Replace(",", ".") + "',  '" + cidade + "','" + endereco + "'," + numero + ", '" + bairro + "','" + estado + "', '" + complemento + "','" + cep + "',  '" + email + "' ,NOW(),'" + usuario + "','" + senha + "', '" + tipo_acesso + "', '" + foto + "', 1, '" + codigo_cargo + "' )";

            //CLASSE CONEXÃO
            classConexao cConexao = new classConexao();
            //CHAMA O MÉTODO QUE VAI EXECUTAR O COMANDO 
            return cConexao.ExecutaQuery(query);

        }



        // MÉTODOS DE CONSULTA
        // CONSULTA DE FUNCIONÁRIO POR NOME (INÍCIO E CONTÉM), CPF, SEXO, DATA DE ADIMISSÃO, CARGO, CIDADE E STATUS
        // CAMPOS EXIBIDOS NA CONSULTA: CODIGO FUNCIONÁRIO */ /* CPF, NOME, SEXO, DATA ADIMISSÃO, CARGO, E CELULAR

        // CONSULTA DE FUNCIONÁRIO POR CARGO
        public DataTable ConsFuncionarioCargo(int cargo)
        {
            string query = "SELECT funcionario.codigo_funcionario 'COD', funcionario.cpf 'CPF', FUNCIONARIO.nome 'NOME', funcionario.sexo 'SEXO', funcionario.data_cadastro 'DATA ADMISSAO', cargo.nome_cargo 'CARGO', funcionario.telefone_celular 'CELULAR' FROM funcionario INNER JOIN cargo ON funcionario.codigo_cargo = cargo.codigo_cargo WHERE funcionario.status = 1 AND funcionario.codigo_cargo = " + cargo + " ORDER BY funcionario.nome;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);

        }


        // CONSULTA DE FUNCIONÁRIO POR CIDADE
        public DataTable ConsFuncionarioCidade(string cidade)
        {
            string query = "SELECT funcionario.codigo_funcionario 'COD', funcionario.CPF 'CPF', FUNCIONARIO.nome 'NOME', funcionario.sexo 'SEXO', funcionario.data_cadastro 'DATA ADMISSAO', cargo.nome_cargo 'CARGO', funcionario.telefone_celular 'CELULAR' FROM funcionario INNER JOIN cargo ON funcionario.codigo_cargo = cargo.codigo_cargo WHERE funcionario.status = 1 AND funcionario.cidade = '" + cidade + "' ORDER BY funcionario.nome;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);

        }


        // CONSULTA DE FUNCIONÁRIO POR SEXO
        public DataTable ConsFuncionarioSexo(string sexo)
        {
            string query = "SELECT funcionario.codigo_funcionario 'COD', funcionario.CPF 'CPF', FUNCIONARIO.nome 'NOME', funcionario.sexo 'SEXO', funcionario.data_cadastro 'DATA ADMISSAO', cargo.nome_cargo 'CARGO', funcionario.telefone_celular 'CELULAR' FROM funcionario INNER JOIN cargo ON funcionario.codigo_cargo = cargo.codigo_cargo WHERE funcionario.status = 1 AND funcionario.sexo = '" + sexo + "' ORDER BY funcionario.nome;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);

        }


        // CONSULTA DE FUNCIONÁRIO POR CPF
        public DataTable ConsFuncionarioCPF(string cpf)
        {
            string query = "SELECT funcionario.codigo_funcionario 'COD', funcionario.CPF 'CPF', FUNCIONARIO.nome 'NOME', funcionario.sexo 'SEXO', funcionario.data_cadastro 'DATA ADMISSAO', cargo.nome_cargo 'CARGO', funcionario.telefone_celular 'CELULAR' FROM funcionario INNER JOIN cargo ON funcionario.codigo_cargo = cargo.codigo_cargo WHERE funcionario.status = 1 AND funcionario.cpf = '" + cpf + "' ORDER BY funcionario.nome;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);

        }


        // CONSULTA DE FUNCIONÁRIO POR DATA DE ADMISSÃO
        public DataTable ConsFuncionarioDataAdmissão(DateTime dataInicio, DateTime dataFinal)
        {
            string query = "SELECT funcionario.codigo_funcionario 'COD', funcionario.CPF 'CPF', FUNCIONARIO.nome 'NOME', funcionario.sexo 'SEXO', funcionario.data_cadastro 'DATA ADMISSAO', cargo.nome_cargo 'CARGO', funcionario.telefone_celular 'CELULAR' FROM funcionario INNER JOIN cargo ON funcionario.codigo_cargo = cargo.codigo_cargo WHERE funcionario.status = 1 AND funcionario.data_cadastro BETWEEN '" + dataInicio.ToString("yyyy-MM-dd") + "' AND '" + dataFinal.ToString("yyyy-MM-dd") + "' ORDER BY funcionario.nome;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);

        }


        // CONSULTA DE FUNCIONÁRIO POR NOME INICIO
        public DataTable ConsFuncionarioNomeInicio(string nomeInicio)
        {
            string query = "SELECT funcionario.codigo_funcionario 'COD', funcionario.CPF 'CPF', FUNCIONARIO.nome 'NOME', funcionario.sexo 'SEXO', funcionario.data_cadastro 'DATA ADMISSAO', cargo.nome_cargo 'CARGO', funcionario.telefone_celular 'CELULAR' FROM funcionario INNER JOIN cargo ON funcionario.codigo_cargo = cargo.codigo_cargo WHERE funcionario.status = 1 AND funcionario.nome LIKE '" + nomeInicio + "%' ORDER BY funcionario.nome;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);

        }


        // CONSULTA DE FUNCIONÁRIO POR NOME CONTÉM
        public DataTable ConsFuncionarioNomeContem(string nomeContem)
        {
            string query = "SELECT funcionario.codigo_funcionario 'COD', funcionario.CPF 'CPF', FUNCIONARIO.nome 'NOME', funcionario.sexo 'SEXO', funcionario.data_cadastro 'DATA ADMISSAO', cargo.nome_cargo 'CARGO', funcionario.telefone_celular 'CELULAR' FROM funcionario INNER JOIN cargo ON funcionario.codigo_cargo = cargo.codigo_cargo WHERE funcionario.status = 1 AND funcionario.nome LIKE '%" + nomeContem + "%' ORDER BY funcionario.nome;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);

        }


        // CONSULTA DE FUNCIONÁRIO POR STATUS
        public DataTable ConsFuncionarioStatus(int status)
        {
            string query = "SELECT funcionario.codigo_funcionario 'COD', funcionario.CPF 'CPF', FUNCIONARIO.nome 'NOME', funcionario.sexo 'SEXO', funcionario.data_cadastro 'DATA ADMISSAO', cargo.nome_cargo 'CARGO', funcionario.telefone_celular 'CELULAR' FROM funcionario INNER JOIN cargo ON funcionario.codigo_cargo = cargo.codigo_cargo WHERE funcionario.status = " + status + " ORDER BY funcionario.nome;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);

        }
        // CONSULTA DE FUNCIONÁRIO POR SEXO E Cidade
        public DataTable ConsFuncionarioSexoCidade(string sexo, string cidade)
        {
            string query = "SELECT funcionario.codigo_funcionario 'COD', funcionario.CPF 'CPF', FUNCIONARIO.nome 'NOME', funcionario.sexo 'SEXO', funcionario.data_cadastro 'DATA ADMISSAO', cargo.nome_cargo 'CARGO', funcionario.telefone_celular 'CELULAR' FROM funcionario INNER JOIN cargo ON funcionario.codigo_cargo = cargo.codigo_cargo WHERE funcionario.status = 1 AND funcionario.sexo = '" + sexo + "'AND  funcionario.cidade ='" + cidade+"' ORDER BY funcionario.nome;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);

        }


        // MÉTODO PARA ATUALIZAR FUNCIONÁRIO
        public int AtualizarFuncionario()
        {
            string query = "UPDATE funcionario SET nome = '" + nome + "', nome_social = '" + nome_social + "', data_nascimento = '" + data_nascimento.ToString("yyyy-MM-dd") + "', sexo = '" + sexo + "', estado_civil = '" + estado_civil + "', cpf = '" + cpf + "', rg =  '" + rg + "', salario =  '" + salario.ToString().Replace(",", ".") + "', endereco = '" + endereco + "', numero = " + numero + ", complemento = '" + complemento + "', bairro = '" + bairro + "', cidade = '" + cidade + "', estado = '" + estado + "', cep = '" + cep + "', telefone_residencial = '" + telefone_residencial + "', telefone_celular = '" + telefone_celular + "', email = '" + email + "', status =  " + status + ", usuario = '" + usuario + "', senha = '" + senha + "', tipo_acesso = " + tipo_acesso + ", foto = '" + foto + "', codigo_cargo = " + codigo_cargo + " WHERE codigo_funcionario = " + codigo_funcionario + ";";
            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);

        }

        public int ExcluirFuncionario()
        {
            string query = " DELETE FROM funcionario WHERE codigo_funcionario = "+codigo_funcionario+"; ";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }


        //MÉTODO PARA BUSCAR TODOS OS DO BANCO QUANDO O USUÁRIO ESCOLHER O FUNCIOÁRIO NA GRID PARA EDITAR
        
        public bool ConsultaFuncionario(int cod)
        {
            //EXIBIR TODOS OS DADOS DO FUNCIONÁRIO ESCOLHIDO PELO USUÁRIO NA GRID DE CONSULTA
            string query = "SELECT * FROM funcionario WHERE codigo_funcionario =" + cod + " ";

            classConexao cConexao = new classConexao();
            //MONTAR O DATA TABLE - RECEBER TODOS OS DADOS DO BANCO QUE DEPOIS SERÃO EXIBIDOS NOS CAMPOS DO FORM DE CADASTRO/ATUALIZAÇÃO DO FUNCIONÁRIO
            DataTable dt = cConexao.RetornaDados(query);

            //SE A CONSULTA DER CERTO 
            if (dt.Rows.Count > 0)
            {
                codigo_funcionario = Convert.ToInt32(dt.Rows[0]["codigo_funcionario"]);
               tipo_acesso = Convert.ToInt32(dt.Rows[0]["tipo_acesso"]);
                nome = Convert.ToString(dt.Rows[0]["nome"]);
                nome_social = Convert.ToString(dt.Rows[0]["nome_social"]);
                data_nascimento = Convert.ToDateTime(dt.Rows[0]["data_nascimento"]);
                sexo = Convert.ToString(dt.Rows[0]["sexo"]);
                estado_civil = Convert.ToString(dt.Rows[0]["estado_civil"]);
                cpf = Convert.ToString(dt.Rows[0]["cpf"]);
                rg = Convert.ToString(dt.Rows[0]["rg"]);
                salario = Convert.ToDecimal(dt.Rows[0]["salario"]);
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
                usuario = Convert.ToString(dt.Rows[0]["usuario"]);
                senha = Convert.ToString(dt.Rows[0]["senha"]);
                foto = Convert.ToString(dt.Rows[0]["foto"]);
                codigo_cargo = Convert.ToInt32(dt.Rows[0]["codigo_cargo"]);

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
            string query = " SELECT DISTINCT cidade FROM funcionario WHERE status = 1 ORDER BY cidade;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

       //MÉTODO DE RELATÓRIO PASSO=1
       //MÉTODO DE FUNCIONÁRIO POR CIDADE
       public DataTable RelFuncionarioCidade(string cidade)
        {
            string query = "SELECT funcionario.nome, funcionario.data_nascimento, funcionario.data_cadastro, funcionario.cidade, funcionario.cpf, funcionario.sexo, cargo.nome_cargo 'codigo_cargo' FROM funcionario JOIN cargo ON funcionario.codigo_cargo = cargo.codigo_cargo WHERE funcionario.status = 1 AND funcionario.cidade = '"+cidade+"' ORDER BY funcionario.nome;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable RelFuncionarioSexo(string sexo)
        {
            string query = "SELECT funcionario.nome, funcionario.data_nascimento, funcionario.data_cadastro, funcionario.cidade, funcionario.cpf, funcionario.sexo, cargo.nome_cargo 'codigo_cargo' FROM funcionario JOIN cargo ON funcionario.codigo_cargo = cargo.codigo_cargo WHERE funcionario.status = 1 AND funcionario.sexo = '"+sexo+"'  ORDER BY funcionario.nome;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable RelFuncionarioStatus(int status)
        {
            string query = "SELECT funcionario.nome, funcionario.data_nascimento, funcionario.data_cadastro, funcionario.cidade, funcionario.cpf, funcionario.sexo, cargo.nome_cargo 'codigo_cargo'  FROM funcionario JOIN cargo ON funcionario.codigo_cargo = cargo.codigo_cargo WHERE funcionario.status = "+ status +"  ORDER BY funcionario.nome;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable RelFuncionarioAdmissao(DateTime dataInicio, DateTime dataFinal)
        {
            string query = "SELECT funcionario.nome, funcionario.data_nascimento, funcionario.data_cadastro, funcionario.cidade, funcionario.cpf, funcionario.sexo, cargo.nome_cargo 'codigo_cargo' FROM funcionario JOIN cargo ON funcionario.codigo_cargo = cargo.codigo_cargo WHERE funcionario.status = 1 AND funcionario.data_cadastro BETWEEN '" + dataInicio.ToString("yyyy-MM-dd") + "' AND '" + dataFinal.ToString("yyyy-MM-dd") + "'  ORDER BY funcionario.nome;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable RelFuncionarioCargo(int cargo)
        {
            string query = "SELECT funcionario.nome, funcionario.data_nascimento, funcionario.data_cadastro, funcionario.cidade, funcionario.cpf, funcionario.sexo, cargo.nome_cargo 'codigo_cargo' FROM funcionario JOIN cargo ON funcionario.codigo_cargo = cargo.codigo_cargo WHERE funcionario.status = 1 AND funcionario.codigo_cargo = "+ cargo +" ORDER BY funcionario.nome;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable RelFuncionarioMesAniversario(int mes)
        {
            string query = "SELECT funcionario.nome, funcionario.data_nascimento, funcionario.data_cadastro, funcionario.cidade, funcionario.cpf, funcionario.sexo, cargo.nome_cargo 'codigo_cargo' FROM funcionario JOIN cargo ON funcionario.codigo_cargo = cargo.codigo_cargo WHERE funcionario.status = 1 AND MONTH(funcionario.data_nascimento) ="+mes+" ORDER BY funcionario.nome;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable RelFuncionarioIdade(int idadei, int idadef)
        {
            string query = "SELECT funcionario.nome, funcionario.data_nascimento, funcionario.data_cadastro, funcionario.cidade, funcionario.cpf, funcionario.sexo, cargo.nome_cargo 'codigo_cargo' FROM funcionario JOIN cargo ON funcionario.codigo_cargo = cargo.codigo_cargo WHERE funcionario.status = 1 AND TIMESTAMPDIFF (YEAR, funcionario.data_nascimento, NOW()) BETWEEN "+idadei+" AND "+idadef+" ORDER BY funcionario.nome;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable BuscarFuncionario()
        {
            string query = "SELECT codigo_funcionario, nome FROM funcionario WHERE status = 1 ORDER BY nome;";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }
    }
}
