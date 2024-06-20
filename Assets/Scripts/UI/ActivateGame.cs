using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGame : MonoBehaviour
{
    public GameObject cutMinigame;

    public void cut()
    {
        cutMinigame.SetActive(true);
    }
}
