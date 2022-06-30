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
    private AudioSource walkSource;
    //private AudioSource jumpsource;
    [SerializeField]
    private AudioClip footsteps;
    /*[SerializeField]
    private AudioClip jump;*/

    void Awake()
    {
        player = GetComponent<Rigidbody2D>();

    }
    private void Start()
    {
        walkSource = GetComponent<AudioSource>();
        //jumpsource = GetComponent<AudioSource>();
        walkSource.Stop();
        //jumpsource.Stop();
    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-movementSpeed, 0) * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 180, 0);
            soundsteps();
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(movementSpeed, 0) * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, 0, 0);
            soundsteps();
        }
        else
        {
            walkSource.Stop();
            //jumpsource.Stop();
        }
        if ((onGround == true) && (Input.GetKeyDown(KeyCode.Space)))
            {
                Vector2 jump = new Vector2(0, jumpHeight);
                player.velocity = new Vector2(player.velocity.x, 0);
                player.AddForce(jump, ForceMode2D.Impulse);
                onGround = false;
            //soundjump();
        }
        
        
    }
    /*void makesounds()
    {
        if (Input.GetKey(KeyCode.A) && onGround == true)
        {
            soundsteps();
        }
        if (Input.GetKey(KeyCode.D) && onGround == true)
        {
            soundsteps();
        }
        else
        {
            walkSource.Stop();
            //jumpsource.Stop();
        }
    }*/
    public void soundsteps()
    {
        if(walkSource.isPlaying == false)
        {
            walkSource.Play();
        }
        
    }
    /*public void soundjump()
    {
        if (jumpsource.isPlaying == false)
        {
            jumpsource.Play();
        }

    }*/

    void Update()
    {
        Movement();
        //makesounds();
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
