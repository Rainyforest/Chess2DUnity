using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chessman : MonoBehaviour
{
    // References
    public GameObject controller;
    public GameObject movePlate;

    // Positions 
    private int xBoard = -1;
    private int yBoard = -1;

    // Variable to keep track of "black" player or "white" player
    private string player;

    // References for all the sprites
    public Sprite black_queen, black_knight, black_bishop, black_king, black_rook, black_pawn,
                  white_queen, white_knight, white_bishop, white_king, white_rook, white_pawn;

    public void Activate()
    {
        controller = GameObject.FindGameObjectWithTag("GameController");

        // take the instantiated location and adjust the transform
        SetCoords();
        switch (this.name)
        {
            case "black_queen":
                this.GetComponent<SpriteRenderer>().sprite = black_queen; break;
            case "black_knight":
                this.GetComponent<SpriteRenderer>().sprite = black_knight; break;
            case "black_bishop":
                this.GetComponent<SpriteRenderer>().sprite = black_bishop; break;
            case "black_king":
                this.GetComponent<SpriteRenderer>().sprite = black_king; break;
            case "black_rook":
                this.GetComponent<SpriteRenderer>().sprite = black_rook; break;
            case "black_pawn":
                this.GetComponent<SpriteRenderer>().sprite = black_pawn; break;
            case "white_queen":
                this.GetComponent<SpriteRenderer>().sprite = white_queen; break;
            case "white_knight":
                this.GetComponent<SpriteRenderer>().sprite = white_knight; break;
            case "white_bishop":
                this.GetComponent<SpriteRenderer>().sprite = white_bishop; break;
            case "white_king":
                this.GetComponent<SpriteRenderer>().sprite = white_king; break;
            case "white_rook":
                this.GetComponent<SpriteRenderer>().sprite = white_rook; break;
            case "white_pawn":
                this.GetComponent<SpriteRenderer>().sprite = white_pawn; break;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
