using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RotateCircles : MonoBehaviour
{
    private MeshRenderer visible;
    public TextMeshProUGUI dialoge;
    private Vector3 rotation = new Vector3(0, 0.1f, 0);

    public bool isGameOver { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        visible = this.GetComponent<MeshRenderer>(); //Connects the meshrender to this script
        visible.enabled = false; //Makes the circles invisible
        isGameOver = false; 
    }

    // Update is called once per frame
    void Update()
    {
        StartRotation();
    }

    /**
     * Rotates the circles
     */
    public void StartRotation()
    {
        if (isGameOver) //If the book has been collected
        {
            if(!visible.enabled) //If the circles are invisible            
            {
                visible.enabled = true; //Makes circles visible
                dialoge.gameObject.SetActive(true);//Makes dialogue visable
            }

            if(gameObject.CompareTag("Left")) //Makes one circle rotate left
            {
                transform.Rotate(-rotation); //Rotates circles
            }

            else if (gameObject.CompareTag("Right")) //Makes the other one rotate right
            {
                transform.Rotate(rotation); //Rotates circles
            }
        }
    }

}
