using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlanetStats : MonoBehaviour
{
    public enum planetType {Desert, Ruined, Lush }
    public planetType PlanetType;
    
    
    public int maxFuel;
    public int currentFuel;
    public Fuelbar fuelbar;
    public int Planets()
    {
        switch(PlanetType)
        {
            default:
                maxFuel = 0;
                return maxFuel;
            case planetType.Desert:
                Debug.Log("Desert");
                maxFuel = 500;
                return maxFuel;
            case planetType.Ruined:
                Debug.Log("Ruined");
                maxFuel = 1500;
                return maxFuel;
            case planetType.Lush:
                Debug.Log("Lush");
                maxFuel = 3000;
                return maxFuel;
        }
    }
        public void Start()
    {
        fuelbar.setMaxFuel(maxFuel);
        currentFuel = 0;
        Planets();
    }

    // Update is called once per frame
    void Update()
    {
                
    }
    public void AddFuel(int addedfuel)
    {
        currentFuel += addedfuel;
        fuelbar.setFuel(currentFuel);
    }

}
