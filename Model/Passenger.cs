using Newtonsoft.Json;
using System;

namespace Model
{
    public class Passenger
    {
        #region Properties

        [JsonProperty("Cpf")]
        public string Cpf { get; set; }
        [JsonProperty("Nome")]
        public string Name { get; set; }
        [JsonProperty("Telefone")]
        public string Telephone { get; set; }
        [JsonProperty("DataNasc")]
        public DateTime DateBirth { get; set; }
        [JsonProperty("Email")]
        public string Email { get; set; }
        [JsonProperty("Endereco")]
        public Address Address { get; set; }
        #endregion
    }
}
