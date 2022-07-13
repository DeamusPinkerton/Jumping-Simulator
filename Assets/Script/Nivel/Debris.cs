using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debris : EntityManager
{
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);

        if (distance <= reactDistance)
        {
            RB.useGravity = true;
        }

        if ((transform.position.z - player.transform.position.z) < MinDist)
        {
            Destroy(this);
        }
    }
}
