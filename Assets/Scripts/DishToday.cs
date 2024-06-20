using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DishToday : MonoBehaviour
{
    public bool pecelPitik;
    private bool dishSelected;
    public bool kaledo;
    public bool ayamWoku;

    void Awake()
    {
        pecelPitik = false;
        kaledo = false;
        ayamWoku = false;
    }
    
    public void PecelPitik()
    {
        pecelPitik = true;
        dishSelected = true;
    }

    public void Kaledo()
    {
        kaledo = true;
        dishSelected = true;
    }

    public void AyamWoku()
    {
        ayamWoku = true;
        dishSelected = true;
    }

    void Update()
    {
        if(dishSelected)
        {
            gameObject.SetActive(false);
        }
    }
}
