using Newtonsoft.Json;

namespace SucosVendas
{
    public class Sucos
    {
        [JsonProperty("marca")]
        public string Marca { get; private set; }
        [JsonProperty("sabor")]
        public string Sabor { get; private set; }
        [JsonProperty("quantidadeMl")]
        public string QuantidadeMl { get; private set; }


    }
}
