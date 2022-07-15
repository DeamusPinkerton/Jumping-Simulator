using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dispenser : EntityManager
{
    public GameObject ExplodePrefab;

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
            Transform SpawnPoint = transform.GetChild(1).transform;
            Instantiate(ExplodePrefab, SpawnPoint.position, Quaternion.identity, transform);
            Destroy(this);
        }

        if ((transform.position.z - player.transform.position.z) < MinDist)
        {
            Destroy(this);
        }
    }
}