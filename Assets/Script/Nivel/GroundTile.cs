using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    SpawnGround GroundSpawner;
    Coins SpawnCoin;

    void Start()
    {
        GroundSpawner = GameObject.FindObjectOfType<SpawnGround>();
        VoidSpawn();
        ObstacleSpawn();
        CoinSpawn();
        int EnemyChance = Random.Range(0, 6);
        if (EnemyChance == 1)
        {
            DebrisSpawn();
        }
        else if (EnemyChance < 3)
        {
            EnemySpawn();
        }
        else
        {
            ExtraCoinSpawn();
        }


    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == "Player")
        { 
            GroundSpawner.SpawnTile();
            Destroy(gameObject, 2);
        }
    }

    private void Update()
    {
        
    }

    public GameObject ObstaclePrefab;
    public GameObject CoinPrefab;
    public GameObject EnemyPrefab;
    public GameObject DebrisPrefab;
    public GameObject VoidPrefab;

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

    void EnemySpawn()
    {
        int ObstacleSpawnIndex = Random.Range(8, 10);
        Transform SpawnPoint = transform.GetChild(ObstacleSpawnIndex).transform;

        Instantiate(EnemyPrefab, SpawnPoint.position, Quaternion.identity, transform);
    }

    void DebrisSpawn()
    {
        int ObstacleSpawnIndex = Random.Range(11, 17);
        Transform SpawnPoint = transform.GetChild(ObstacleSpawnIndex).transform;

        Instantiate(DebrisPrefab, SpawnPoint.position, Quaternion.identity, transform);
    }

    void ExtraCoinSpawn()
    {
        int ObstacleSpawnIndex = Random.Range(8, 10);
        Transform SpawnPoint = transform.GetChild(ObstacleSpawnIndex).transform;

        Instantiate(CoinPrefab, SpawnPoint.position, Quaternion.identity, transform);
    }

    void VoidSpawn()
    {
        int ObstacleSpawnIndex = Random.Range(10, 11);
        Transform SpawnPoint = transform.GetChild(ObstacleSpawnIndex).transform;
        Instantiate(VoidPrefab, SpawnPoint.position, Quaternion.identity, transform);
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
