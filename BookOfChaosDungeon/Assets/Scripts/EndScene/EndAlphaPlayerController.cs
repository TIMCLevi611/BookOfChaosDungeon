using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndAlphaPlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (gameObject.CompareTag("Book"))
        {
            Destroy(GameObject.Find("BookOfChaos")); 
        }
    }
}
