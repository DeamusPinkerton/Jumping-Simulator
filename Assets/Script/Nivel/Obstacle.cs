using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private Collider _collider;
    private void Start()
    {
        _collider = GetComponent<Collider>();
    }

    private void OnCollisionEnter(Collision collision) //TPFinal - Roman A Martinez Cristaldo
    {
        var player = collision.gameObject.GetComponent<EntityManager>();
        if (player!= null)
        {
            player.Damage(1);
            TriggerDesactive();
        }
    }

    void TriggerDesactive()
    {
        _collider.isTrigger = false;
    }    
}
