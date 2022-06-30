using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed = 10;
    private Rigidbody2D player;
    [SerializeField]
    private float jumpHeight = 27;
    private bool onGround;
    private AudioSource audioSource;
    [SerializeField]
    private AudioClip footsteps;

    void Awake()
    {
        player = GetComponent<Rigidbody2D>();

    }
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Stop();
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-movementSpeed, 0) * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 180, 0);
            sound();
        }  else if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(movementSpeed, 0) * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 0);
            sound();
        }
        else
        {
            audioSource.Stop();
        }
        if ((onGround == true) && (Input.GetKeyDown(KeyCode.Space)))
            {
                Vector2 jump = new Vector2(0, jumpHeight);
                player.velocity = new Vector2(player.velocity.x, 0);
                player.AddForce(jump, ForceMode2D.Impulse);
                onGround = false;

        }
        
    }
    public void sound()
    {
        if(audioSource.isPlaying == false)
        {
            audioSource.Play();
        }
        
    }
   
    void Update()
    {
        Movement();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        onGround = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        onGround = false;
    }
}
