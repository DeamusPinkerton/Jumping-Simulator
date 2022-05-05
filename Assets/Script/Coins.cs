using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public float SpeedTurn = 90f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "Player")
        {
            return;
        }
        Destroy(gameObject);
    }
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, 0, SpeedTurn * Time.deltaTime);
    }
}
