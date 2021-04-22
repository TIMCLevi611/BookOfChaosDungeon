using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    private GameObject camra;
    private float speed = 1f;
    private Vector3 camraOffset = new Vector3(0, 6, 0);
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        camra = GameObject.Find("Main Camera");
        camra.transform.Translate(transform.position.x, transform.position.y + 6, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        MoveCamra();
        
    }

    public void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * verticalInput);
        transform.Translate(Vector3.right * speed * horizontalInput);
    }

    public void MoveCamra()
    {
        if (transform.position.x != camra.transform.position.x || transform.position.z != camra.transform.position.z)
        {
            //camra.transform.Translate(transform.position.x, camra.transform.position.y, transform.position.z);
            camra.transform.position = transform.position + camraOffset;
        }
    }
}
