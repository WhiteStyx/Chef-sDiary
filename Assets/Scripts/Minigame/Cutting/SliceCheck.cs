using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliceCheck : MonoBehaviour
{
    public bool sliced;
    public Slicing waypoint1;
    public Slicing waypoint2;
    public GameObject result;
    void Start()
    {
        sliced = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(waypoint1.cut == true && waypoint2.cut == true)
        {
            sliced = true;
            result.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
