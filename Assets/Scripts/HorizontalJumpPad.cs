using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalJumpPad : MonoBehaviour
{
    [SerializeField] float launchPower = 5f;
     public bool launchToRight = true; 
    

    void OnTriggerEnter2D(Collider2D other)
    {
        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        if(rb != null && other.CompareTag("Player"))
        {
            Debug.Log("LAUNCHING HORIZONTAL");
            Vector2 newVelocity = rb.velocity;
            newVelocity.x = launchToRight ? launchPower: -launchPower;
            rb.velocity = newVelocity;
        }    
    }
}
