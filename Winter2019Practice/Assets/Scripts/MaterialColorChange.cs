using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialColorChange : MonoBehaviour
{
    Color colorStart = Color.black;
    Color colorEnd = Color.white;
    float duration = 1.0f;
    Renderer render;
    public GameAction colorAction;

    private void Start()
    {
        render = GetComponent<Renderer>();
        colorAction.action += ColorFade;
    }

    private void ColorFade()
    {
        float lerp = Mathf.PingPong(Time.time, duration) / duration;
        render.material.color = Color.Lerp(colorStart, colorEnd, lerp);
    }
}
