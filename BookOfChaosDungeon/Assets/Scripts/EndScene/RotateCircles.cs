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

    public bool isGameOver { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        visible = this.GetComponent<MeshRenderer>(); //Connects
        visible.enabled = false; //Makes the circles invisible
        isGameOver = false; //Sets the game over to false
    }

    // Update is called once per frame
    void Update()
    {
        StartRotation();
    }

    public void StartRotation()
    {
        if (isGameOver)
        {
            if(!visible.enabled)
            {
                visible.enabled = true; //Makes Circles visible
                dialoge.gameObject.SetActive(true);//Makes dialogue visable
            }

            if(gameObject.CompareTag("Left"))
            {
                transform.Rotate(new Vector3(0, -0.1f, 0)); //Rotates circles
            }

            else if (gameObject.CompareTag("Right"))
            {
                transform.Rotate(new Vector3(0, 0.1f, 0)); //Rotates circles
            }
        }
    }

}
