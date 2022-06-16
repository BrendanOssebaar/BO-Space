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
    [SerializeField]
    private GameObject planetstat;
    
    void checkfullfuel()
    {
        fuel = planetstat.GetComponent<PlanetStats>().currentFuel;
        tank_full = planetstat.GetComponent<PlanetStats>().maxFuel;

        if (tank_full <= fuel)
        {
            full = true;
        }
    }
    void Update()
    {
        checkfullfuel();
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
