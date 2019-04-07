using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonActor
{
    int type;
    public int id;
    public int hp = 100;
    public string name = "missing.no";
    public PokemonStats stats;
    public List<Attack> attacks = new List<Attack>(4);

    private string[] types = { "Bug", "Dragon", "Electric", "Fighting", "Fire", "Flying", "Ghost", "Grass", "Ground", "Ice", "Normal", "Poison", "Phychic", "Rock", "Water", "Steel", "Dark" };

    public bool takeDmg(Attack a)
    {
        bool rPointer = false;
        int dmgRng = a.Power - Random.Range(0, a.Range);

        if (hp - dmgRng <= 0)
            rPointer = true;

        hp = hp - dmgRng;

        if (hp < 0)
            hp = 0;

        return rPointer;
    }

    public void init(int id)
    {
        var curpok = Pokedex.list[id];
        this.id = id;

        name = curpok.name;

    }
}

public class PokemonStats
{
    public int atk { get; set; }
    public int def { get; set; }
    public int speed { get; set; }

    public PokemonStats(int a, int d, int s)
    {
        atk = a;
        def = d;
        speed = s;
    }
}


