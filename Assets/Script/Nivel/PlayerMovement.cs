using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    bool alive = true;
    public float Speed = 5;
    public Rigidbody rb;

    float horizontalInput;
    public float horizontalMultiplier = 2;

    Animator Animator;
    int IsDead;

    private void Start()
    {
        Animator = GetComponent<Animator>();
        IsDead = Animator.StringToHash("IsDead");
    }
    private void FixedUpdate()
    {
        if (!alive) return;

        Vector3 forwardMove = transform.forward * Speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * Speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
        Animator.SetBool("IsDead", false);
    }
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

    }

    public void Die()
    {
        Animator.SetBool("IsDead", true);
        Object.Destroy(rb);
        Speed = 0;
        alive = false;
        Invoke("Restart", 2);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
