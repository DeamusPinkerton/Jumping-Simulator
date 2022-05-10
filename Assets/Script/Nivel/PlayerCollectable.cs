using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollectable : MonoBehaviour
{
    public GameObject coin;
    public Text CoinText;
    public int Coins = 0;
    private bool Stonks = false;
    [SerializeField]
    private float StonksUp = 0;
    public GameObject StonksBoost;

    void Update()
    {
        CoinText.text = Coins.ToString();
    }

    void FixedUpdate()
    {
        if (Stonks)
        {
            StonksUp++;
            if (StonksUp >= 500)
            {
                Stonks = false;
                StonksBoost.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            coin = other.gameObject;
            Destroy(coin);
            CallCanvas();
        }
        if (other.gameObject.tag == "Stonks")
        {
            coin = other.gameObject;
            Destroy(coin);
            Stonks = true;
            StonksUp = 0;
            StonksBoost.SetActive(true);
        }
    }

    void CallCanvas()
    {
        Coins++;
        if (Stonks)
        {
            Coins++;
        }   
    }
}
