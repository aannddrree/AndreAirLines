using Newtonsoft.Json;

namespace Model
{
    public class Address
    {
        [JsonProperty("Id")]
        public int Id { get; set; }
        [JsonProperty("Bairro")]
        public string District { get; set; }
        [JsonProperty("Cidade")]
        public string Cidy { get; set; }
        [JsonProperty("Pais")]
        public string Country { get; set; }
        [JsonProperty("CEP")]
        public string CEP { get; set; }
        [JsonProperty("Logradouro")]
        public string Street { get; set; }
        [JsonProperty("Estado")]
        public string State { get; set; }
        [JsonProperty("Numero")]
        public int Number { get; set; }
        [JsonProperty("Complemento")]
        public string Complement { get; set; }
    }
}