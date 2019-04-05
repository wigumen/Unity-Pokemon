using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle : MonoBehaviour
{
    private List<Pokemon> PlayerPokemon = PlayerStats.Pokemons;
    private List<Pokemon> EnemyPokemon = new List<Pokemon>();

    private int playerSelected = 0;
    private int enemySelected = 0;

    private bool inTurn = false;

    private bool isTrainer = false;

    public GameObject pobj;
    public GameObject eobj;

    private DrawPokemon PlayerSpawn;
    private DrawPokemon EnemySpawn;

    Attack selectedAtk = null;

    void Start()
    {
        //Generate rand for now
        Pokemon badguy = new Pokemon();
        badguy.id = 109;
        badguy.stats = new PokemonStats(100, 100, 50);
        badguy.attacks = new List<Attack>();
        badguy.attacks.Add(new Tackle());
        EnemyPokemon.Add(badguy);

        PlayerSpawn = pobj.AddComponent<DrawPokemon>();
        EnemySpawn = eobj.AddComponent<DrawPokemon>();

        PlayerSpawn.pokemon = PlayerPokemon[playerSelected];
        PlayerSpawn.back = true;
        print(PlayerPokemon[0]);
        EnemySpawn.pokemon = EnemyPokemon[enemySelected];


    }


    void OnGUI()
    {
        GUI.Box(new Rect(0, Screen.height - (Screen.height / 3), Screen.width, Screen.height / 3), "nigger");

        //Player HP
        helpers.GUIDrawRect(new Rect(Screen.width - (Screen.width / 2.5f), Screen.height - (Screen.height / 3) - (Screen.height / 11), Screen.width / 2.8f, Screen.height / 16), Color.red);
        helpers.GUIDrawRect(new Rect(Screen.width - (Screen.width / 2.5f), Screen.height - (Screen.height / 3) - (Screen.height / 11), (Screen.width / 2.8f) * (PlayerPokemon[playerSelected].hp / 100.0f), Screen.height / 16), Color.green);
        //Enemy
        helpers.GUIDrawRect(new Rect(Screen.width / 16, Screen.height / 16, Screen.width / 2.8f, Screen.height / 16), Color.red);
        helpers.GUIDrawRect(new Rect(Screen.width / 16, Screen.height / 16, (Screen.width / 2.8f) * (EnemyPokemon[enemySelected].hp / 100.0f), Screen.height / 16), Color.green);

        if(selectedAtk == null)
        {
            inTurn = false;
        }

        if (!inTurn)
        {
            var playerAttacks = PlayerPokemon[playerSelected].attacks;
            

            if (GUI.Button(new Rect(15, Screen.height - (Screen.height / 3) + 15, Screen.width / 6, Screen.height / 9), playerAttacks[0].name))
            {
                selectedAtk = playerAttacks[0];
                doTurn(selectedAtk);
            }

            if(selectedAtk != null)
            {
                inTurn = true;
                //EnemyPokemon[enemySelected].takeDmg(selectedAtk);
            }
        }

    }

    void doTurn(Attack playeratk)
    {
        var enemy = EnemyPokemon[enemySelected];
        var player = PlayerPokemon[playerSelected];
        Attack enemyAtk = EnemyPokemon[enemySelected].attacks[Random.Range(0, EnemyPokemon[enemySelected].attacks.Count)];
        

        if (player.stats.speed >= enemy.stats.speed)
        {
            enemy.takeDmg(playeratk);
            if(enemy.hp>0)
                player.takeDmg(enemyAtk);
        }
        else
        {
            player.takeDmg(enemyAtk);
            if (player.hp > 0)
                enemy.takeDmg(playeratk);
            
        }
        print(enemy.hp + " | " + player.hp);
        selectedAtk = null;
    }
}
