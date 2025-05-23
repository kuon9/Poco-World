using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayer : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            StartCoroutine(RespawnController.instance.Respawning());
            //play audio here later on
        }
    }

    //Comparetag is more efficient and less power usage than .tag ==.

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(RespawnController.instance.Respawning());
        }
    }
}
