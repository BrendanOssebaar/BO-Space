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
    public PlanetStats planetstats;
    public string scene;
    void checkfullfuel()
    {
        fuel = planetstats.GetComponent<PlanetStats>().currentFuel;
        tank_full = planetstats.GetComponent<PlanetStats>().maxFuel;

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
            // Debug.Log("end_leave");
            SceneManager.LoadScene(scene);
        }
    }
}
