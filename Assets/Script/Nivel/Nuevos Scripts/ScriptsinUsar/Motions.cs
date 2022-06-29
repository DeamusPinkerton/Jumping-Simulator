using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motions : MonoBehaviour
{
    Transform _transform;
    Rigidbody _rigidbody2;
    float _jumpForce;
    public float Speed = 5;
    public Rigidbody rb;
    float horizontalInput;
    public float horizontalMultiplier = 2;
    public Motions(Transform transform, Rigidbody rigidbody, float jumpForce)
    {
        _transform = transform;
        _rigidbody2 = rigidbody;
        _jumpForce = jumpForce;
    }
}
