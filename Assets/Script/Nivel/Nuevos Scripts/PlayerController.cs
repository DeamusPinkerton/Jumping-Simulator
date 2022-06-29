using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _jumpForce;

    Rigidbody _rigidbody2;
    Animator _animator;

    Controll _controll;
    Motions _motions;
    Animations _animations;

    private void Awake()
    {
        _rigidbody2 = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }
    void Start()
    {
        _animations = new Animations(_animator);
        _motions = new Motions(transform, _rigidbody2, _jumpForce);
        //_controll = new Controll(_animations);
    }
    void Update()
    {

    }
}
