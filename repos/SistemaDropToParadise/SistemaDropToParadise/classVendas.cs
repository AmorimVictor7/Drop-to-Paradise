using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SistemaDropToParadise
{
    class classVendas
    {
        public classVendas()
        {
            codigo_venda = 0;
            preco_final = 0;
            data_venda = DateTime.Now;
            forma_pagamento = null;
            desconto = 0;
            codigo_cliente = 0;
            codigo_funcionario = 0;
        }

        public int codigo_venda { get; set; }

        public decimal preco_final { get; set; }

        public DateTime data_venda { get; set; }

        public string forma_pagamento { get; set; }

        public decimal desconto { get; set; }

        public int codigo_cliente { get; set; }


        public int codigo_funcionario { get; set; }

        public bool  CadastrarVenda()
        {
            string query = "INSERT INTO venda VALUES (0, '"+ preco_final.ToString().Replace(",",".") +"', now(), '"+ forma_pagamento +"', '"+desconto.ToString().Replace(",",".")+"', "+codigo_cliente+", "+codigo_funcionario+"); SELECT LAST_INSERT_ID();";

            classConexao cConexao = new classConexao();

            codigo_venda = 0;

            codigo_venda = cConexao.ExecutaQueryID(query);

            if (codigo_venda != 0) 
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
