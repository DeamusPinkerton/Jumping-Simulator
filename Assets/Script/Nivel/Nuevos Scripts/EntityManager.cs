using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EntityManager : MonoBehaviour //TPFinal - Roman A Martinez Cristaldo
{
    public float MovementSpeed;
    [SerializeField] public Rigidbody RB;
    [SerializeField] public GameObject player;
    [SerializeField] public float reactDistance;
    [SerializeField] public float MinDist = -3f;
    public virtual void Damage(int dmg)
    {

    }
}
