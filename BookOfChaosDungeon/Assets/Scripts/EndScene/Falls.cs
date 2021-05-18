using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falls : MonoBehaviour
{
    private float speed = 60f; //How fast the water fall moves
    private SoundManager sound;

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<SoundManager>(); //Connects the sound manager to this script
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
        sound.PlayWaterFalling(); //Plays the falling water sound
    }
}
