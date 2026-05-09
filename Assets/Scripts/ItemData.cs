using UnityEngine;

[CreateAssetMenu(fileName = "New Item" , menuName = "Inventory/Item")]

public class ItemData : ScriptableObject
{
    [SerializeField] private ItemType type;
    [SerializeField] private string itemName;
    [SerializeField] private float value;
    [SerializeField] private Sprite icon;
    [SerializeField] private bool collected;


    public ItemType Type() { return type; }
    public string ItemName() { return itemName; } 
    public float Value() { return value; }
    public Sprite Icon() { return icon; }
    public bool Collected() { return collected; }

         
}


