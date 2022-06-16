using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakenButton : MonoBehaviour
{
    public GameObject button;
    float currentTime;
    float startingTime;
    private void Start()
    {
        currentTime = startingTime;
    }
    void checkTime()
    {
        currentTime += 1 * Time.deltaTime;
        if (currentTime >= 15)
        {
            button.SetActive(true);
        }
    }
    private void Update()
    {
        checkTime();
    }
}
