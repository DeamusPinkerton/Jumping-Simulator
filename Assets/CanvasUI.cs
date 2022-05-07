using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasUI : MonoBehaviour
{
    public Text CoinText;
    public int Coins = 0;

    void Update()
    {
        CoinText.text = Coins.ToString();
    }

    public void GetCoin()
    {
        Coins++;
    }
}
