using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class leave_planet : MonoBehaviour
{
    public int fuel;
    public int tank_full;
    public bool full = false;

    void Update()
    {
        fuel = GameObject.Find("player").GetComponent<Player>().currentFuel;
        tank_full = GameObject.Find("player").GetComponent<Player>().maxFuel;

        if (tank_full == fuel || tank_full < fuel)
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
