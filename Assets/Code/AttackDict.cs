using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class AttackDict
{
    static List<List<Attack>> movesets = new List<List<Attack>>();

    static AttackDict()
    {
        movesets.Add(new List<Attack>() //Grass1
        {
            Attack.Dive()
        });
    }
}

/*
  "Bug" 0,
  "Dragon" 1,
  "Electric" 2,
  "Fighting" 3, 
  "Fire" 4,
  "Flying" 5,
  "Ghost" 6,
  "Grass" 7,
  "Ground" 8,
  "Ice" 9,
  "Normal" 10,
  "Poison" 11,
  "Phychic" 12,
  "Rock" 13,
  "Water 14"
  "Steel" 15
  "Dark" 16
*/
