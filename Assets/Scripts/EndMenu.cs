using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
   
    public void btnNextLvL()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1.0f;
    }

    public void btnHome()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;

    }

    public void btnExit()
    {
        Application.Quit();
    }
}
