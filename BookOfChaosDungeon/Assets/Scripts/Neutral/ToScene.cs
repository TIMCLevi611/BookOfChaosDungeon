using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToScene : MonoBehaviour
{
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
     * Switches the scene to the outside scene.
     */
    public void SwitchSceneTo1()
    {
        SceneManager.LoadScene("OutsideScene");
    }

    /**
     * Switches the scene to the Levers scene.
     */
    public void SwitchSceneTo2()
    {
        SceneManager.LoadScene("Room1");
    }

    /**
     * Switches the scene to the chair scene.
     */
    public void SwitchSceneTo3()
    {
        SceneManager.LoadScene("Room2");
    }

    /**
     * Switches the scene to the parkor scene.
     */
    public void SwitchSceneTo4()
    {
        SceneManager.LoadScene("Room3");
    }

    /**
     * Switches the scene to the Book of Chaos scene.
     */
    public void SwitchSceneToEnd()
    {
        SceneManager.LoadScene("End");
    }
}
