using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlanetStats : MonoBehaviour
{
    public enum planetType {Desert, Ruined, Lush }
    public planetType PlanetType;
    float currentTime;
    float startingTime = 300f;
    private int maxFuel;
    public int currentFuel;
    public Fuelbar fuelbar;
    public void planets()
    {
        switch(PlanetType)
        {
            case planetType.Desert:
                Debug.Log("Desert");
                maxFuel = 500;
                break;
            case planetType.Ruined:
                Debug.Log("Ruined");
                maxFuel = 1500;
                break;
            case planetType.Lush:
                Debug.Log("Lush");
                maxFuel = 3000;
                break;
        }
    }
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
