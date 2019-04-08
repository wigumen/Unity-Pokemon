using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class item
{
    public string name { get; }
    public Sprite sprite { get; }
    public itemmod type { get; set; }
    public int count = 1;

    public item(string name, Sprite sprite, itemmod type)
    {
        this.name = name;
        this.sprite = sprite;
        this.type = type;
    }

    public static item Pokeball(int ballid)
    {
        string ballname = "";
        int spriteid = ballid;
        Sprite sprite = Resources.LoadAll<Sprite>("Sprites/Sheets/items")[spriteid];

        switch (ballid) {
            case 0:
                ballname = "Master Ball";
                break;
            case 1:
                ballname = "Ultra Ball";
                break;
            case 2:
                ballname = "Great Ball";
                break;
            case 3:
                ballname = "Pokeball";
                break;
            default:
                ballname = "Invalid Ball";
                sprite = null;
                break;
        }
        
        item newball = new item(ballname, sprite, new Pokeball(ballid));
        newball.type.thisitem = newball;
        return newball;
    }
}

public class itemmod
{
    public item thisitem { get; set; }

    public virtual void use()
    {

    }
}

public class Pokeball : itemmod
{
    public int ballid { get; set; }
    

    public Pokeball(int ballid)
    {
        this.ballid = ballid;
    }

    public override void use()
    { 
        if (PlayerStats.inCombat)
        {
            
            Battle combat = GameObject.FindGameObjectWithTag("battle").GetComponent<Battle>();
            if (!combat.isTrainer)
            {
                float change = 0;
                switch (ballid)
                {
                    case 0:
                        change = 255.0f;
                        break;
                    case 1:
                        change = 2.0f;
                        break;
                    case 2:
                        change = 1.5f;
                        break;
                    case 3:
                        change = 1.0f;
                        break;
                }
                if (thisitem.count > 0)
                {
                    if (UnityEngine.Random.Range(1.0f,100.0f) < (5f * change))
                    {
                        PlayerStats.addPokemon(combat.EnemyPokemon[0]);
                        PlayerStats.inCombat = false;
                        Debug.Log(PlayerStats.inCombat);
                        Debug.Log("yeeted pokeball");
                    }
                    thisitem.count--;
                }
            }
        }
    }
}