using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Principal.Models;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Principal
{
    /*
            HttpResponseMessage response = client.GetAsync(url).Result;
            var a = response.Content.ReadAsStringAsync().Result;
            dynamic obj = JsonConvert.DeserializeObject<dynamic>(a);
            var ooo = obj.results.currencies.USD.buy;
    */

    public class ServicosAPI
    {
        private string _chave;
        private string _endpoint;

        public ServicosAPI()
        {
            _chave = "45a572df";
            _endpoint = "https://api.hgbrasil.com/finance";
        }

        public FundosInvestimentoImobiliarioFII BuscarFII(string codigoFII)
        {
            if (codigoFII == null)
                throw new ArgumentNullException("Código não pode ser nulo");

            if (codigoFII == string.Empty)
                throw new Exception("Código não pode ser vazio");

            string url = $"{_endpoint}/stock_price?key={_chave}&symbol={codigoFII.Trim()}";

            var fii = new FundosInvestimentoImobiliarioFII();

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage resposta = client.GetAsync(url).Result)
                {
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var resultado = resposta.Content.ReadAsStringAsync().Result;

                    dynamic obj = JsonConvert.DeserializeObject<dynamic>(resultado);

                    var rss = ToJsonObject(obj);

                    fii.Preco = (double)rss[codigoFII.ToUpper()]["price"];
                    fii.Codigo = (string)rss[codigoFII.ToUpper()]["symbol"];
                }
            };

            return fii;
        }

        private JObject ToJsonObject(dynamic obj)
        {
            var JsonEmString = Convert.ToString(obj.results);

            return JObject.Parse(JsonEmString);
        }
    }
}
