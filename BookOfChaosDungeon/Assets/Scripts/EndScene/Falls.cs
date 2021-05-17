using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falls : MonoBehaviour
{
    private float speed = 60f; //How fast the water fall moves

    // Start is called before the first frame update
    void Start()
    { 

    }

    // Update is called once per frame
    void Update()
    {
        Fall();
    }

    /**
     * Makes the water fall move downwords
     */
    private void Fall()
    {
        this.transform.Translate(Vector3.down * speed * Time.deltaTime); //Moves the water on the y axis
    }
}
