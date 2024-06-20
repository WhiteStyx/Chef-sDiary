using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FridgeButton : MonoBehaviour
{
    [SerializeField]private GameObject fridge;
    [SerializeField]private GameObject exit;
    public void OpenFridge()
    {
        fridge.SetActive(true);
        gameObject.SetActive(false);
        exit.SetActive(true);
    }
}
