using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public GameObject player;
    float posx;
    float posy;
    public GameObject cam;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        posx = player.transform.position.x;
        posy = player.transform.position.y;

        if (posy == 0)
        {
            posy = 0; 
        }

        else {
            transform.position = new Vector3(posx,posy,-10);
        }
        
    }
}
