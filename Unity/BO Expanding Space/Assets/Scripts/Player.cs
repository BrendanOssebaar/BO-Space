using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] public UI_Inventory uiInventory;
    float currentTime;
    float startingTime = 500f;
    public int maxFuel;
    public int currentFuel;
    public Fuelbar fuelbar; 

    private Inventory inventory;
    void Start()
    {
        currentTime = startingTime;
        inventory = new Inventory();
       // uiInventory.SetInventory(inventory);
        // fuelbar.setMaxFuel(maxFuel);
        // currentFuel = 0;
    }
    void checkTime()
    {
        currentTime -= 1 * Time.deltaTime;
        if (currentTime <= 0)
        {
            SceneManager.LoadScene(6);
        }
    }
   
    
    public void Update()
    {
        checkTime();
        
    }

    

}
