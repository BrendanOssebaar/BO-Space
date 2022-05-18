using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public GameObject player;
    public GameObject endA;
    public GameObject endB;
    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "endsideA")
        {
            player.transform.position = new Vector2(endB.gameObject.transform.position.x + 1, player.gameObject.transform.position.y);
            Debug.Log("teleportA");
        }

        if (gameObject.tag == "endsideB")
        {
            player.transform.position = new Vector2(endA.gameObject.transform.position.x + -1, player.gameObject.transform.position.y);
            Debug.Log("teleportB");
        }
    }
}