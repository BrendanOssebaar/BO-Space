using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    internal void OnTriggerEnter(Collider other)
    {
        if(Input.GetKeyDown(KeyCode.E))
            {
            Destroy(other.gameObject);
            }
    }
}
