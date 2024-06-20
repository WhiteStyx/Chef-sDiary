using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public GameObject objectToClose;
    public GameObject objectToOpen;
    public GameObject dialOn;
    public GameObject dialOff;
    public GameObject game;

    public void closeButton()
    {
        objectToClose.SetActive(false);
        gameObject.SetActive(false);
    }

    public void openButton()
    {
        gameObject.SetActive(true);
    }

    public void dialButton()
    {
        objectToClose.SetActive(false);
        objectToOpen.SetActive(true);
        dialOn.SetActive(true);
        dialOff.SetActive(false);
    }

    public void dial2button()
    {
        objectToClose.SetActive(true);
        objectToOpen.SetActive(false);
        dialOn.SetActive(false);
        dialOff.SetActive(true);
    }

    public void hot()
    {
        game.SetActive(true);
    }
}
