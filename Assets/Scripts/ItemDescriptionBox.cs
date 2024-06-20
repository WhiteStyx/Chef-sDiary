using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemDescriptionBox : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public GameObject descbox;
    public IngredientSO ingredient;
    public TMP_Text ingredientName;
    public TMP_Text ingredientDescription;
    public SpriteRenderer ingredientImage;
    public UnityEngine.UI.Image image;
    public int ingredientID;
    public GameObject cookingBoard;

    void Start()
    {
        descbox.SetActive(false);
        ingredientID = ingredient.id;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // descbox.SetActive(true);
        ingredientName.text = ingredient.name;
        ingredientDescription.text = ingredient.description;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        descbox.SetActive(false);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
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
        
        image.raycastTarget = true;
        cookingBoard.SetActive(false);
    }
}
