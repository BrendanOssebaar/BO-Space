using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public int currentFuel;
    public Fuelbar fuelbar;

    void Start()
    {
        
        
        
    }
    
    void Update()
    {
        
        
    }
    public void AddFuel(int addedfuel)
    {
        currentFuel += addedfuel;
        fuelbar.setFuel(currentFuel);
    }


}
