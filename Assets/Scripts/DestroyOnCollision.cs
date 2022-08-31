using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    public Item item;

    private GameObject player;
    private bool isOpen;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0];
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("test");
        Inventory.instance.Add(item);
         if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
     }
}
