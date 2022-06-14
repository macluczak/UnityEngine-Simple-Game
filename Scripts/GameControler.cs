using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour
{
    int spriteIndex = -1;
    int turnCounter = 0;
    public GameTurn[] gameMatrix;
    public GameObject textScript;
    public GameObject fogScript;
    public GameObject againtScript;
    int winFLag = -1;

    private void Start()
    {
         spriteIndex = -1;
         turnCounter = 0;
         winFLag = -1;
    }

    public void RestartMatch()
    {
        fogScript.GetComponent<FogScript>().UnFogGame();
        foreach (var item in gameMatrix)
        {
            item.EnableTouch();
            item.token = -1;
           
        }
        if(winFLag == 0)
        {
            spriteIndex = 0;
            textScript.GetComponent<TextScript>().TurnSetLabel(winFLag);
        }
        else if(winFLag == 1)
        {
            spriteIndex = -1;
            textScript.GetComponent<TextScript>().TurnSetLabel(winFLag);
        }
        else
        {
            spriteIndex = -1;
            textScript.GetComponent<TextScript>().TurnSetLabel(1);
        }

        turnCounter = 0;
        winFLag = -1;
    }




    public int PlayerTurn()
    {

        spriteIndex++;
        turnCounter++;

        int index = spriteIndex % 2;

        textScript.GetComponent<TextScript>().TurnSetLabel(index);


        return index;
    }
public void TokenRegister(int id)
    {
        

        Debug.Log($"id: {id}, token:{gameMatrix[id].token}");
        

        if(gameMatrix[0].token == 0 & gameMatrix[1].token == 0 & gameMatrix[2].token == 0)
        {
            winFLag = 0;
            Debug.Log($"O WINS");
        }

        else if (gameMatrix[3].token == 0 & gameMatrix[4].token == 0 & gameMatrix[5].token == 0)
        {
            winFLag = 0;
            Debug.Log($"O WINS");
        }

        else if (gameMatrix[6].token == 0 & gameMatrix[7].token == 0 & gameMatrix[8].token == 0)
        {
            winFLag = 0;
            Debug.Log($"O WINS");
        }

        else if (gameMatrix[0].token == 0 & gameMatrix[3].token == 0 & gameMatrix[6].token == 0)
        {
            winFLag = 0;
            Debug.Log($"O WINS");
        }

        else if (gameMatrix[1].token == 0 & gameMatrix[4].token == 0 & gameMatrix[7].token == 0)
        {
            winFLag = 0;
            Debug.Log($"O WINS");
        }

        else if (gameMatrix[2].token == 0 & gameMatrix[5].token == 0 & gameMatrix[8].token == 0)
        {
            winFLag = 0;
            Debug.Log($"O WINS");
        }




        else if (gameMatrix[0].token == 1 & gameMatrix[1].token == 1 & gameMatrix[2].token == 1)
        {
            winFLag = 1;
            Debug.Log($"X WINS");
        }

        else if (gameMatrix[3].token == 1 & gameMatrix[4].token == 1 & gameMatrix[5].token == 1)
        {
            winFLag = 1;
            Debug.Log($"X WINS");
        }

        else if (gameMatrix[6].token == 1 & gameMatrix[7].token == 1 & gameMatrix[8].token == 1)
        {
            winFLag = 1;
            Debug.Log($"X WINS");
        }

        else if (gameMatrix[0].token == 1 & gameMatrix[3].token == 1 & gameMatrix[6].token == 1)
        {
            winFLag = 1;
            Debug.Log($"X WINS");
        }

        else if (gameMatrix[1].token == 1 & gameMatrix[4].token == 1 & gameMatrix[7].token == 1)
        {
            winFLag = 1;
            Debug.Log($"X WINS");
        }

        else if (gameMatrix[2].token == 1 & gameMatrix[5].token == 1 & gameMatrix[8].token == 1)
        {
            winFLag = 1;
            Debug.Log($"X WINS");
        }


        else if (gameMatrix[0].token == 0 & gameMatrix[4].token == 0 & gameMatrix[8].token == 0)
        {
            winFLag = 0;
            Debug.Log($"O WINS");
        }

        else if (gameMatrix[2].token == 0 & gameMatrix[4].token == 0 & gameMatrix[6].token == 0)
        {
            winFLag = 0;
            Debug.Log($"O WINS");
        }

        else if (gameMatrix[0].token == 1 & gameMatrix[4].token == 1 & gameMatrix[8].token == 1)
        {
            winFLag = 1;
            Debug.Log($"X WINS");
        }

        else if (gameMatrix[2].token == 1 & gameMatrix[4].token == 1 & gameMatrix[6].token == 1)
        {
            winFLag = 1;
            Debug.Log($"X WINS");
        }


        if(turnCounter == 9 & winFLag == -1)
        {
            Debug.Log($"It's a Draw!");
             textScript.GetComponent<TextScript>().MatchEndLabel(winFLag);
            fogScript.GetComponent<FogScript>().FogGame();
            againtScript.GetComponent<AgainScript>().ShowQuestion();
            foreach (var item in gameMatrix)
            {
                item.DisableTouch();
            }
        }
        else if(winFLag == 0 || winFLag == 1)
        {
            textScript.GetComponent<TextScript>().MatchEndLabel(winFLag);
            fogScript.GetComponent<FogScript>().FogGame();
            againtScript.GetComponent<AgainScript>().ShowQuestion();
            foreach (var item in gameMatrix)
            {
                item.DisableTouch();
            }
        }

       







    }

}
