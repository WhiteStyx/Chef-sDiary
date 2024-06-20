using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField] private ItemDescriptionBox itemPrefab;
    [SerializeField] private RectTransform contentPanel;

    List<ItemDescriptionBox> listOfUIItems = new List<ItemDescriptionBox>();

    public void InitializeInventoryUI(int inventorysize)
    {
        for(int i = 0; i < inventorysize; i++)
        {
            ItemDescriptionBox uiItem = Instantiate(itemPrefab, Vector3.zero, Quaternion.identity);
            uiItem.transform.SetParent(contentPanel);
            listOfUIItems.Add(uiItem);
        }
    }
}
