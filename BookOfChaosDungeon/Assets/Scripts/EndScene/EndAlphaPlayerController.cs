using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndAlphaPlayerController : MonoBehaviour
{
    private RotateCircles gameOver;
    private ToScene toScene;

    // Start is called before the first frame update
    void Start()
    {
        toScene = GameObject.Find("Teleporter").GetComponent<ToScene>(); //Connects scripts
        gameOver = GameObject.Find("Enchantment").GetComponent<RotateCircles>(); //Connects scripts
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (gameOver.isGameOver) //If player touches portal to next place
        {
            if (collision.gameObject.CompareTag("Right"))
            {
                toScene.SwitchSceneToWin();
            }
        }
    }
}
