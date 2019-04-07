using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
public static class PlayerStats
{
    public static List<PokemonActor> Pokemons = new List<PokemonActor>(6);
    public static Vector3 playerPos = new Vector3(0.4f, -0.88f, 0f);

    public static void addPokemon(PokemonActor pok)
    {
        if(Pokemons.Count < 6)
            Pokemons.Add(pok);
    }

    static PlayerStats()
    {
        Pokemons = new List<PokemonActor>();

        //testdata
        List<PokemonActor> testPok = new List<PokemonActor>();
        PokemonActor gengar = new PokemonActor();
        gengar.id = 94;
        gengar.stats = new PokemonStats(100, 100, 100);
        gengar.attacks = new List<Attack>();
        gengar.attacks.Add(Attack.Tackle());
        gengar.name = Pokedex.list[gengar.id - 1].name;
        testPok.Add(gengar);

        addPokemon(gengar);
    }
}
