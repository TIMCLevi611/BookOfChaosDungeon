using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public bool isMovingDown; //Is the door moving down after being touched
    private int speed = 10; //How fast door goes down
    private double limit;  //How far the door can go down
    private SoundManager sound;

    // Start is called before the first frame update
    void Start()
    {
        isMovingDown = false;
        limit = transform.position.y - 58.76929;
        sound = GetComponent<SoundManager>(); //Connects the sound manager to this script
    }

    // Update is called once per frame
    void Update()
    {
        MoveDown();
    }

    /**
     * Moves door down
     */
    public void MoveDown()
    {
        if (isMovingDown && transform.position.y > limit) //If Move down is true and hasn't hit limit
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime); //Moves the door down
            sound.DoorMovingDown(); //Makes the door moving sound.
        }

        else //If it hit the limit
        {
            isMovingDown = false; //Stops the door from moving.
        }
    }
}
