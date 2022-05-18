using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Transform detectionPoint;
    private const float detectionRadius = 0.2f;
    public LayerMask detectionLayer;

    void Update()
    {
        if(DetectObject())
        {
            if(InteractionInput())
            {
                Debug.Log("Pick Up");
                Debug.Log("Destroy");
            }
        }
    }
    internal bool InteractionInput()
    {
        return Input.GetKeyDown(KeyCode.E);
    }
    bool DetectObject()
    {
        return Physics2D.OverlapCircle(detectionPoint.position,detectionRadius,detectionLayer);
        
    }
}
