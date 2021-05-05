using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levers : MonoBehaviour
{
    private MoveWaterUp moveWaterUp;
    private bool isRedUp;
    private bool isBlueUp;
    private bool isGreenUp;
    private bool isInteracted;
    // Start is called before the first frame update
    void Start()
    {
        moveWaterUp = GameObject.Find("Pool").GetComponent<MoveWaterUp>();
        isRedUp = true;
        isBlueUp = true;
        isGreenUp = true;
        isInteracted = false;
    }

    // Update is called once per frame
    void Update()
    {
        ActivateWater();
    }

    private void ActivateWater()
    {
        if (isInteracted)
        {
            moveWaterUp.failed = true;
        }
    }




}
