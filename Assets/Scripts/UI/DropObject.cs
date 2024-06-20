using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropObject : MonoBehaviour, IDropHandler
{
    [HideInInspector]public bool chicken;
    [HideInInspector]public bool shallot;
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        ItemDescriptionBox dragObject = dropped.GetComponent<ItemDescriptionBox>();
        Debug.Log("dropped");
        switch(dragObject.ingredientID)
        {
            case 1:
                chicken = true;
                Debug.Log("chicken");
                break;
            case 2:
                shallot = true;
                break;
        }
    }
}
