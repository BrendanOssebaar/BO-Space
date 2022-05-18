using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 10;
    public Rigidbody2D player;
    public float jumpHeight = 20;
    bool onGround;
    private Vector2 validDirection = Vector2.right;
    private Vector2 validDirectionS = Vector2.left;
    private Vector2 validDirectionB = Vector2.down;
    private float contactThreshold = 30;


    void Start()
    {
        
    }

   
    void Update()
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        onGround = true;

        if (collision.gameObject.name == "Platform")
        {
            for (int k = 0; k < collision.contacts.Length; k++)
            {
                if (Vector2.Angle(collision.contacts[k].normal, validDirection) <= contactThreshold)
                {
                    onGround = false;
                    break;
                }
            }

            for (int k = 0; k < collision.contacts.Length; k++)
            {
                if (Vector2.Angle(collision.contacts[k].normal, validDirectionS) <= contactThreshold)
                {
                    onGround = false;
                    break;
                }
            }
            for (int k = 0; k < collision.contacts.Length; k++)
            {
                if (Vector2.Angle(collision.contacts[k].normal, validDirectionB) <= contactThreshold)
                {
                    onGround = false;
                    break;
                }
            }
        }
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        onGround = false;
    }
}
