using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    /**
     * Switches the scene to the next one.
     */
    public void SwitchSceneTo2()
    {
        SceneManager.LoadScene("Room1");
    }
}
