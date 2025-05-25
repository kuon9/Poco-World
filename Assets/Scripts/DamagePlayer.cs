using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    [SerializeField] GameObject destroyEffect;
    [SerializeField] float timetoDisappear = 2f;
    // public bool destroyOnContact;

    RespawnController respawnController;
    
    
    void Start()
    {
        respawnController = FindObjectOfType<RespawnController>();
    } 
        
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(respawnController.Respawning());
            //StartCoroutine(RespawnController.instance.Respawning());
        }
        if(other.gameObject.CompareTag("RockCollector"))
        {
            Debug.Log("HIT ROCKCOLLECTOR");
            Destroy(gameObject, timetoDisappear);
        }
    }
    // void OnCollisionEnter2D(Collision2D other)
    // {
    //     if(other.gameObject.tag == "Player")
    //     {
    //         StartCoroutine(RespawnController.instance.Respawning());
    //     }
    //     if(other.gameObject.tag == "Ground")
    //     {
    //         //Destroy(gameObject);
    //         Instantiate(destroyEffect, transform.position, transform.rotation);
    //     }
    
    // }
    // void OnTriggerEnter2D(Collider2D other)
    // {
    //     // if(other.tag == "Player")
    //     // {
    //     //     StartCoroutine(RespawnController.instance.Respawning());
    //     // }
    //     if(other.tag == "Ground")
    //     {
    //         Instantiate(destroyEffect, transform.position, transform.rotation);
    //         Destroy(this.gameObject);
    //         //TouchGround();
    //     }
    // }

    // void TouchGround()
    // {
    //     if(destroyOnContact)
    //     {
    //         //AudioManager.instance.PlaySFX(4);
    //         Instantiate(destroyEffect, transform.position, transform.rotation);
    //         Destroy(this.gameObject);
    //         // This destroyed the player gameobject permanently. This stopped my player from respawning
    //         //Destroy(gameObject);
    //     }        
    // }
}
