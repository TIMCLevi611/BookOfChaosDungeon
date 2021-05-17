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
     * Restarts Level
     */
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    /**
     * Switches the scene to the win scene
     */
    public void SwitchSceneToWin()
    {
        SceneManager.LoadScene("Win");
    }

    /**
     * Switches the scene to the death scene
     */
    public void SwitchSceneToDeath()
    {
        SceneManager.LoadScene("Death");
    }
     /**
      * Switches the scene to the title scene
      */
    public void SwitchSceneToTitle()
    {
        SceneManager.LoadScene("Title");
    }

    /**
     * Switches the scene to the next one.
     */
    public void SwitchSceneTo1()
    {
        SceneManager.LoadScene("OutsideScene");
    }

    /**
     * Switches the scene to the next one.
     */
    public void SwitchSceneTo2()
    {
        SceneManager.LoadScene("Room1");
    }

    /**
     * Switches the scene to the next one.
     */
    public void SwitchSceneTo3()
    {
        SceneManager.LoadScene("Room2");
    }

    /**
     * Switches the scene to the next one.
     */
    public void SwitchSceneTo4()
    {
        SceneManager.LoadScene("Room3");
    }

    /**
     * Switches the scene to the next one.
     */
    public void SwitchSceneToEnd()
    {
        SceneManager.LoadScene("End");
    }
}
