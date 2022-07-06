using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewPLayerController : EntityManager
{
    bool alive = true;
    public bool onGround = true;
    float horizontalInput;
    public float horizontalMultiplier = 2;
    public float jumpForce;
    public AudioClip[] audios;
    public AudioSource audioPlayer;


    delegate void DestroyRB();//TP2 - Juan Calace
    DestroyRB DestroyRb;//TP2 - Juan Calace

    public Rigidbody _rigidbody2;
    Animator _animator;
    Animations _animations;
    private void Awake()
    {
        _rigidbody2 = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }
    void Start()
    {
        audioPlayer = this.GetComponent<AudioSource>();
        _animations = new Animations(_animator);
        _animations.Start();
    }
    private void FixedUpdate()
    {
        if (!alive) return;

        Vector3 forwardMove = transform.forward * MovementSpeed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * MovementSpeed * Time.fixedDeltaTime * horizontalMultiplier;
        _rigidbody2.MovePosition(_rigidbody2.position + forwardMove + horizontalMove);
        _animations.Dead0();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Plane")
        {
            onGround = true;
            _animations.Falling0();
            _animations.Landing1();
        }
    }
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Jump") && onGround)
        {
            _rigidbody2.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            onGround = false;
            _animations.Jumping1();
            _animations.Landing0();
            _animations.Falling1();
            audioPlayer.clip = audios[0];
            audioPlayer.Play();
        }
        else
        {
            _animations.Jumping0();
        }
    }
    public void Die()
    {
        _animations.Dead1();
        DestroyRb = destroyRb;//TP2 - Juan Calace
        MovementSpeed = 0;
        alive = false;
        audioPlayer.clip = audios[1];
        audioPlayer.Play();
        Invoke("Restart", 2);
    }
    void destroyRb()//TP2 - Juan Calace
    {
        Object.Destroy(_rigidbody2);//TP2 - Juan Calace
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
