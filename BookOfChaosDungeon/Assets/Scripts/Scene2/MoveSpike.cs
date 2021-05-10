using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpike : MonoBehaviour
{
    private float limit = -23.6f; //How low the spike can go
    private float speed = 5; //How fast it moves

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
        if (transform.position.y > limit)
        {
            MoveDown();
        }

        else
        {
            MoveRight();
        }
    }

    /**
     * Moves the spike Down
     */
    public void MoveDown()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime); //Moves the spike on the y axis
    }

    /**
     * Moves the spike to the Right
     */
    public void MoveRight()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime); //Moves the spike on the x axis
    }
}
