using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public Sprite image;

    [TextArea(1,9)]
    public string description;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

//Messages that are sent
    public void AddItemToInventory()
    {
        var inventory = FindObjectOfType<Inventory>();
        Debug.Log("Adding item");
        inventory.items.Add(this);
        inventory.DisplayItems();
    }

    public void UseItem()
    {
        var inventory = FindObjectOfType<Inventory>();
        Debug.Log("Using item");
        inventory.items.Remove(this);
        inventory.DisplayItems();
    }
}
