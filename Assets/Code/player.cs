﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SuperTiled2Unity;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    private float movepx = 0.16f;
    public float speedDelay = 0.05f;
    public GameObject colMap;
    public GameObject bkgMap;
    private Tilemap col;
    private Tilemap bkg;
    private Animator animate;
    public Sprite idleSpriteD;
    public Sprite idleSpriteS;
    public Sprite idleSpriteU;
    private SpriteRenderer curSprite;
    private float lastMove;

    // Start is called before the first frame update
    void Start()
    {
        col = colMap.GetComponent<Tilemap>();
        bkg = bkgMap.GetComponent<Tilemap>();
        animate = gameObject.GetComponent<Animator>();
        animate.StopPlayback();
        lastMove = 0.0f;
        curSprite = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w") || Input.GetKey("s") || Input.GetKey("a") || Input.GetKey("d"))
        {
            if (Time.time > lastMove + speedDelay)
            {
                Vector3 bufferPos = transform.position;
                if (Input.GetKey("w"))
                {
                    bufferPos = bufferPos + new Vector3(0, movepx);
                    animate.Play("p_walk_u");
                }
                else if (Input.GetKey("s"))
                {
                    bufferPos = bufferPos + new Vector3(0, -movepx);
                    animate.Play("p_walk_d");
                }
                else if (Input.GetKey("a"))
                {
                    bufferPos = bufferPos + new Vector3(-movepx, 0);
                    animate.Play("p_walk_s");
                    gameObject.GetComponent<SpriteRenderer>().flipX = false;
                }
                else if (Input.GetKey("d"))
                {
                    bufferPos = bufferPos + new Vector3(movepx, 0);
                    animate.Play("p_walk_s");
                    gameObject.GetComponent<SpriteRenderer>().flipX = true;
                }
                if (col.GetTile(col.WorldToCell(bufferPos)) == null)
                {
                    transform.position = bufferPos;
                    PlayerStats.playerPos = bufferPos;
                    lastMove = Time.time;
                }
                if (bkg.GetTile(bkg.WorldToCell(transform.position)).name == "Tile_main_109")
                {
                    if (Random.Range(0, 1000) < 200)
                    {
                        SceneManager.LoadScene(1);
                    }
                }
            }
        }
        else
        {
            if (curSprite.sprite.name == "character_0" || curSprite.sprite.name == "character_2")
            {
                curSprite.sprite = idleSpriteD;
            }
            if (curSprite.sprite.name == "character_3" || curSprite.sprite.name == "character_5")
            {
                curSprite.sprite = idleSpriteU;
            }
            if (curSprite.sprite.name == "character_6" || curSprite.sprite.name == "character_8")
            {
                curSprite.sprite = idleSpriteS;
            }
            animate.Play("stop");

            
        }
    }
}
