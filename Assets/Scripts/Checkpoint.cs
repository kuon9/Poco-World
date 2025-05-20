using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    bool isChecked;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        // isChecked boolean prevents checkpoint from being activated more than once.
        if(other.tag == "Player" && !isChecked)
        {
            RespawnController.instance.SetSpawn(transform.position);
          //PlayerHealth.instance.FullHealth();
            isChecked = true;
        }
    }
}
