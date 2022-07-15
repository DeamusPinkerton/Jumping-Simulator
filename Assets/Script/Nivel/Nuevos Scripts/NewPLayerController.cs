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
    public float Speedup;
    private float Timelapse;
    public float BaseTimelapse;
    public float FMovementSpeed;
    public AudioClip[] audios;
    public AudioSource audioPlayer;
    private int _life = 1;


    delegate void DestroyRB();
    DestroyRB DestroyRb;

    public Rigidbody _rigidbody2;
    Animator _animator;
    Animations _animations;
    private void Awake()
    {
        _rigidbody2 = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
        Timelapse = BaseTimelapse;
        FMovementSpeed = MovementSpeed;
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
        Vector3 forwardMove = transform.forward * FMovementSpeed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * MovementSpeed * Time.fixedDeltaTime * horizontalMultiplier;
        _rigidbody2.MovePosition(_rigidbody2.position + forwardMove + horizontalMove);
        _animations.Dead0();

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -4.65f, 4.65f), transform.position.y, transform.position.z);

        if (Time.timeSinceLevelLoad > Timelapse)
        {
            FMovementSpeed += Speedup;
            Timelapse += 10;
        }
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
        DestroyRb = destroyRb;
        MovementSpeed = 0;
        alive = false;
        audioPlayer.clip = audios[1];
        audioPlayer.Play();
        Invoke("Restart", 2);
    }
    void destroyRb()
    {
        Object.Destroy(_rigidbody2);
    }
    private void OnTriggerEnter(Collider other) //TPFinal - Juan Manuel Calace
    {
        if (other.gameObject.tag == "Coin")
        {
            GetComponent<ColectableEntity>().Collectable (1);
        }
        if (other.gameObject.tag == "Stonks")
        {
            GetComponent<ColectableEntity>().Collectable (2);
        }
        if (other.gameObject.tag == "Apple")
        {
            GetComponent<ColectableEntity>().Collectable(3);
        }
    }
    public override void Damage(int dmg) //TPFinal - Roman A Martinez Cristaldo
    {
        base.Damage(dmg);
        _life -= dmg;
        if (_life <= 0)
        {
            Die();
        }
    }

    public void AddSpeed() //TPFinal - Juan Manuel Calace
    {
        FMovementSpeed += 2;
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
