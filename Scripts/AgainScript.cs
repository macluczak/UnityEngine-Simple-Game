using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class AgainScript : MonoBehaviour, IPointerClickHandler
{
    private TMP_Text textMeshPro;
    bool isGameOver = false;
    public GameObject gameControler;

    void Start()
    {
        textMeshPro = GetComponent<TMP_Text>();
        textMeshPro.text = "";
        isGameOver = false;

    }

    void Update()
    {
        
    }
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        if (isGameOver)
        {
            Debug.Log("Restart");
            gameControler.GetComponent<GameControler>().RestartMatch();
            textMeshPro.text = "";
            isGameOver = false;

        }
       
    }
    public void ShowQuestion()
    {
        isGameOver = true;
        textMeshPro.text = "Play Again?";
    }
}
