using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoDeMuerte : MonoBehaviour
{
    Color defaultColor;
    Text text;
    Color newColor;
    bool show;

    void Start()
    {
        text = GetComponent<Text>();
        defaultColor = text.color;
        newColor = defaultColor;
        newColor.a = 0;
        text.color = newColor;
        KillPlayer.OnPlayerKill += ShowText;
    }

    void Update()
    {
        if (show)
        {
            newColor = text.color;
            newColor.a += Time.deltaTime;
            text.color = newColor;
        }
    }
    public void ShowText()
    {
        show = true;
    }
}
