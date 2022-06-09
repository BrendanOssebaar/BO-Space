using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Transform detectionPoint;
    private const float detectionRadius = 0.2f;
    public LayerMask detectionLayer;
    public GameObject detectedObject;
    public List<GameObject> pickedItems = new List<GameObject>();


    void checkObject()
    {
        if (DetectObject())
        {
            if (InteractionInput())
            {
                detectedObject.GetComponent<Items>().Interact();
            }
        }
    }


    void Update()
    {
        checkObject();
       
    }
    internal bool InteractionInput()
    {
        return Input.GetKeyDown(KeyCode.E);
    }
    bool DetectObject()
    {
        Collider2D obj = Physics2D.OverlapCircle(detectionPoint.position,detectionRadius,detectionLayer);
        if (obj == null)
        {
            detectedObject = null;
            return false;
        }
        else
        {
            detectedObject = obj.gameObject;
            return true;
        }
    }
    public void PickUpItem(GameObject item)
    {
        pickedItems.Add(item);
    }
}
