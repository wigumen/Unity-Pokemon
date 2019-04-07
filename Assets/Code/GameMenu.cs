using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour
{
    Player player;
    public GameObject Arrow;
    public GameObject Menu;
    public GameObject[] MenuItems;
    public Button[] MenuPokemons;
    public GameObject MenuPokemonPanel;
    int arrowIndex = 0;
    float lastMove;
    RectTransform rect;
    bool main = true;
    bool pokemonScreen = false;

    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.GetComponent<Player>();
        rect = Arrow.GetComponent<RectTransform>();
        lastMove = Time.time;
        
    }

    void Update()
    {
        bool pausefc = false;
        if (player.isPaused && Time.time > lastMove + 0.02f)
        {

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (pokemonScreen)
                {
                    pokemonScreen = false;
                    main = true;
                    arrowIndex = 0;
                    pausefc = true;
                }
                if(main && !pausefc)
                    player.isPaused = false;
            }

            if(Input.GetKeyDown("e"))
            {
                switch (arrowIndex)
                {
                    case 1:
                        pokemonScreen = true;
                        main = false;
                        arrowIndex = 0;
                        break;
                }
            }

            if (Input.GetKeyDown("w"))
            {
                if (arrowIndex > 0)
                { 
                    arrowIndex--;
                    lastMove = Time.time;
                }
            }
            else if (Input.GetKeyDown("s"))
            {
                if (arrowIndex < 5)
                {
                    arrowIndex++;
                    lastMove = Time.time;
                }
            }
        }

        if (Input.GetKeyDown("space"))
        {
            if (player.isPaused == false && !pausefc)
            {
                player.isPaused = true;
            }
        }
        if(main == true)
            rect.transform.position = new Vector3(MenuItems[arrowIndex].transform.position.x - (Screen.width/30), MenuItems[arrowIndex].transform.position.y);
            MenuPokemonPanel.SetActive(false);
        if (main == false && pokemonScreen)
        {
            MenuPokemonPanel.SetActive(true);
            rect.transform.position = new Vector3(MenuPokemons[arrowIndex].transform.position.x - (Screen.width/7), MenuPokemons[arrowIndex].transform.position.y);
            for(int i=0; i<6; i++)
            {
                PokemonActor curpok = null;
                try
                {
                    curpok = PlayerStats.Pokemons[i];
                }
                catch { }

                if(curpok != null)
                {
                    MenuPokemons[i].GetComponentInChildren<Text>().text = curpok.name;
                    MenuPokemons[i].GetComponentsInChildren<Image>()[1].sprite = Resources.Load<Sprite>("Sprites/icons/" + curpok.id);
                } else
                {
                    MenuPokemons[i].gameObject.SetActive(false);
                }
            }
        }

        Menu.SetActive(player.isPaused);
    }
}
