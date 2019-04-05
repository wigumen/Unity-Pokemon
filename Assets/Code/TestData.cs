using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestData : MonoBehaviour
{

    void Start()
    {
        List<Pokemon> testPok = new List<Pokemon>();
        Pokemon gengar = new Pokemon();
        gengar.id = 94;
        gengar.stats = new PokemonStats(100, 100, 100);
        gengar.attacks = new List<Attack>();
        gengar.attacks.Add(new Tackle());
        testPok.Add(gengar);

        PlayerStats.addPokemon(gengar);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
