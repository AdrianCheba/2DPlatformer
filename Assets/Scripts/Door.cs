using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Sprite openDoor;

    public void OpenDoor()
    {
        GetComponent<SpriteRenderer>().sprite = openDoor;
        GetComponent<BoxCollider2D>().enabled = true;
    }
}
