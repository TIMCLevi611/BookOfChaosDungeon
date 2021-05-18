using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    private Vector3 startPos;
    private int speed = 10; //How fast door goes down
    private double limit;  //How far the door can go down
    public SoundManager sound;

    public bool isLocked { get; set; } //Is the door locked
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position; //Where the door starts
        limit = startPos.y - 58.76929; 
        isLocked = true; //Locks the door
        sound = GetComponent<SoundManager>(); //Connects the sound manager to this script
    }

    // Update is called once per frame
    void Update()
    {
        MoveDown();
    }

    /**
     * Moves door down or up
     */
    public void MoveDown()
    {
        if (!isLocked) //If isn't locked 
        {
            if (transform.position.y > limit) //If door higher then the limit
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime); //Moves the door down
                sound.DoorMovingDown(); //Makes the door moving sound.
            } 
        } 
        
        else //If door is locked
        {
            if (transform.position.y < startPos.y) //If door is lower then the starting position
            {
                transform.Translate(Vector3.down * -speed * Time.deltaTime); //Moves the door up
                sound.DoorMovingDown(); //Makes the door moving sound.
            }
        }
    }
}
