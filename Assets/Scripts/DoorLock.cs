using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLock : MonoBehaviour
{
    public GameObject door;
    public Sprite unlocked;

    private void OnTriggerEnter2D(Collider2D other)
    {
        door.SendMessage("OpenDoor");
        GetComponent<SpriteRenderer>().sprite = unlocked;
    }

    public void ActivateSwitch()
    {
        GetComponent<BoxCollider2D>().enabled = true;
    }
}
