using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;
    public List<Item> items = new List<Item>();

    void Awake()
    {
        if (instance != null)
        {
            return;
        }
        instance = this;
    }

    public void Add(Item item)
    {
        items.Add(item);
        Debug.Log("Added to Inventory: " + item.name);
    }

    // Update is called once per frame
    public void Remove(Item item)
    {
        items.Remove(item);
    }
}
