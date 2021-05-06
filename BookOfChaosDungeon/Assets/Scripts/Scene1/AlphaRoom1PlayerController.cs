using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaRoom1PlayerController : MonoBehaviour
{
    private LockedDoor lDoor;
    private ToScene toScene;

    // Start is called before the first frame update
    void Start()
    {
        lDoor = GameObject.Find("LockDoor").GetComponent<LockedDoor>(); //Connects PlayerController to door script
        toScene = GameObject.Find("Portal").GetComponent<ToScene>(); //Connects to the To scene script
    }

    // Update is called once per frame
    void Update()
    {

    }

    /**
     * If Player hits stuff
     */
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Death")) //If player dies reseats to the begining.
        {
            toScene.SwitchSceneTo1();
        }
    }
}
