using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<Items> itemlist;
    public Inventory ()
    {
        itemlist = new List<Items>();
        AddItem(new Items { type = Items.InteractionType.RoditeFuel, amount = 1 });
        Debug.Log(itemlist.Count);
    }
    public void AddItem(Items item)
    {
        itemlist.Add(item);
    }
}
