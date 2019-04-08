using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Battle : MonoBehaviour
{
    private List<PokemonActor> PlayerPokemon = PlayerStats.Pokemons;
    public List<PokemonActor> EnemyPokemon = PlayerStats.Enemy;

    public Button[] AttackButtons;
    private int playerSelected = 0;
    private int enemySelected = 0;

    private bool inTurn = false;

    public bool isTrainer = false;

    public GameObject pobj;
    public GameObject eobj;

    public GameObject bag;

    public GameObject MainMenu;
    public GameObject Fight;

    private DrawPokemon PlayerSpawn;
    private DrawPokemon EnemySpawn;

    Attack selectedAtk = null;

    void Start()
    {
        PlayerStats.inCombat = true;
        //Generate rand for now

        bag.SetActive(false);

        PlayerSpawn = pobj.AddComponent<DrawPokemon>();
        EnemySpawn = eobj.AddComponent<DrawPokemon>();

        PlayerSpawn.pokemon = PlayerPokemon[playerSelected];
        PlayerSpawn.back = true;
        print(PlayerPokemon[0]);
        EnemySpawn.pokemon = EnemyPokemon[enemySelected];

        for(int i=0; i<4; i++)
        {
            Attack curatk = null;
            try
            {
                curatk = PlayerPokemon[playerSelected].attacks[i];
            }
            catch { }

            var curbtn = AttackButtons[i];
            //AttackButtons[i].onClick.AddListener(delegate { Attack(i); }); Why this Does not woooork
            switch (i) //I got no fucking clue man????
            {
                case 0:
                    AttackButtons[0].onClick.AddListener(delegate { doAttack(0); });
                    break;
                case 1:
                    AttackButtons[1].onClick.AddListener(delegate { doAttack(1); });
                    break;
                case 2:
                    AttackButtons[2].onClick.AddListener(delegate { doAttack(2); });
                    break;
                case 3:
                    AttackButtons[3].onClick.AddListener(delegate { doAttack(3); });
                    break;
            }

            if (curatk != null)
            {
                curbtn.GetComponentInChildren<Text>().text = curatk.Name;
            }
            else
            {
                curbtn.gameObject.SetActive(false);
            }
        }

    }


    void OnGUI()
    {
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

        if (!PlayerStats.inCombat)
        {
            PlayerStats.Enemy = new List<PokemonActor>();
            SceneManager.LoadScene(0);
        }

    }

    void doAttack(int btn)
    {
        var playerAttacks = PlayerPokemon[playerSelected].attacks;
        selectedAtk = playerAttacks[btn];

        if (!inTurn)
        {
            selectedAtk = playerAttacks[btn];
            doTurn(selectedAtk);
            MainMenu.SetActive(true);
            Fight.SetActive(false);
        }
    }

    void doTurn(Attack playeratk)
    {
        var enemy = EnemyPokemon[enemySelected];
        var player = PlayerPokemon[playerSelected];
        Attack enemyAtk = EnemyPokemon[enemySelected].attacks[Random.Range(0, EnemyPokemon[enemySelected].attacks.Count)];
        

        if (player.stats.speed >= enemy.stats.speed)
        {
            if (!enemy.takeDmg(playeratk))
            {
                player.takeDmg(enemyAtk);
            }
            else
            {
                PlayerStats.inCombat = false;
            }
                
        }
        else
        {
            if (!player.takeDmg(enemyAtk))
            {
                enemy.takeDmg(playeratk);
            } else
            {
                PlayerStats.inCombat = false;
            }
            
        }
       
        print(enemy.hp + " | " + player.hp);
        selectedAtk = null;
    }
}
