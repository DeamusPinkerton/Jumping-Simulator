using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public Text CoinText;
    public int Coins = 0;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        CoinText.text = Coins.ToString();
    }

    public void GetCoin()
    {
        Coins++;
    }
}
