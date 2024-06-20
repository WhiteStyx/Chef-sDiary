using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitFridge : MonoBehaviour
{
    [SerializeField]private GameObject fridge;
    [SerializeField]private GameObject open;

    public void CloseFridge()
    {
        fridge.SetActive(false);
        open.SetActive(true);
        gameObject.SetActive(false);
    }
}
