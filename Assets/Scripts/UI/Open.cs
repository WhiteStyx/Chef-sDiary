using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{
    public GameObject objectToOpen;
    public GameObject objectToClose;
    public GameObject button;
    GameObject stirGame;

    public void OpenRecipe()
    {
        objectToOpen.SetActive(true);
        objectToClose.SetActive(false);
    }

    public void OpenSeasoning()
    {
        OpenRecipe();
        button.SetActive(true);
    }

    public void OpenStir()
    {
        OpenRecipe();
        stirGame.SetActive(true);
    }
}
