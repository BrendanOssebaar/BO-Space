using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlanetStats : MonoBehaviour
{
    float currentTime;
    float startingTime = 10f;
    private int maxFuel = 2000;
    public int currentFuel;
    public Fuelbar fuelbar;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        fuelbar.setMaxFuel(maxFuel);
        currentFuel = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        if (currentTime <= 0)
        {
            SceneManager.LoadScene(1);
        }
        if (currentFuel >= 2000)
        {
            SceneManager.LoadScene(2);
        }
    }
    
}
