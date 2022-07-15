using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text Timertext;
    private float startTimer;

    void Start()
    {
        startTimer = Time.time;
    }

    void Update()
    {
        float t = Time.time - startTimer;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        Timertext.text = minutes + ":" + seconds;
    }
}
