using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutsideDoor : MonoBehaviour
{
    public bool isMovingDown;
    private int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        isMovingDown = false;
    }

    // Update is called once per frame
    void Update()
    {
        MoveDown();
    }

    public void MoveDown()
    {
        if (isMovingDown && transform.position.y > 21.23071)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

    /**
     * If Door Collides with Player
     */
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) //if the player is touching the door
        {
            isMovingDown = true;
        }
    }
}
