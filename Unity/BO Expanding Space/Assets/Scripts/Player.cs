using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] public UI_Inventory uiinventory;
    float currentTime;
    float startingTime = 10000f;
    public int maxFuel = 2000;
    public int currentFuel;
    public Fuelbar fuelbar;

    private Inventory inventory;
    void Start()
    {
        currentTime = startingTime;
        inventory = new Inventory();
      //  uiinventory.SetInventory(inventory);
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
        
    }

    public void AddFuel(int addedfuel)
    {
        currentFuel += addedfuel;
        fuelbar.setFuel(currentFuel);
    }

}
