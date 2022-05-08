using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollectable : MonoBehaviour
{
    public GameObject coin;
    public Text CoinText;
    public int Coins = 0;

    void Update()
    {
        CoinText.text = Coins.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            coin = other.gameObject;
            Destroy(coin);
            CallCanvas();
        }
    }

    void CallCanvas()
    {
        Coins++;
    }
}
