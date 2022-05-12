using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public int maxFuel;
    public int currentFuel;
    public Fuelbar fuelbar;

    void Start()
    {

        
        fuelbar.setMaxFuel(maxFuel);
        currentFuel = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddFuel(10);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            maxFuel = 300;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            maxFuel = 800;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            maxFuel = 1300;
        }

    }

    void AddFuel(int addedfuel)
    {
        currentFuel += addedfuel;
        fuelbar.setFuel(currentFuel);
    }

}
