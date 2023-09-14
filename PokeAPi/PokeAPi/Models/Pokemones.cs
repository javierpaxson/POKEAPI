using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokeAPi.Models
{
    public class Pokemones
    {
        [JsonProperty("results")]
        public Result[] Results { get; set; }
    }
    public partial class Result
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }

    }
}