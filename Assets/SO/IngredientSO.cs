using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Ingredient")]
public class IngredientSO : ScriptableObject
{
    public string ingredientName;
    public string description;
    public Sprite image;
    public int id;
}