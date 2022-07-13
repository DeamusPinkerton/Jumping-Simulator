using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunterEnemy : EntityManager
{
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        player = GameObject.FindWithTag("Player");
    }
    private void FixedUpdate()
    {
        float distance = Vector3.Distance(player.transform.position, transform.position);
        Vector3 lookDirection;

        Vector3 targetPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);

        if (distance <= reactDistance)
        {
            if (distance > 5)
            {
                targetPos.z += (distance * 0.5f);

            }
            lookDirection = (targetPos - transform.position).normalized;
            RB.AddForce(lookDirection * MovementSpeed);
        }
        else
        {
            lookDirection = (targetPos - transform.position).normalized;
            RB.AddForce(lookDirection * MovementSpeed * 0.2f);
        }

        if ((transform.position.z - player.transform.position.z) < MinDist)
        {
            Destroy(this);
        }
    }
}
