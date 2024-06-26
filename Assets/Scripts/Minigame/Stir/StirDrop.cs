using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StirDrop : MonoBehaviour, IDropHandler
{
    public bool isSomethingHere; 
    bool oil, egg, paste, meatball, cutchicken, rice, salt, powder, pepper, oyster,
    kecapmanis,greenOnion;
    [SerializeField]bool step0,step1,step2,step3,step4;
    public bool finished;
    [SerializeField] GameObject step1Pic, step3Pic, step4Pic, finishedProduct;

    //1candlenut 2chili 3oil 4red 5terasi 6water 7whiteonion 8egg 9cutchicken 10paste
    //11meatball 12salt 13powder 14pepper 15oyster 16kecapmanis

    void Start()
    {
        oil = false;
        egg = false;
        cutchicken = false;
        paste = false;
        meatball = false;
        rice = false;
        salt = false;
        powder = false;
        pepper = false;
        oyster = false;
        kecapmanis = false;
        step0 = true;
        step1 = false;
        step2 = false;
        step3 = false;
        step4 = false;
        greenOnion = false;
        finished = false;
    }

    void Update()
    {
        if(step1) step1Pic.SetActive(true); 
        if(paste && cutchicken && meatball)
        {
            step3 = true;
            step3Pic.SetActive(true);
        }
        if(rice && salt && powder && oyster && kecapmanis)
        {
            step4 = true;
        }
        if(step4) step4Pic.SetActive(true);
    }

    //1candlenut 2chili 3oil 4red 5terasi 6water 7whiteonion 8egg 9cutchicken 10paste
    //11meatball 12salt 13powder 14pepper 15oyster 16kecapmanis 17rice 18greenonion

    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        SpiceItem draggedItem = dropped.GetComponent<SpiceItem>();
        int id = draggedItem.ingredientID;
        if(id == 3 && step0)
        {
            oil = true;
            step1 = true;
            step1Pic.SetActive(true);
        }
        if(id == 8 && step1)//masukin telur
        {
            egg = true;
            step2 = true; 
        }
        if(step2)//masukin bumbu, bakso, ayam
        {
            // Debug.Log("enter step 2");
            // switch(id)
            // {
            //     case 10:
            //         Debug.Log("10");
            //         paste = true;
            //         break;
                
            //     case 9:
            //         Debug.Log("9");
            //         cutchicken = true;
            //         break;

            //     case 11:
            //         Debug.Log("11");
            //         meatball = true;
            //         break;
            //     default:
            //         Debug.Log("fucked");
            //         break;
            // }
            if(id == 10) paste = true;
            if(id == 9) cutchicken = true;
            if(id == 11) meatball = true;
        }

        if(step3)//rice, salt, powder, pepper, oyster, kecapmanis
        {
            // switch(id)
            // {
            //     case 17:
            //         rice = true;
            //         break;
                
            //     case 12:
            //         salt = true;
            //         break;
                
            //     case 13:
            //         powder = true;
            //         break;

            //     case 14:
            //         pepper = true;
            //         break;
                
            //     case 15:
            //         oyster = true;
            //         break;
                
            //     case 16:
            //         kecapmanis = true;
            //         break;
            // }
            if(id == 17) rice = true;
            if(id == 12) salt = true;
            if(id == 13) powder = true;
            if(id == 14) pepper = true;
            if(id == 15) oyster = true;
            if(id == 16) kecapmanis = true;
        }

        if(step4)
        {
            if(id == 18)
            {
                finishedProduct.SetActive(true);
                gameObject.SetActive(false);
            }
        }
    }
}
