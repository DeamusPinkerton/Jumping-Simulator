using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public int Duration = 2;
    public GameObject ExpEffect;

    void Start()
    {
        Instantiate(ExpEffect, transform.position, transform.rotation);
        Invoke("GoOff", Duration);
    }

    public void GoOff()
    {
        Destroy(this);
    }
}
