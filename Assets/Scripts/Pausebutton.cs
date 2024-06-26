using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausebutton : MonoBehaviour
{
     [SerializeField] GameObject stuff;

     public void TurnOn()
     {
        stuff.SetActive(true);
     }
}
