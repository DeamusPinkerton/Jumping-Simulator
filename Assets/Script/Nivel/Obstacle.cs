using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private Collider _collider;
    NewPLayerController NewPLayerController;
    private void Start()
    {
        _collider = GetComponent<Collider>();
        NewPLayerController = GameObject.FindObjectOfType<NewPLayerController>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            NewPLayerController.Die();
            TriggerDesactive();
        }
    }

    void TriggerDesactive()
    {
        _collider.isTrigger = false;
    }    


    void Update()
    {
        
    }
}
