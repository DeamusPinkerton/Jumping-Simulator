using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    bool alive = true;
    public float Speed = 5;
    public Rigidbody rb;
    public bool onGround = true;
    float horizontalInput;
    public float horizontalMultiplier = 2;
    public float jumpForce = 5.5f;
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
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Plane")
        {
            onGround = true;
        }
    }
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && onGround)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            onGround = false;
        }
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
