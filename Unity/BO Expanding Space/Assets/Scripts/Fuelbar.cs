using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fuelbar : MonoBehaviour
{
    public Slider slider;
    
    
    public void setMaxFuel(int Fuel)
    {
        slider.maxValue = Fuel;
    }

    public void setFuel(int fuel)
    {
        slider.value = fuel;
    }
}
