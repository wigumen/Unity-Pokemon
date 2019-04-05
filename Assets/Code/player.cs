using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SuperTiled2Unity;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public float speed = 0.1f;
    public GameObject colMap;
    public GameObject bkgMap;
    private Tilemap col;
    private Tilemap bkg;
    // Start is called before the first frame update
    void Start()
    {
        col = colMap.GetComponent<Tilemap>();
        bkg = bkgMap.GetComponent<Tilemap>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w") || Input.GetKeyDown("s") || Input.GetKeyDown("a") || Input.GetKeyDown("d"))
        {
            Vector3 bufferPos = transform.position;
            if (Input.GetKeyDown("w"))
            {
                bufferPos = bufferPos + new Vector3(0, speed);

            }
            if (Input.GetKeyDown("s"))
            {
                bufferPos = bufferPos + new Vector3(0, -speed);
            }
            if (Input.GetKeyDown("a"))
            {
                bufferPos = bufferPos + new Vector3(-speed, 0);
            }
            if (Input.GetKeyDown("d"))
            {
                bufferPos = bufferPos + new Vector3(speed, 0);
            }
            if (col.GetTile(col.WorldToCell(bufferPos)) == null)
            {
                transform.position = bufferPos;
                PlayerStats.playerPos = bufferPos;
            }
            if(bkg.GetTile(bkg.WorldToCell(transform.position)).name == "Tile_main_109")
            {
                if(Random.Range(0,1000) < 200)
                {
                    SceneManager.LoadScene(1);
                }
            }
        }
    }
}
