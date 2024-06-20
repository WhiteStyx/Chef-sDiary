using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoTurnOnOff : MonoBehaviour
{
    public GameObject objectToClose;
    public GameObject objectToOpen;

    public void close()
    {
        objectToClose.SetActive(true);
        objectToOpen.SetActive(false);
    }

    public void open()
    {
        gameObject.SetActive(true);
        objectToOpen.SetActive(false);
    }
}
