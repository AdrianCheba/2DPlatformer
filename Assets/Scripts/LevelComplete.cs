using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public string newLevelName;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Application.LoadLevel(newLevelName);
    }
}
