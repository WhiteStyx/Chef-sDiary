using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Blender : MonoBehaviour, IDropHandler
{
    bool redOnion, whiteOnion, candlenut, terasi, chili, oil, water;
    public bool blendable;
    void Start()
    {
        redOnion = false;
        whiteOnion = false;
        candlenut = false;  
        terasi = false;
        chili = false;
        oil = false;
        water = false;
        blendable = false;
    }

    void Update()
    {
        if(redOnion && terasi && water && candlenut && chili 
            && whiteOnion && oil) blendable = true;
    }

    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        SpiceItem draggedItem = dropped.GetComponent<SpiceItem>();
        int id = draggedItem.ingredientID;
        if(id == 4) redOnion = true;
        if(id == 5) terasi = true;
        if(id == 6) water = true;
        if(id == 1) candlenut = true;
        if(id == 2) chili = true;
        if(id == 7) whiteOnion = true;
        if(id == 3) oil = true;
    }
}
