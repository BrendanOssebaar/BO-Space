using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;
    private Transform itemSlotTemplate;
    private Transform itemSlotContainer;

    private void Awake()
    {
        //itemSlotContainer = transform.Find("itemSlotContainer");
       // itemSlotTemplate = itemSlotContainer.Find("itemSlotTemplate");
    }


    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;
        RefreshInventoryItems();
    }
    private void RefreshInventoryItems()
    {
        int x = 0;
        int y = 0;
        float itemSlotCellSize = 30f;
        foreach (Items item in inventory.GetItemList() )
        {
            RectTransform itemSlotRectTransform = Instantiate(itemSlotTemplate, itemSlotContainer).GetComponent<RectTransform>();
            itemSlotRectTransform.gameObject.SetActive(true);
            itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize, y * itemSlotCellSize);
            Image image = itemSlotRectTransform.Find("image").GetComponent<Image>();
            image.sprite = item.GetSprite();
            if (x>4)
            {
                x = 0;
                y++;
            }
        }
    }

}
