using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using System.Net;
using Newtonsoft;
using Newtonsoft.Json;
using System.Text.Json.Nodes;
using Newtonsoft.Json.Linq;

namespace SucosVendas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SucosController : ControllerBase
    {
        public static int Quantidade = 0;
        public Dictionary<int, Sucos> sucos = new Dictionary<int, Sucos>();
        [HttpGet]
        public Dictionary<int,Sucos> Get()
        {
            return sucos;
        }

        [HttpPost]
        public HttpResponseMessage Post([FromBody] string values)
        {
            Sucos suco = JsonConvert.DeserializeObject<Sucos>(values);
            if (String.IsNullOrEmpty(suco.Marca) || String.IsNullOrEmpty(suco.Sabor) || String.IsNullOrEmpty(suco.QuantidadeMl))
            {
                HttpContext.Response.StatusCode = 400;
                return new HttpResponseMessage() { StatusCode = (HttpStatusCode)400, ReasonPhrase = "Algum argumento veio vazio. Favor verificar."};
            }
            HttpContext.Response.StatusCode = 200;
            return new HttpResponseMessage() { StatusCode = (HttpStatusCode)200,ReasonPhrase = "Cadastrado"};
        }
    }
}
