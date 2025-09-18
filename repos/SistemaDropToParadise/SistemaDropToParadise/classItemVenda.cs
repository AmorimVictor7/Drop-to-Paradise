using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaDropToParadise
{
    class classItensVenda
    {
        public classItensVenda()
        {
            codigo_venda = 0;
            codigo_produto = 0;
            preco = 0;
            quantidade = 0;
            codigo_item_venda = 0;
        }

        public int codigo_venda { get; set; }
        public int codigo_produto { get; set; }
        public decimal preco { get; set; }
        public int  quantidade { get; set; }
        public int codigo_item_venda { get; set; }


        public bool CadastrarItensVenda()
        {
            string query = "INSERT INTO item_venda VALUES (" + codigo_produto + "," + codigo_venda + "," + preco.ToString().Replace(",", ".") + ", " + quantidade + ", 0);";

            classConexao cConexao = new classConexao();

            int resp = cConexao.ExecutaQuery(query);

            if (resp != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable BuscarVenda()
        {
            string query = "SELECT codigo_venda, FROM venda WHERE status = 1 ORDER BY ";

            classConexao cConexao = new classConexao();
            return cConexao.RetornaDados(query);
        }
    }

}
