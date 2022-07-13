using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollectable : ColectableEntity
{
    public GameObject coin;
    public Text CoinText;
    public int CoolDown;
    [SerializeField] int Coins = 0;
    private bool Stonks = false;
    [SerializeField] private float StonksUp = 0;
    public GameObject StonksBoost;
    public AudioClip[] audios;
    public AudioSource audioPlayer;
    private void Start()
    {
        audioPlayer = this.GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        if (Stonks)
        {
            StonksUp++;
            if (StonksUp >= CoolDown)
            {
                Stonks = false;
                StonksBoost.SetActive(false);
            }
        }
    }
    public override void Collectable(int type) //TPFinal - Juan Manuel Calace
    {
        base.Collectable(type);
        if (type == 1)
        {
            PickUP();
        }
        else if(type == 2)
        {
            powerup();
        }

    }
     void PickUP() //TPFinal - Juan Manuel Calace
    {
        audioPlayer.clip = audios[0];
        audioPlayer.Play();
        if (Stonks == true)
        {
            CallCanvas(add: 2);
        }
        else
        {
            CallCanvas(add: 1);
        }
    }
    void powerup() //TPFinal - Juan Manuel Calace
    {
        audioPlayer.clip = audios[1];
        audioPlayer.Play();
        Stonks = true;
        StonksUp = 0;
        StonksBoost.SetActive(true);
    }

    void CallCanvas(int add) //TPFinal - Juan Manuel Calace
    {
        Coins += add;
        CoinText.text = Coins.ToString();
    }
}
