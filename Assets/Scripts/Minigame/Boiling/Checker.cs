using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Checker : MonoBehaviour, IPointerEnterHandler
{
    public bool isMouseHeld;
    public bool passed;
    

    void Start()
    {
        passed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            isMouseHeld = true;
        }
        if(Input.GetMouseButtonUp(0))
        {
            isMouseHeld = false;
        }
    }
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        if(isMouseHeld)
        {
            Debug.Log("passed");
            passed = true;
        }
    }
}
