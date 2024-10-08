using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;

public class SpiceItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public IngredientSO ingredient;
    public TMP_Text ingredientName;
    public Image image;
    public int ingredientID;
    public GameObject cookingBoard;
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

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin Drag");
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
        mouseFollower.Toggle(true);
        mouseFollower.SetData(image.sprite);
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        mouseFollower.Toggle(false);
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
        cookingBoard.SetActive(false);
    }

    public void SetData(Sprite sprite)
    {
        image.sprite = sprite;
    }
}
