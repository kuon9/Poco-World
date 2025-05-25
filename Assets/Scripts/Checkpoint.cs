using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public bool isChecked;
    
    RespawnController respawnController;
    
    void Start()
    {
        respawnController = FindObjectOfType<RespawnController>();
    } 
        


    void OnTriggerEnter2D(Collider2D other)
    {
        // isChecked boolean prevents checkpoint from being activated more than once.
        if(other.tag == "Player" && !isChecked)
        {
            respawnController.SetSpawn(transform.position);
            //RespawnController.instance.SetSpawn(transform.position);
          //PlayerHealth.instance.FullHealth();
            isChecked = true;
        }
    }
}
