using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
    public LayerMask layermask;
    public int offset1 = 10000;


    void Start()
    {
        RaycastHit2D hitinfo = Physics2D.Raycast(origin: transform.position, -Vector2.up, Mathf.Infinity, layermask);
        Debug.DrawRay(transform.position, -Vector2.up, Color.red, 2);
        transform.position = hitinfo.point;
    }
}
