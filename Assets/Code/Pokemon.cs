using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Pokemon
{
    public string name { get; set; }
    public int[] types { get; set; }
    public int hp { get; set; }
    public int attack { get; set; }
    public int defense { get; set; }
    public int spattack { get; set; }
    public int spdefense { get; set; }
    public int speed { get; set; }

    public Pokemon(string n, int[] t, int h, int a, int d, int spa, int spd, int sped)
    {
        name = n;
        types = t;
        hp = h;
        attack = a;
        defense = d;
        spattack = spa;
        spdefense = spd;
        speed = sped;
    }
}

