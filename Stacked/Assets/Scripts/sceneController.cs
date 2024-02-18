using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneController : MonoBehaviour
{
    public void loadMainMenu()
    {
        SceneManager.LoadScene(0);  //Scene index 0 is the main menu
    }

    public void loadLevelSelect()
    {
        SceneManager.LoadScene(1);  //Scene index 1 is the level select menu
    }

    public void loadTutorial() 
    {
        SceneManager.LoadScene(2);  //Scene index 2 is the tutorial
    }

    public void loadCredits()
    {
        SceneManager.LoadScene(3);  //Scene index 3 is the credits menu
    }

    //Levels
    public void loadLevel1() 
    {
        SceneManager.LoadScene(4);  
    }
    public void loadLevel2()
    {
        SceneManager.LoadScene(5);  
    }
    public void loadLevel3()
    {
        SceneManager.LoadScene(6);  
    }
    public void loadLevel4()
    {
        SceneManager.LoadScene(7);  
    }
    public void loadLevel5()
    {
        SceneManager.LoadScene(8);  
    }
    public void quitGame()
    {
        Application.Quit();
    }
}
