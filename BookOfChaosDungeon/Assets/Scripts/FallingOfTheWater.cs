using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingOfTheWater : MonoBehaviour
{
    private float speed = 19f;
    private MoveWaterUp moveWaterUp;
    // Start is called before the first frame update
    void Start()
    {
        moveWaterUp = GameObject.Find("Pool").GetComponent<MoveWaterUp>();
    }

    // Update is called once per frame
    void Update()
    {
        Fall();
    }

    private void Fall()
    {
        if (moveWaterUp.failed)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime); //Moves the water on the y axis
        }
    }
}
