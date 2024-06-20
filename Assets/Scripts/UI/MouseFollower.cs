using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollower : MonoBehaviour
{
    [SerializeField] private Canvas canvas;
    [SerializeField] private Camera maincam;
    [SerializeField] private ItemDescriptionBox item;

    public void Awake()
    {
        canvas = transform.root.GetComponent<Canvas>();
        maincam = Camera.main;
        item = GetComponentInChildren<ItemDescriptionBox>();
    }

}
