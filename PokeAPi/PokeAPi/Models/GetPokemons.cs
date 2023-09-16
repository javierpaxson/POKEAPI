using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokeAPi.Models
{
    public class GetPokemons
    {
        public virtual List<Result> PokemonesList { get; set; }
        public virtual List<PokemonDetail> PokemonDetailList { get; set; }
    }
}