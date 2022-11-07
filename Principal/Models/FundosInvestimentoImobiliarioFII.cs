using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Models
{
    public class FundosInvestimentoImobiliarioFII
    {
        public string Nome { get; set; }

        public string Tipo { get { return "fii"; } }

        public string Codigo { get; set; }

        public  double Preco { get; set; }

        public string NomeEmpresa { get; set; }

        public int Quantidade { get; set; }

        public double Dividendos { get; set; }
    }
}
/*
  
"kind": "fii",
"symbol": "RZTR11",
"name": "FII Riza Tx",
"company_name": "Fundo De Investimento Imobilirio Riza Terrax",
"document": "36.501.128/0001-86",
"description": "Financeiro e Outros/Fundos/Fundos Imobiliários",
"website": "https://www.bancoplural.com/",
"region": "Brazil/Sao Paulo",
"currency": "BRL",
"market_time": {
"open": "10:00",
"close": "17:30",
"timezone": -3
},
"market_cap": 1136.84,
"price": 102.9,
"change_percent": -1.15,
"updated_at": "2022-10-17 20:04:34"
 
 */
