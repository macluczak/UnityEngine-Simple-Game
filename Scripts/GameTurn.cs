using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTurn : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    GameObject gameControler;
    public Sprite[] images;
    bool unset = true;
    bool isGameOn = true;
    int id;
    static int counter;
   

    public int token = -1;

    GameTurn()
    {
        
        id = counter%9;
        counter++;

    }


    private void OnMouseDown()
    {
        if(unset == true & isGameOn == true)
        {
            unset = false;
            int index = gameControler.GetComponent<GameControler>().PlayerTurn();
            spriteRenderer.sprite = images[index];
            token = index;
            gameControler.GetComponent<GameControler>().TokenRegister(id);


        }

    }

    public void DisableTouch()
    {
       isGameOn = false;
    }
    public void EnableTouch()
    {
        isGameOn = true;
        unset = true;
        spriteRenderer.sprite = null;

    }



    private void Awake()
    {

        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        gameControler = GameObject.Find("Board");
    }

    void Start()
    {
        spriteRenderer.sprite = null;
        unset = true;
        token = -1;
        isGameOn = true;
   
    }



    void Update()
    {
        
    }
}
