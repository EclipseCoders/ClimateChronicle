using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatNPC : MonoBehaviour
{

    private GameObject player;
    private bool isOpen;
    public GameObject DialogueBox;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0];
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && (player.transform.position-this.transform.position).sqrMagnitude<3*3 && isOpen == false)
        {
            DialogueBox.SetActive(true);
            isOpen = true;
        }
        if (!DialogueBox.activeSelf)
        {
            DialogueBox.SetActive(false);
            isOpen = false;
        }
    }
}
