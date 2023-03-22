using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPassCard : MonoBehaviour
{
    public GameObject doorSwitch;
    private AudioSource getPassCardEffect;

    private void Start()
    {
        getPassCardEffect = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            doorSwitch.SendMessage("ActivateSwitch");
            getPassCardEffect.Play();
            GetComponent<PolygonCollider2D>().enabled = false;
            Invoke("DisableCart", 0.3f);
        }
    }

    private void DisableCart()
    {
        gameObject.SetActive(false);
    }
}
