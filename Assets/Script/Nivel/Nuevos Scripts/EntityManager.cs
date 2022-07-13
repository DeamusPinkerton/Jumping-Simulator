using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EntityManager : MonoBehaviour
{
    public float MovementSpeed;
    [SerializeField] public float reactDistance;
    public virtual void Damage(int dmg)
    {

    }
}
