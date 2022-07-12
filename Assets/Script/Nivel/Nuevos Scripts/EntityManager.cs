using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EntityManager : MonoBehaviour
{
    public float MovementSpeed;

    public virtual void Collectable(int type)
    {

    }
}
