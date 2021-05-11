using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaPlayerController : MonoBehaviour
{
    private Door door;

    // Start is called before the first frame update
    void Start()
    {
        door = GameObject.Find("Door").GetComponent<Door>(); //Connects PlayerController to door script
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Door")) //if the player is touching the inside door
        {
            door.isMovingDown = true;
        }
    }

}
