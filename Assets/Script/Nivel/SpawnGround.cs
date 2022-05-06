using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGround : MonoBehaviour
{
    public GameObject GroundTile;
    Vector3 NextSpawn;

    public void SpawnTile() 
    {
        GameObject temp = Instantiate(GroundTile, NextSpawn, Quaternion.identity);
        NextSpawn = temp.transform.GetChild(1).transform.position;

    }
    private void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            SpawnTile();
        }

    }

}
