using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
public static class PlayerStats
{
    public static List<PokemonActor> Pokemons { get; set; }
    public static Vector3 playerPos { get; set; }

    public static void addPokemon(PokemonActor pok)
    {
        Pokemons.Add(pok);
    }
        
    static PlayerStats()
    {
        Pokemons = new List<PokemonActor>();
    }
}
