using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    NewPLayerController NewPLayerController;
    private void Start()
    {
        NewPLayerController = GameObject.FindObjectOfType<NewPLayerController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            //playerMovement.Die();
            NewPLayerController.Die();
        }
    }

    void Update()
    {
        
    }
}
