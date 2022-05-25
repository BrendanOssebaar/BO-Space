using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    float currentTime;
    float startingTime = 10f;
    private int maxFuel = 2000;
    public int currentFuel;
    public Fuelbar fuelbar;

    void Start()
    {
        currentTime = startingTime;
        
        fuelbar.setMaxFuel(maxFuel);
        currentFuel = 0;
    }
    
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        if(currentTime <= 0)
        {
            SceneManager.LoadScene(1);
        }
        if (currentFuel >= 2000)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void AddFuel(int addedfuel)
    {
        currentFuel += addedfuel;
        fuelbar.setFuel(currentFuel);
    }

}
