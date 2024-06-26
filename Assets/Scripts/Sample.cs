using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SampleScript : MonoBehaviour
{
    [SerializeField]GameObject stuff;
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu",LoadSceneMode.Single);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Continue()
    {
        stuff.SetActive(false);
    }
}
