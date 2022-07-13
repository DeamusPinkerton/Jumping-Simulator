using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debris : EntityManager
{
    private Rigidbody debrisRB;
    private GameObject player;

    void Start()
    {
        debrisRB = GetComponent<Rigidbody>();
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);

        if (distance <= reactDistance)
        {
            debrisRB.useGravity = true;
        }

        if ((transform.position.z - player.transform.position.z) < -3f)
        {
            Destroy(this);
        }
    }
}
