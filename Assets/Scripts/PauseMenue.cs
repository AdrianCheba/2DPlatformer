using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class PauseMenue : MonoBehaviour
{
    public GameObject panel;
    public GameObject pause;

    void Start()
    {

        panel.SetActive(false);
        
    }

    public void btnPause()
    {
        panel.SetActive(true);
        pause.SetActive(false);
        Time.timeScale = 0;
    }

    public void btnResume() 
    {
        panel.SetActive(false);
        pause.SetActive(true);
        Time.timeScale = 1;
    }
    public void btnHome()
    {
        SceneManager.LoadScene(0);
    }

    public void btnExit()
    {
        Application.Quit();
    }
}
