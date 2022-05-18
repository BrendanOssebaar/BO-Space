using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    private int maxFuel = 600;
    public int currentFuel;
    public Fuelbar fuelbar;

    void Start()
    {

        
        fuelbar.setMaxFuel(maxFuel);
        currentFuel = 0;
    }
    internal void OnTriggerEnter(Collider fuelWood)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Destroy(fuelWood.gameObject);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AddFuel(10);
        }
    }

    void AddFuel(int addedfuel)
    {
        currentFuel += addedfuel;
        fuelbar.setFuel(currentFuel);
    }

}
