using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public float SpeedTurn = 90f;

    void Update()
    {
        transform.Rotate(0, 0, SpeedTurn * Time.deltaTime);
    }
}
