using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAssets : MonoBehaviour
{
    public static ItemAssets Instance { get; private set; }


    private void Awake()
    {
        Instance = this;
    }

    public Sprite Coal;
    public Sprite Wood;
    public Sprite Leaf;
    public Sprite Stick;
    public Sprite Rodite; 
}
