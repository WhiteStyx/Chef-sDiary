using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public GameObject objectToClose;
    public GameObject objectToOpen;
    public GameObject dialOn;
    public GameObject dialOff;
    public GameObject game, finishedProduct, paste;
    [SerializeField] GameObject panGame;
    bool finished,blendable;

    void Start()
    {
        finished = false;
    }

    void Update()
    {
        StirDrop stirDrop = panGame.GetComponent<StirDrop>();
        finished = stirDrop.finished;
    }

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

    public void closeRecipe()
    {
        objectToClose.SetActive(false);
        objectToOpen.SetActive(true);
    }

    public void closeSeasoning()
    {
        objectToClose.SetActive(false);
        objectToOpen.SetActive(true);
        gameObject.SetActive(false);
    }

    public void closeStir()
    {
        if(finished)
        {
            objectToClose.SetActive(false);
            objectToOpen.SetActive(true);
            finishedProduct.SetActive(true);
        }
    }
}
