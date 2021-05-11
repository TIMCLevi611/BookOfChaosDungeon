using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpikeRoom3 : MonoBehaviour
{
    private float yLimit = -22.7f; //How low the spike can go
    private float zLimit = 10; //How far the spike will go
    private float downSpeed = 5f; //How fast it moves
    private float fowardSpeed = 10f; //How fast it goes

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    /**
     * Desides how the spike moves
     */
    public void Move()
    {
        if (transform.position.y > yLimit) //If havent hit y limit moves spike down
        {
            MoveDown();
        }

        else if (transform.position.z > zLimit) //If haven't hit z limit moves spike fowards
        {
            MoveLeft();
        }
    }

    /**
     * Moves the spike Down
     */
    public void MoveDown()
    {
        transform.Translate(Vector3.down * downSpeed * Time.deltaTime); //Moves the spike on the y axis
    }

    /**
     * Moves the spike to the Left
     */
    public void MoveLeft()
    {
        transform.Translate(Vector3.left * fowardSpeed * Time.deltaTime); //Moves the spike on the x axis
    }
}
