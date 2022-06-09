using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_pos : MonoBehaviour
{
    void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, 10000))
        {
            print("Hit something!");
        }
            
    }
}
