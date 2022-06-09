using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.ComponentModel;

public class leave_planet : MonoBehaviour
{
    [SerializeField]
    private int fuel;
    [SerializeField]
    private int tank_full;
    [SerializeField]
    private bool full = false;
    

    void Update()
    {
        fuel = GameObject.Find("player").GetComponent<Player>().currentFuel;
        tank_full = GameObject.Find("player").GetComponent<Player>().maxFuel;

        if (tank_full <= fuel)
        {
            full = true;
            Debug.Log("full");
        }
    }
   
    public void leave()
    {
        if (full == true)
        {
            Debug.Log("end_leave");
            SceneManager.LoadScene("WinScene");
        }
    }
}
