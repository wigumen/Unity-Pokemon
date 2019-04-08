using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
public static class PlayerStats
{
    public static List<PokemonActor> Pokemons = new List<PokemonActor>(6);
    public static List<PokemonActor> Enemy = new List<PokemonActor>(6);
    public static Vector3 playerPos = new Vector3(0.4f, -0.88f, 0f);
    public static List<item> inventory = new List<item>();
    public static bool inCombat = false;

    public static void addPokemon(PokemonActor pok)
    {
        if(Pokemons.Count < 6)
            Pokemons.Add(pok);
    }

    public static void addItem(item Item, int q)
    {
        for (int x = 0; x < q; x++)
        {
            if (inventory.Count == 0)
            {
                inventory.Add(Item);
            }
            else
            {
                bool dupe = false;
                for (int y = 0; y < inventory.Count; y++)
                {
                    if (inventory[y].name == Item.name)
                    {
                        dupe = true;
                        inventory[y].count++;
                    }
                }
                if (!dupe)
                    inventory.Add(Item);
            }
        }
    }

    static PlayerStats()
    {
        Pokemons = new List<PokemonActor>();

        //testdata
        PokemonActor gengar = new PokemonActor(94, 100);

        addPokemon(gengar);

        addItem(item.Pokeball(0), 69);
        addItem(item.Pokeball(1), 23);
        addItem(item.Pokeball(2), 54);
        addItem(item.Pokeball(3), 12);
    }
}
