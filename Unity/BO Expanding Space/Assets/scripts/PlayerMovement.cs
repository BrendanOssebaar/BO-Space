using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 10;
    private Rigidbody2D player;
    public float jumpHeight = 27;
    public bool onGround;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();

    }

    void Movement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-movementSpeed, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(movementSpeed, 0) * Time.deltaTime;
        }
        if ((onGround == true) && (Input.GetKeyDown(KeyCode.W)))
        {
            Vector2 jump = new Vector2(0, jumpHeight);

            player.AddForce(jump, ForceMode2D.Impulse);
            onGround = false;
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
