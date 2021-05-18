using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingOfTheWater : MonoBehaviour
{
    private float speed = 19f; //How fast the water moves
    private MoveWaterUp moveWaterUp;

    // Start is called before the first frame update
    void Start()
    {
        moveWaterUp = GameObject.Find("Pool").GetComponent<MoveWaterUp>(); //Connects the Move water up script to this script
    }

    // Update is called once per frame
    void Update()
    {
        Fall();
    }

    /**
     * Makes the water fall if they pulled the wrong lever
     */
    private void Fall()
    {
        if (moveWaterUp.failed) //If they pulled the wrong lever
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime); //Moves the water down throught the pipe
        }
    }
}
