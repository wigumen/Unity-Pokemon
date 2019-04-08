using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonActor
{
    int[] type;
    public int id;

    public int hp = 100;
    public string name = "missing.no";
    public PokemonStats stats;
    public List<Attack> attacks = new List<Attack>(4);

    private string[] types = { "Bug", "Dragon", "Electric", "Fighting", "Fire", "Flying", "Ghost", "Grass", "Ground", "Ice", "Normal", "Poison", "Phychic", "Rock", "Water", "Steel", "Dark" };

    public PokemonActor(int id, int level, bool wild = false)
    {
        var curpok = Pokedex.list[id-1];
        this.id = id-1;

        name = curpok.name;
        type = curpok.types;
        var DV = 5;
        int l = level;
        if (wild)
        {
            l = Random.Range(level - 1, level + 1);
        }
        var a = Random.Range(curpok.attack - DV, curpok.attack + DV);
        var d = Random.Range(curpok.defense - DV, curpok.defense + DV);
        var spa = Random.Range(curpok.spattack - DV, curpok.spattack + DV);
        var spd = Random.Range(curpok.spdefense - DV, curpok.spdefense + DV);
        var s = Random.Range(curpok.speed - DV, curpok.speed + DV);
        PokemonStats genStats = new PokemonStats(curpok.hp, a, d, spa, spd, s, l);
        stats = genStats;
        hp = stats.hp;
    }

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
}

public class PokemonStats
{
    public int hp { get; set; }
    public int atk { get; set; }
    public int def { get; set; }
    public int spattack { get; set; }
    public int spdefense { get; set; }
    public int speed { get; set; }
    public int level = 3;

    public PokemonStats(int h, int a, int d, int spa, int spd, int s, int l)
    {
        hp = h;
        atk = a;
        def = d;
        speed = s;
        spattack = spa;
        spdefense = spd;
        level = l;
    }
}


