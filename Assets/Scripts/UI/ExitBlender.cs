using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitBlender : MonoBehaviour
{
    public GameObject objectToClose;
    public GameObject objectToOpen;
    [SerializeField]GameObject paste;
    [SerializeField] GameObject panGame, announcement;
    bool blendable;

    // Start is called before the first frame update
    void Start()
    {
        blendable = false;
    }

    // Update is called once per frame
    void Update()
    {
        Blender blender = panGame.GetComponent<Blender>();
        blendable = blender.blendable;
        Debug.Log(blendable);
    }

    public void closeBlend()
    {
        if(blendable)
        {
            objectToClose.SetActive(false);
            objectToOpen.SetActive(true);
            announcement.SetActive(true);
        }
    }
}
