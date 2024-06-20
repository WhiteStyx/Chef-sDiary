using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CookingBoard : MonoBehaviour, IDropHandler
{
    public bool isSomethingHere;
    public GameObject knife;
    public GameObject knifeOff;
    void Start()
    {
        isSomethingHere = false;
    }

    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        isSomethingHere = true;
        knife.SetActive(true);
        knifeOff.SetActive(false);
        Debug.Log(isSomethingHere);
    }
}
