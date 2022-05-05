using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    SpawnGround GroundSpawner;
    // Start is called before the first frame update
    void Start()
    {
        GroundSpawner = GameObject.FindObjectOfType<SpawnGround>();
        ObstacleSpawn();
    }
    private void OnTriggerExit(Collider other)
    {
        GroundSpawner.SpawnTile();
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    public GameObject ObstaclePrefab;

    void ObstacleSpawn()
    {
        int ObstacleSpawnIndex = Random.Range(2, 5);
        Transform SpawnPoint = transform.GetChild(ObstacleSpawnIndex).transform;

        Instantiate(ObstaclePrefab, SpawnPoint.position, Quaternion.identity, transform);
    }
}
