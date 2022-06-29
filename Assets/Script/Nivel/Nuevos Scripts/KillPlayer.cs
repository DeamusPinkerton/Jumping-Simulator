using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour //TP2 - Roman A Martinez
{
    public delegate void PlayerKill();
    public static PlayerKill OnPlayerKill;
 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            OnPlayerKill?.Invoke();
        }
    }

}
