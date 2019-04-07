using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawPokemon : MonoBehaviour
{
    private SpriteRenderer sprite;
    public Sprite[] pksprite;
    public PokemonActor pokemon;
    public bool back = false;

    // Start is called before the first frame update
    void Start()
    {
            sprite = gameObject.GetComponent<SpriteRenderer>();
            if (!back)
                pksprite = Resources.LoadAll<Sprite>("Sprites/Sheets/pokemon-f");
            if (back)
                pksprite = Resources.LoadAll<Sprite>("Sprites/Sheets/pokemon-b");

        print(pksprite);
            sprite.sprite = pksprite[pokemon.id - 1];
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
