using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debris : MonoBehaviour
{
    private Rigidbody debrisRB;
    private GameObject player;
    [SerializeField] private float reactDistance = 30f;

    void Start()
    {
        debrisRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
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
