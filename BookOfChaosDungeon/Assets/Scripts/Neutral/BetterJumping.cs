using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterJumping : MonoBehaviour
{
    private float fallMultiplier = 2.5f; //Makes gravity stronger
    public float lowJumpMultiplier = 2f; //Make varity in jumps
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); //Connects the rigid body
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }

    /**
     * Make the gravity diffrent based on how long they hit the space bar
     */
    private void Jump()
    {
        if (rb.velocity.y < 0) //if player is starting to fall
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime; //Fall bigger
        }

        else if (rb.velocity.y > 0 && !Input.GetKey(KeyCode.Space)) //if player holds jump button
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime; //Less bigger fall
        }
    }
}
