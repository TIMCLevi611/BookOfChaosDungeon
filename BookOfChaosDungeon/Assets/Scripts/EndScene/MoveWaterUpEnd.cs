using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWaterUpEnd : MonoBehaviour
{
    private GameObject Falling1;
    private Vector3 Falling1Location; //Where Falling 1 starts in the scene
    private GameObject Falling2;
    private Vector3 Falling2Location; //Where Falling 2 starts in the scene

    // Start is called before the first frame update
    void Start()
    {
        Falling1 = GameObject.Find("FallingWater"); //Connects Falling1 to Falling water.
        Falling1Location = Falling1.transform.position; //Records the starting position of the water.
        Falling2 = GameObject.Find("Trigger"); //Connects Falling2 to Falling water 2.
        Falling2Location = Falling2.transform.position; //Records the starting position of the water.
    }

    // Update is called once per frame
    void Update()
    {

    }

    /**
     * Moves the water to before it fell
     */
    private void MoveTheWaterUp()
    {
        Falling1.transform.position = Falling1Location ; //Moves falling water to the begining
        Falling2.transform.position = Falling2Location ; //Moves falling water to the begining
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("FallingWater")) //If the water hits the trigger
        {
            MoveTheWaterUp();
        }
    }
}
