using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    DishToday dish;
    public GameObject cookingBoard;
    bool boardStatus;
    public GameObject knifeParent;
    GameObject knifeparent;
    SliceCheck cut;
    
    void Start()
    {
        
    }

    void Update()
    {
        boardStatus = cookingBoard.GetComponent<CookingBoard>().isSomethingHere;
        Debug.Log(boardStatus + " board");

        if(boardStatus)
        {
            Debug.Log("Something");
            KnifeActivate();
        }
    }

    void KnifeActivate()
    {
        
    }
}
