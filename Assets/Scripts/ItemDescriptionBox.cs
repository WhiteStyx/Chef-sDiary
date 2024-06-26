using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class ItemDescriptionBox : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public GameObject descbox;
    public IngredientSO ingredient;
    public TMP_Text ingredientName;
    public TMP_Text ingredientDescription;
    public Image image;
    public int ingredientID;
    public GameObject cookingBoard;
    Transform parentAfterDrag;
    public bool cut;

    void Start()
    {
        descbox.SetActive(false);
        ingredientID = ingredient.id;
        image.sprite = ingredient.image;
        cut = ingredient.cut;
    }

    void Update()
    {
        if(cut)
        {
            image.sprite = ingredient.imageCut;
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
        cookingBoard.SetActive(true);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging");
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End Drag");
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
        cookingBoard.SetActive(false);
    }
}
