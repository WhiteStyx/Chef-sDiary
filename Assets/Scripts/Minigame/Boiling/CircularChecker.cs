using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularChecker : MonoBehaviour
{
    public bool spun;
    public Checker waypoint1;
    public Checker waypoint2;
    public Checker waypoint3;
    public Checker waypoint4;
    public Checker waypoint5;
    void Start()
    {
        spun = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(waypoint1.passed == true && waypoint2.passed == true && waypoint3.passed == true && waypoint4.passed == true
        && waypoint5.passed == true)
        {
            spun = true;
        }
    }
}
