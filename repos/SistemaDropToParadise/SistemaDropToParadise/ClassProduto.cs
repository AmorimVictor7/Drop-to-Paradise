using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaDropToParadise
{
    class ClassProduto
    {
        // CONSTRUTOR
        public ClassProduto()
        {
            codigo_produto = 0;
            status = 0;
            nome_produto = null;
            foto = null;
            preco_venda = 0;
            preco_promocao = 0;
            observacao = null;
            preco_lucro = 0;
            preco_final_promo = 0;
            preco_desconto = 0;
            preco_custo = 0;
            data_cadastro = DateTime.Now;
            quantidade = 0;
            descricao = null;
            codigo_marca = 0;
            codigo_categoria = 0;
        }

        // PROPRIEDADES
        public int codigo_produto { get; set; }
        public int status { get; set; }
        public string nome_produto { get; set; }
        public string foto { get; set; }
        public decimal preco_venda { get; set; }
        public int preco_promocao { get; set; }
        public string observacao { get; set; }
        public decimal preco_lucro { get; set; }
        public decimal preco_final_promo { get; set; }
        public decimal preco_desconto { get; set; }
        public decimal preco_custo { get; set; }
        public DateTime data_cadastro { get; set; }
        public int quantidade { get; set; }
        public string descricao { get; set; }
        public int codigo_marca { get; set; }
        public int codigo_categoria { get; set; }

        // MÉTODO DE CADASTRAR PEODUTO
        public int CadastrarProduto()
        {
            string query = "INSERT INTO produto VALUES(0, 1, '" + nome_produto + "', '', " + preco_venda.ToString().Replace(",", ".") + ", " + preco_promocao.ToString().Replace(",", ".") + ", '" + observacao + "', " + preco_lucro.ToString().Replace(",", ".") + ", " + preco_final_promo.ToString().Replace(",", ".") + ", " + preco_desconto.ToString().Replace(",", ".") + ", " + preco_custo.ToString().Replace(",", ".") + ", NOW(), " + quantidade + ", '" + descricao + "', " + codigo_marca + ", " + codigo_categoria + ");";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }

        // FAZER AS CONSULTAS E ESSES SÃO OS MÉTODOS QUE VAI SER COLOCADO NAS CASES NO FORMCONSPRODUTO

        // PROCURAR POR NOME > % NO FINAL = A FAZER A PESQUISA PELA PRIMEIRA LETRA, E SE FOR % NO INICO E NO FINAL = A PESQUISA VAI SER FEITA SE A PALAVRA TEM AQUELA LETRA EM QUALQUER LUGAR 
        public DataTable ConsprodutoNomeInicio(string nomeInicio)
        {
            string query = "SELECT produto.codigo_produto 'COD', produto.nome_produto 'NOME', produto.preco_venda 'VENDA', produto.preco_final_promo 'DESCONTO',  produto.preco_promocao 'PROMO',  marca.nome_marca 'MARCA', categoria.nome_categoria 'CAT' FROM produto INNER JOIN marca ON produto.codigo_marca = marca.codigo_marca INNER JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria WHERE produto.status = 1 AND produto.nome_produto LIKE '" + nomeInicio + "%' ORDER BY produto.nome_produto;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable ConsprodutoNomeContem(string nomeContem)
        {
            string query = "SELECT produto.codigo_produto 'COD', produto.nome_produto 'NOME', produto.preco_venda 'VENDA', produto.preco_final_promo 'DESCONTO',  produto.preco_promocao 'PROMO',  marca.nome_marca 'MARCA', categoria.nome_categoria 'CAT' FROM produto INNER JOIN marca ON produto.codigo_marca = marca.codigo_marca INNER JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria WHERE produto.status = 1 AND produto.nome_produto LIKE '%" + nomeContem + "%' ORDER BY produto.nome_produto;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable ConsprodutoMarca(int marca)
        {
            string query = "SELECT produto.codigo_produto 'COD', produto.nome_produto 'NOME', produto.preco_venda 'VENDA', produto.preco_final_promo 'DECONTO',  produto.preco_promocao 'PROMO',  marca.nome_marca 'MARCA', categoria.nome_categoria 'CAT'  FROM produto INNER JOIN marca ON produto.codigo_marca = marca.codigo_marca  INNER JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria  WHERE produto.status = 1 AND produto.codigo_marca = " + marca + "  ORDER BY produto.nome_produto;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable ConsprodutoCategoria(int categoria)
        {
            string query = "SELECT produto.codigo_produto 'COD', produto.nome_produto 'NOME', produto.preco_venda 'VENDA', produto.preco_final_promo 'DESCONTO',  produto.preco_promocao 'PROMO',  marca.nome_marca 'MARCA', categoria.nome_categoria 'CAT'  FROM produto INNER JOIN marca ON produto.codigo_marca = marca.codigo_marca  INNER JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria  WHERE produto.status = 1 AND produto.codigo_categoria = " + categoria + "  ORDER BY produto.nome_produto;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        //CASO SEJA FEITA A ESCOLHA PRA SABER UMA BUSCA EM INTERVALOS É USADO O BETWEEN
        public DataTable ConsprodutoQuantidade(int min, int max)
        {
            string query = "SELECT produto.codigo_produto 'COD', produto.nome_produto 'NOME', produto.preco_venda 'VENDA', produto.preco_final_promo 'DESCONTO',  produto.preco_promocao 'PROMO',  marca.nome_marca 'MARCA'  FROM produto INNER JOIN marca ON produto.codigo_marca = marca.codigo_marca  INNER JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria  WHERE produto.status = 1 AND produto.quantidade BETWEEN " + min + " AND " + max +" ORDER BY produto.nome_produto;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable ConsProdutoStatus(int status)
        {
            string query = "SELECT produto.codigo_produto 'COD', produto.nome_produto 'NOME', produto.preco_venda 'VENDA', produto.preco_final_promo 'DESCONTO',  produto.preco_promocao 'PROMO',  marca.nome_marca 'MARCA', categoria.nome_categoria 'CAT'  FROM produto INNER JOIN marca ON produto.codigo_marca = marca.codigo_marca  INNER JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria  WHERE produto.status = " + status + " ORDER BY produto.nome_produto;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable ConsProdutoPromo(int promo)
        {
            string query = "SELECT produto.codigo_produto 'COD', produto.nome_produto 'NOME', produto.preco_venda 'VENDA', produto.preco_final_promo 'DESCONTO', produto.preco_promocao 'PROMO', marca.nome_marca 'MARCA', categoria.nome_categoria 'CAT'  FROM produto INNER JOIN marca ON produto.codigo_marca = marca.codigo_marca  INNER JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria  WHERE produto.status =  1 AND produto.preco_promocao = " + promo + " ORDER BY produto.nome_produto;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }
        
        //METODO PARA ATUALIZAR USANDO O UPDATE
        public int AtualizarProduto()
        {
            string query = "UPDATE produto SET nome_produto = '" + nome_produto + "', status = " + status + ", foto = '" + foto + "', preco_venda = " + preco_venda.ToString().Replace(",", ".") + ", preco_promocao = " + preco_promocao.ToString().Replace(",", ".") + ", observacao = '" + observacao + "', preco_lucro = " + preco_lucro.ToString().Replace(",", ".") + ", preco_final_promo = " + preco_final_promo.ToString().Replace(",", ".") + ", preco_desconto = " + preco_desconto.ToString().Replace(",", ".") + ", preco_custo = " + preco_custo.ToString().Replace(",", ".") + ", quantidade = " + quantidade + ", descricao = '" + descricao + "', codigo_marca = " + codigo_marca + ", codigo_categoria = " + codigo_categoria + " WHERE codigo_produto = " + codigo_produto + ";";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query); 

        }

        // MÉTODO PARA EXCLUIR PRODUTO USANDO O DELETE
        public int ExcluirProduto()
        {
            string query = "DELETE FROM produto WHERE codigo_produto = "+ codigo_produto +";";

            classConexao cConexao = new classConexao();
            return cConexao.ExecutaQuery(query);
        }

        // METODO PARA CONSULTAR PRODUTO PELO CODIGO E CARREGAR PROPRIEDADES
        public bool ConsultaProduto(int cod)
        {
            string query = "SELECT * FROM produto WHERE codigo_produto = " + cod + ";";

            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDados(query);

            if (dt.Rows.Count > 0)
            {
                codigo_produto = Convert.ToInt32(dt.Rows[0]["codigo_produto"]);
                status = Convert.ToInt32(dt.Rows[0]["status"]);
                nome_produto = Convert.ToString(dt.Rows[0]["nome_produto"]);
                foto = Convert.ToString(dt.Rows[0]["foto"]);
                preco_venda = Convert.ToDecimal(dt.Rows[0]["preco_venda"]);
                preco_promocao = Convert.ToInt32(dt.Rows[0]["preco_promocao"]);
                observacao = Convert.ToString(dt.Rows[0]["observacao"]);
                preco_lucro = Convert.ToDecimal(dt.Rows[0]["preco_lucro"]);
                preco_final_promo = Convert.ToDecimal(dt.Rows[0]["preco_final_promo"]);
                preco_desconto = Convert.ToDecimal(dt.Rows[0]["preco_desconto"]);
                preco_custo = Convert.ToDecimal(dt.Rows[0]["preco_custo"]);
                data_cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);
                quantidade = Convert.ToInt32(dt.Rows[0]["quantidade"]);
                descricao = Convert.ToString(dt.Rows[0]["descricao"]);
                codigo_marca = Convert.ToInt32(dt.Rows[0]["codigo_marca"]);
                codigo_categoria = Convert.ToInt32(dt.Rows[0]["codigo_categoria"]);

                return true;
            }
            else
            {
                return false;
            }
        }

        // QUASE A MESMA COISA DAS CONSULTAS MAS AQUI SERÁ PARA O RELÁTORIO 
        public DataTable RelProdutoCategoria(int categoria)
        {
            string query = "SELECT produto.nome_produto, produto.preco_venda, produto.preco_final_promo, produto.quantidade, produto.data_cadastro, produto.preco_promocao, marca.nome_marca 'codigo_marca', categoria.nome_categoria 'codigo_categoria' FROM produto JOIN marca ON produto.codigo_marca = marca.codigo_marca JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria WHERE produto.status = 1 AND produto.codigo_categoria = '" + categoria+ "' ORDER BY produto.nome_produto; ";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable RelProdutoMarca(int marca)
        {
            string query = "SELECT produto.nome_produto, produto.preco_venda, produto.preco_final_promo, produto.quantidade, produto.data_cadastro, produto.preco_promocao, marca.nome_marca 'codigo_marca', categoria.nome_categoria 'codigo_categoria' FROM produto JOIN marca ON produto.codigo_marca = marca.codigo_marca JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria WHERE produto.status = 1 AND produto.codigo_marca = '" + marca + "' ORDER BY produto.nome_produto; ";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable RelProdutoStatus(int status)
        {
            string query = "SELECT produto.nome_produto, produto.preco_venda, produto.preco_final_promo, produto.quantidade, produto.data_cadastro, produto.preco_promocao, marca.nome_marca 'codigo_marca', categoria.nome_categoria 'codigo_categoria' FROM produto JOIN marca ON produto.codigo_marca = marca.codigo_marca JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria WHERE produto.status = " + status + " ORDER BY produto.nome_produto; ";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        // USANDO BETWEEN COM DATAS 
        public DataTable RelprodutoAdmissao(DateTime inicio, DateTime final)
        {
            string query = "SELECT produto.nome_produto, produto.preco_venda, produto.preco_final_promo, produto.quantidade, produto.data_cadastro, produto.preco_promocao, marca.nome_marca 'codigo_marca', categoria.nome_categoria 'codigo_categoria' FROM produto JOIN marca ON produto.codigo_marca = marca.codigo_marca JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria WHERE produto.status = 1 AND produto.data_cadastro BETWEEN  '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + final.ToString("yyyy-MM-dd") + "' ORDER BY produto.nome_produto; ";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable RelprodutoQuantidade(int min,int max)
        {
            string query = "SELECT produto.nome_produto, produto.preco_venda, produto.preco_final_promo, produto.quantidade, produto.data_cadastro, produto.preco_promocao, marca.nome_marca 'codigo_marca', categoria.nome_categoria 'codigo_categoria' FROM produto JOIN marca ON produto.codigo_marca = marca.codigo_marca JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria WHERE produto.status = 1 AND produto.quantidade BETWEEN  '" + min + "' AND '" + max + "' ORDER BY produto.nome_produto; ";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable RelProdutoPromo(int promo)
        {
            string query = "SELECT produto.nome_produto, produto.preco_venda, produto.preco_final_promo, produto.quantidade, produto.data_cadastro, produto.preco_promocao, marca.nome_marca 'codigo_marca', categoria.nome_categoria 'codigo_categoria' FROM produto JOIN marca ON produto.codigo_marca = marca.codigo_marca JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria WHERE produto.status = 1 AND produto.preco_promocao = " + promo + " ORDER BY produto.nome_produto; ";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public DataTable CarregaGridProduto(string nome)
        {
            string query = "SELECT produto.codigo_produto 'COD', produto.nome_produto 'NOME', produto.quantidade 'QTDE', marca.nome_marca 'MARCA', categoria.nome_categoria 'CATEGORIA' FROM produto INNER JOIN marca ON produto.codigo_marca = marca.codigo_marca INNER JOIN categoria ON produto.codigo_categoria = categoria.codigo_categoria WHERE produto.status = 1 AND produto.quantidade > 0 AND produto.nome_produto LIKE '%" + nome + "%' ORDER BY produto.nome_produto;";
            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }

        public string BuscaNomaProd(int cod)
        {
            string query = "SELECT nome_produto FROM produto WHERE codigo_produto = " + cod + " ";

            classConexao cConexao = new classConexao();
            DataTable dt = cConexao.RetornaDados(query);
            if(dt.Rows.Count > 0)
            {
                nome_produto = dt.Rows[0]["nome_produto"].ToString();
            }

            return nome_produto;
        }
        public bool AtualizarEstoque(int qtde, int cod)
        {
            string query = "UPDATE produto SET quantidade = " + qtde + " WHERE codigo_produto = " + cod + "";
            classConexao cConexao = new classConexao();

            int resp = cConexao.ExecutaQuery(query);

            if(resp == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
