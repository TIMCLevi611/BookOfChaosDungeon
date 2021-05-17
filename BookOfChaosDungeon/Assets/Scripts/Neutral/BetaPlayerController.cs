using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetaPlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private GameObject camra;
    private float speed = 50f; //How fast the player moves
    private Vector3 camraOffset = new Vector3(0, 6, 0); //the offset of the camra to the player
    private bool isOnGround = true; //If they are touching the ground
    private float jumpVelocity; //How high they can jump
    private ToScene toScene;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>(); //Connects the player Rigidbody to playerRb
        camra = GameObject.Find("Main Camera"); //Connects the main camra to camra
        camra.transform.Translate(transform.position + camraOffset); //Sets starting position of the camra
        this.GetComponent<MeshRenderer>().enabled = false; //Makes player invisible
        toScene = GameObject.Find("Portal").GetComponent<ToScene>(); //Connects to the To scene script
        jumpVelocity = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        MoveCamra();
        RestartLevel();
    }


    /*
     * Moves the player
     */
    public void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * verticalInput * Time.deltaTime); //Moves the player on the x axis
        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime); //Moves the player on the z axis

        Jump();
    }


    /**
     * Lets the player jump if they are on the ground
     */
    public void Jump()
    {
        if (isOnGround && Input.GetKeyDown(KeyCode.Space)) //If on the ground and space is hit
        {
            isOnGround = false;
            playerRb.velocity = Vector3.up * jumpVelocity; //Pushes the player in the y axis
        }
    }


    /**
     * If body moves the camra will move
     */
    public void MoveCamra()
    {
        if (transform.position != camra.transform.position + camraOffset)
        {
            camra.transform.position = transform.position + camraOffset;
        }
    }


    public void RestartLevel()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
           toScene.RestartLevel();
        }
    }

    /**
     * If player collieds with stuff
     */
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground")) //if the player is on the ground
        {
            isOnGround = true;
        }

        else if (collision.gameObject.CompareTag("Death")) //If player dies changes scene to death scene.
        {
            toScene.SwitchSceneToDeath();
        }

        else if (collision.gameObject.CompareTag("To2")) //If player touches portal to next place
        {
            toScene.SwitchSceneTo2();
        }

        else if (collision.gameObject.CompareTag("To3")) //If player touches portal to next place
        {
            toScene.SwitchSceneTo3();
        }

        else if (collision.gameObject.CompareTag("To4")) //If player touches portal to next place
        {
            toScene.SwitchSceneTo4();
        }

        else if (collision.gameObject.CompareTag("End")) //If player touches portal to next place
        {
            toScene.SwitchSceneToEnd();
        }
    }

}
