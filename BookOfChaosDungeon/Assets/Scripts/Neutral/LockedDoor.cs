using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    private Vector3 startPos;
    private int speed = 10; //How fast door goes down
    private double limit;  //How far the door can go down
    
    public bool isLocked { get; set; } //Is the door locked
    public bool locked;
    // Start is called before the first frame update
    void Start()
    {
        limit = transform.position.y - 58.76929;
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveDown();
        locked = isLocked;
    }

    /**
     * Moves door down
     */
    public void MoveDown()
    {
        if (transform.position.y > limit && !isLocked) //If locked is false and hasn't hit limit
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime); //Moves the door
        }

        else
        {
            transform.position = startPos;
        }
    }
}
