using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Canvas mainMenu;
    public Canvas levelMenu;

    void Start()
    {
        mainMenu.enabled = true;    
        levelMenu.enabled = false;
        Time.timeScale = 1.0f;
    }

    public void btnPlay()
    {
        mainMenu.enabled = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void btnLevels()
    {
        levelMenu.enabled = true;   
        mainMenu.enabled = false;
    }

    public void btnExit()
    {
        Application.Quit();
    }

}
