using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    private Vector3 startPos;
    private int speed = 10; //How fast door goes down
    private double limit;  //How far the door can go down
    
    public bool isLocked { get; set; } //Is the door locked
    // Start is called before the first frame update
    void Start()
    {
        limit = transform.position.y - 58.76929; 
        startPos = transform.position; //Where the door starts
        isLocked = true; //Locks the door
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
        if (!isLocked) //If locked is false and hasn't hit limit
        {
            if (transform.position.y > limit) //If door higher then the limit
            {
                transform.Translate(Vector3.down * speed * Time.deltaTime); //Moves the door
            } 
        } 
        
        else //If door is locked
        {
            if (transform.position.y < startPos.y) //If door is lower then the starting position
            {
                transform.Translate(Vector3.down * -speed * Time.deltaTime); //Moves the door
            }
        }
    }
}
