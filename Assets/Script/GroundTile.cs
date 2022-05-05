using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    SpawnGround GroundSpawner;
    Coins SpawnCoin;
    // Start is called before the first frame update
    void Start()
    {
        GroundSpawner = GameObject.FindObjectOfType<SpawnGround>();
        ObstacleSpawn();
        CoinSpawn();
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
    public GameObject CoinPrefab;

    void ObstacleSpawn()
    {
        int ObstacleSpawnIndex = Random.Range(2, 5);
        Transform SpawnPoint = transform.GetChild(ObstacleSpawnIndex).transform;

        Instantiate(ObstaclePrefab, SpawnPoint.position, Quaternion.identity, transform);
    }

    void CoinSpawn()
    {
        int ObstacleSpawnIndex = Random.Range(5, 8);
        Transform SpawnPoint = transform.GetChild(ObstacleSpawnIndex).transform;

        Instantiate(CoinPrefab, SpawnPoint.position, Quaternion.identity, transform);
    }

    // public GameObject CoinPrefab;
    // void CoinSpawn()
    // {
    //int CoinsToSpawn = 10;
    // for (int i = 0; i < CoinsToSpawn; i++)
    //{
    //GameObject temp = Instantiate(CoinPrefab);
    //
    // }
}
