using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public Canvas endMenu;

    private void Start()
    {
        endMenu.enabled = false; 
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (SceneManager.GetActiveScene().buildIndex < (SceneManager.sceneCountInBuildSettings - 1))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            endMenu.enabled = true;
            Time.timeScale = 0f;
        }
    }
}
