using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    private int maxFuel = 200;
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
    }

    public void AddFuel(int addedfuel)
    {
        currentFuel += addedfuel;
        fuelbar.setFuel(currentFuel);
    }

}
