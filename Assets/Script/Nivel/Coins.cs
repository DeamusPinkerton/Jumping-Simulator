using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public float SpeedTurn = 90f;
    public GameManager gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "Player")
        {
            return;
        }
        gameManager.GetCoin();
        Destroy(gameObject);
    }

    void Update()
    {
        transform.Rotate(0, 0, SpeedTurn * Time.deltaTime);
    }
}
