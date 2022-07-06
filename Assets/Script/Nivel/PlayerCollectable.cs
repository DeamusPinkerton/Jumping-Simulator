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
    public AudioClip[] audios;
    public AudioSource audioPlayer;
    private void Start()
    {
        audioPlayer = this.GetComponent<AudioSource>();
    }

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
                audioPlayer.clip = audios[0];
                audioPlayer.Play();
                Destroy(coin);
                CallCanvas();
            }
            if (other.gameObject.tag == "Stonks")
            {
                coin = other.gameObject;
                audioPlayer.clip = audios[1];
                audioPlayer.Play();
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
