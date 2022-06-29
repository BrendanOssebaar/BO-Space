using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class pause : MonoBehaviour
{
    public GameObject player;
    public GameObject overlay;
    public GameObject overlay2;
    public VideoPlayer vid;

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
            player.GetComponent<Player>().enabled = false;
            overlay.SetActive(true);
            overlay2.SetActive(false);
            vid.Pause();
        }
    }
}
