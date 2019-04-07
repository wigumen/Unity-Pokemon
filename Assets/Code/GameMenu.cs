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
    int arrowIndex = 0;
    float lastMove;
    RectTransform rect;

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
            if (Input.GetKeyDown("space"))
            {
                player.isPaused = false;
                pausefc = true;
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
                if (arrowIndex < 6)
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

        rect.transform.position = new Vector3(rect.transform.position.x, MenuItems[arrowIndex].transform.position.y);

        Menu.SetActive(player.isPaused);
    }
}
