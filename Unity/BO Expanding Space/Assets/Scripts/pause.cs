using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    public GameObject player;
    public GameObject overlay;
    public GameObject overlay2;

    void Start()
    {
        
        player.SetActive(true);
        overlay.SetActive(false);
        overlay2.SetActive(true);

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            player.GetComponent<PlayerMovement>().enabled = false;
            overlay.SetActive(true);
            overlay2.SetActive(false);
        }
    }
}
