using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWaterUp : MonoBehaviour
{
    private GameObject Falling1;
    private Vector3 Falling1Location; //Where Falling 1 starts in the scene
    private GameObject Falling2;
    private Vector3 Falling2Location; //Where Falling 2 starts in the scene
    private GameObject Falling3;
    private Vector3 Falling3Location; //Where Falling 3 starts in the scene
    public bool failed; //Did the play pull a wrong lever
    private float speed = 3f;
    private Vector3 offset = new Vector3(0, -60, 0); //Makes the water loop

    // Start is called before the first frame update
    void Start()
    {
        Falling1 = GameObject.Find("FallingWater"); //Connects Falling1 to Falling water.
        Falling1Location = Falling1.transform.position; //Records the starting position of the water.
        Falling2 = GameObject.Find("FallingWater2"); //Connects Falling2 to Falling water 2.
        Falling2Location = Falling2.transform.position; //Records the starting position of the water.
        Falling3 = GameObject.Find("FallingWaterChecker"); //Connects Falling3 to Falling water checker.
        Falling3Location = Falling3.transform.position; //Records the starting position of the water.
        failed = false; //Sets failed to false automaticly
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    /**
     * Moves the water up then moves falling water back to begining
     */
    private void MoveTheWaterUp()
    {
        if (failed)
        {
            transform.Translate(Vector3.up * speed *  Time.deltaTime); //Moves the water on the y axis
        }

        Falling1.transform.position = Falling1Location + offset; //Moves falling water to the begining
        Falling2.transform.position = Falling2Location + offset; //Moves falling water to the begining
        Falling3.transform.position = Falling3Location + offset; //Moves falling water to the begining
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("FallingWater"))
        {
            MoveTheWaterUp();
        }
    }
}
