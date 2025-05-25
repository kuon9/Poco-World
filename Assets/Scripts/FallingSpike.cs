using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingSpike : MonoBehaviour
{
    [SerializeField] float timeToDisappear = 2f;
    RespawnController respawnController;
    BallMovement player;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       player = GameObject.FindGameObjectWithTag("Player").GetComponent<BallMovement>();        
       respawnController = FindObjectOfType<RespawnController>(); 
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            rb.isKinematic = false;
            Destroy(gameObject, timeToDisappear);
        }    
    }

    void OnCollisionEnter2D(Collision2D col)
    {
       if(col.gameObject.tag =="Player")
       {
            StartCoroutine(respawnController.Respawning());     
       }
    }
}