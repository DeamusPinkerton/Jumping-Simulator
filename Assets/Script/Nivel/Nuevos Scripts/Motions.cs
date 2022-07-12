using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motions : EntityManager
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

    public void Move()
    {
        Vector3 forwardMove = transform.forward * MovementSpeed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * MovementSpeed * Time.fixedDeltaTime * horizontalMultiplier;
        _rigidbody2.MovePosition(_rigidbody2.position + forwardMove + horizontalMove);
    }

    public void Dead()
    {
        MovementSpeed = 0;
    }

    public void jump()
    {
        _rigidbody2.AddForce(new Vector3(0, _jumpForce, 0), ForceMode.Impulse);
    }
}
