using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectCoin : MonoBehaviour
{
    public GameObject PickUpEffect;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(PickUpEffect, transform.position, transform.rotation);
        }
    }
}
