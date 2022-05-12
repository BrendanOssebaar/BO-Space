using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float movementSpeed = 3;
    public Rigidbody2D player;
    public float jumpHeight = 10;
    bool onGround;
    
    
   
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
        if (Input.GetKey(KeyCode.W)&& onGround==true)
        {
            player.AddForce(new Vector2(0, jumpHeight)* Time.deltaTime, ForceMode2D.Impulse);
            
        }  
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
