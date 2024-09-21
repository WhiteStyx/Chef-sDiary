using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class MouseItem : MonoBehaviour
{
    public IngredientSO ingredient;
    public TMP_Text ingredientName;
    public Image image;
    public int ingredientID;
    Transform parentAfterDrag;
    [SerializeField] private MouseFollower mouseFollower;
    public bool cut;

    void Start()
    {
        ingredientID = ingredient.id;
        image.sprite = ingredient.image;
        ingredientName.text = ingredient.name;
    }

    void Update()
    {
        if(cut)
        {
            image.sprite = ingredient.imageCut;
        }
    }

    public void SetData(Sprite sprite)
    {
        image.sprite = sprite;
    }
}
