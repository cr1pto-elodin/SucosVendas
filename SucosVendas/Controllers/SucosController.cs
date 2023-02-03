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
        public HttpStatusCode Post([FromBody] string values)
        {
            Sucos suco = JsonConvert.DeserializeObject<Sucos>(values);
            if (String.IsNullOrEmpty(suco.Marca) || String.IsNullOrEmpty(suco.Sabor) || String.IsNullOrEmpty(suco.QuantidadeMl))
                return HttpStatusCode.BadRequest;
            Quantidade++;
            sucos.Add(Quantidade, suco);
            return HttpStatusCode.OK;
        }
    }
}
