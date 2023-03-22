using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLock : MonoBehaviour
{
    public GameObject door;
    public Sprite unlocked;
    private AudioSource openDoorEffect;


    private void Start()
    {
        openDoorEffect= GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        door.SendMessage("OpenDoor");
        GetComponent<SpriteRenderer>().sprite = unlocked;
        openDoorEffect.Play();

    }

    public void ActivateSwitch()
    {
        GetComponent<BoxCollider2D>().enabled = true;

    }
}
