using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("SampleScene",LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}