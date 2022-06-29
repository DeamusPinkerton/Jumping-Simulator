using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations 
{
    Animator _animator;
    int IsDead;
    int IsJumping;
    int IsLanding;
    int IsFalling;
    public void Start()
    {
        IsDead = Animator.StringToHash("IsDead");
        IsJumping = Animator.StringToHash("IsJumping");
        IsJumping = Animator.StringToHash("IsLanding");
        IsJumping = Animator.StringToHash("IsFalling");
    }

    public Animations(Animator animator)
    {
        _animator = animator;
    }
    public void Jumping1()
    {
        _animator.SetBool("IsJumping", true);
    }
    public void Jumping0()
    {
        _animator.SetBool("IsJumping", false);
    }

    public void Landing1()
    {
        _animator.SetBool("IsLanding", true);
    }
    public void Landing0()
    {
        _animator.SetBool("IsLanding", false);
    }
    public void Falling1()
    {
        _animator.SetBool("IsFalling", true);
    }
    public void Falling0()
    {
        _animator.SetBool("IsFalling", false);
    }

    public void Dead1()
    {
        _animator.SetBool("IsDead", true);
    }
    public void Dead0()
    {
        _animator.SetBool("IsDead", false);
    }
}
