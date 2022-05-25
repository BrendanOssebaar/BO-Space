using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leave_planet : MonoBehaviour
{
    public Slider fuelbar;
    public int fuel;
    public int tank_full;
    public bool full = false;
    public int i;
    void Start()
    {
        
    }

    
    void Update()
    {

        fuel = GameObject.Find("ThePlayer").GetComponent<Player>().currentFuel;
        tank_full = GameObject.Find("ThePlayer").GetComponent<Player>().maxFuel;


        if (tank_full == fuel || tank_full > fuel)
        {
            full = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (full == true){

        }
    }
}
