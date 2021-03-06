using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    private RotateCircles gameOver;
    private RotateCircles gameOver2;
    private Vector3 outOfScene = new Vector3(100, 100, 100); //Vector 3 that is outside of the scene.

    // Start is called before the first frame update
    void Start()
    {
        gameOver = GameObject.Find("Enchantment").GetComponent<RotateCircles>(); //Conects scripts
        gameOver2 = GameObject.Find("Enchantment2").GetComponent<RotateCircles>(); //Conects scripts
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        transform.Translate(outOfScene); //Moves the book out of the scene
        gameOver.isGameOver = true; //Makes the circles move
        gameOver2.isGameOver = true; //Makes the circles move
    }

}
