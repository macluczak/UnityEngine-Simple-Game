using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FogScript : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        var tempColor = spriteRenderer.color;
        tempColor.a = 0f;
        spriteRenderer.color = tempColor;
    }

    public void FogGame()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        var tempColor = spriteRenderer.color;
        tempColor.a = 0.7f;
        spriteRenderer.color = tempColor;
    }

    public void UnFogGame()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        var tempColor = spriteRenderer.color;
        tempColor.a = 0f;
        spriteRenderer.color = tempColor;
    }




}
