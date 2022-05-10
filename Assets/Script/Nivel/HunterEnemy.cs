using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunterEnemy : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed = 0f;
    private Rigidbody huntRB;
    private GameObject player;
    [SerializeField]
    private float reactDistance = 40f;

    void Start()
    {
        huntRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
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
                targetPos.z += (distance / 2f);

            }
            lookDirection = (targetPos - transform.position).normalized;
            huntRB.AddForce(lookDirection * movementSpeed);
        }
        else
        {
            lookDirection = (targetPos - transform.position).normalized;
            huntRB.AddForce(lookDirection * movementSpeed * 0.2f);
        }

        if ((transform.position.z - player.transform.position.z) < -3f)
        {
            Destroy(this);
        }
    }
}
