using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PauseMenue : MonoBehaviour
{
    public GameObject panel;
    public GameObject pauseBtn;
    public Sprite muteBtnSprit;
    public Sprite unMuteBtnSprit;
    public Image muteBtn;
    private bool toggle = false;
    

    void Start()
    {
        panel.SetActive(false);

        if(AudioListener.pause == true)
        {
            muteBtn.sprite = muteBtnSprit;
            toggle = true;
        }

    }

    public void btnPause()
    {
        panel.SetActive(true);
        pauseBtn.SetActive(false);
        Time.timeScale = 0;
    }

    public void btnResume() 
    {
        panel.SetActive(false);
        pauseBtn.SetActive(true);
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

    public void MuteAll()
    {
        if (toggle == false)
        {
            AudioListener.pause = true;
            muteBtn.sprite = muteBtnSprit;
            toggle = true;
        }
        else
        {
            AudioListener.pause = false;
            muteBtn.sprite = unMuteBtnSprit;
            toggle = false;
        }

    }


}
