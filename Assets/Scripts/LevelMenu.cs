using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    public Canvas levelMenu;
    public Canvas mainMenu;

    public void btnLvl1()
    {
        levelMenu.enabled = false;
        SceneManager.LoadScene("LvL1");
    }

    public void btnLvl2()
    {
        levelMenu.enabled = false;
        SceneManager.LoadScene("LvL2");
    }

    public void btnLvl3()
    {
        levelMenu.enabled = false;
        SceneManager.LoadScene("LvL3");
    }
    public void btnLvl4()
    {
        levelMenu.enabled = false;
        SceneManager.LoadScene("LvL4");
    }

    public void btnLvl5()
    {
        levelMenu.enabled = false;
        SceneManager.LoadScene("LvL5");
    }
    public void btnLvl6()
    {
        levelMenu.enabled = false;
        SceneManager.LoadScene("LvL6");
    }

    public void btnBack()
    {
        mainMenu.enabled = true;
        levelMenu.enabled = false;
    }
}
