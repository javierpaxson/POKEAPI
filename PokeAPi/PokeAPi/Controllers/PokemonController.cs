using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using c = PokeAPi.Utilities;
using PokeAPi.Models;

namespace PokeAPi.Controllers
{
    public class PokemonController : Controller
    {
        // GET: Pokemon
        public ActionResult Index()
        {

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon/");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.GetAsync("https://pokeapi.co/api/v2/pokemon/25").Result;
            var pokemondetail = new PokemonDetail();
            var pokemones = new Pokemones();
            List<Result> nombre = new List<Result>();
            
            if (response.IsSuccessStatusCode)
            {

                response = client.GetAsync("https://pokeapi.co/api/v2/pokemon").Result;
                var result = response.Content.ReadAsStringAsync().Result;
                pokemones = JsonConvert.DeserializeObject<Pokemones>(result);
                foreach (var pokemon in pokemones.Results)
                {
                    nombre.Add(pokemon);
                }

                //var result = response.Content.ReadAsStringAsync().Result;
                //pokemondetail = JsonConvert.DeserializeObject<PokemonDetail>(result);
            }

            var pokemonesL = new GetPokemons();
            pokemonesL = new GetPokemons { PokemonesList = nombre };            
            return View (pokemonesL);
        }
        public ActionResult Hello()
        {
            return PartialView ();
        }
    }
   

    

    
}