using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public GameObject endLevel;
    public GameObject endGeme;
    public Canvas pauseMenu;

    private void Start()
    {
        endLevel.SetActive(false);
        endGeme.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (SceneManager.GetActiveScene().buildIndex < (SceneManager.sceneCountInBuildSettings - 1))
        {
            endLevel.SetActive(true);
            pauseMenu.enabled = false;
            Time.timeScale = 0f;

        }
        else
        {
            endGeme.SetActive(true);
            pauseMenu.enabled = false;
            Time.timeScale = 0f;
        }
    }
}
