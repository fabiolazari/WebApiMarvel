using ApiMarvel.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ApiMarvel.Services
{
	public class RequestAPI
	{
        #region ...Variaveis...

        string host = "http://gateway.marvel.com";
        string metodo = "/v1/public/series";
        string parametros = "?ts=1&apikey=473da253b3977826288936c4a61c0991&hash=8be15a064f1557728066139e0619aaf6";
        Marvel marvel = new Marvel();

        #endregion ...Variaveis...

        #region ...Métodos...

        public async Task<Marvel> CarregaDadosPersonagemMarvel()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(host);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                using (var response = await client.GetAsync(string.Format("{0}{1}", metodo, parametros)))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        String JsonString = await response.Content.ReadAsStringAsync();
                        marvel = JsonConvert.DeserializeObject<Marvel>(JsonString);
                    }
                }
            }
            return marvel;
        }

        public async Task<Marvel> CarregaDadosPersonagemMarvel(string Id)
        {
            string Url = string.Format("{0}{1}/{2}{3}", host, metodo, Id, parametros);
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(Url))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        String JsonString = await response.Content.ReadAsStringAsync();
                        marvel = JsonConvert.DeserializeObject<Marvel>(JsonString);
                    }
                }
            }

            return marvel;
        }

        #endregion ...Métodos...
    }
}
