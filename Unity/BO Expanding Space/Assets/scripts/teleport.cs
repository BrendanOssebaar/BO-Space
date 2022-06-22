using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public GameObject player;
    public GameObject endA;
    public GameObject endB;
    
     private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "endsideA")
        {
            player.transform.position = new Vector2(endB.gameObject.transform.position.x + 0.7f, player.gameObject.transform.position.y);
            Debug.Log("teleportA");
        }

        if (gameObject.tag == "endsideB")
        {
            player.transform.position = new Vector2(endA.gameObject.transform.position.x + -0.7f, player.gameObject.transform.position.y);
            Debug.Log("teleportB");
        }
    }
      
}    
