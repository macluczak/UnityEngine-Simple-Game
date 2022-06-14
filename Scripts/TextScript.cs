using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextScript : MonoBehaviour
{

    private TMP_Text textMeshPro;
    
    private void Start()
    {
        textMeshPro = GetComponent<TMP_Text>();
        textMeshPro.text = "Turn: X";
    }

    public void TurnSetLabel(int index)
    {
        textMeshPro = GetComponent<TMP_Text>();
        if (index == 1)
        {
            textMeshPro.text = "Turn: X";
        }
        else if(index == 0)
        {
            textMeshPro.text = "Turn: O";
        }
    }

    public void MatchEndLabel(int index)
    {
        textMeshPro = GetComponent<TMP_Text>();
        if (index == 1)
        {
            textMeshPro.text = "O Wins!";
        }
        else if (index == 0)
        {
            textMeshPro.text = "X Wins!";
        }
        else if(index == -1)
        {
            textMeshPro.text = " Draw!";
        }

    }

}
