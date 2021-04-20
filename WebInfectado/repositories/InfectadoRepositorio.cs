using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebInfectado.Models;

namespace WebInfectado.repositories
{
    public class InfectadoRepositorio
    {
        HttpClient client = new HttpClient();

        public InfectadoRepositorio()
        {
            client.BaseAddress = new Uri("https://localhost:44368/");
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("aplication/json"));
        }

        public async Task<List<Infectado>> GetInfectadosAsync()
        {
            HttpResponseMessage response = await client.GetAsync("api/Infectado");
            if (response.IsSuccessStatusCode)
            {
                var dados = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Infectado>>(dados);
            }
            return new List<Infectado>();
        }
    }
}
