using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
    public LayerMask layermask;


    void Start()
    {
        RaycastHit2D hitinfo = Physics2D.Raycast(transform.position, -Vector2.up, Mathf.Infinity, layermask); ;
        transform.position = hitinfo.point;
    }
}
