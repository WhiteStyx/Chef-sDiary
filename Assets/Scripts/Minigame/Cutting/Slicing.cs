using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slicing : MonoBehaviour, IPointerEnterHandler
{
    public bool cut;
    public bool isMouseHeld;

    

    void Start()
    {
        cut = false;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown (0))
        {
            isMouseHeld = true;
        }

        if(Input.GetMouseButtonUp (0))
        {
            isMouseHeld = false;
        }

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(isMouseHeld)
        {
            Debug.Log("Cut");
            cut = true;
        }
    }

}
