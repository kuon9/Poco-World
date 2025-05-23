using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockCollector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Hazard")
        {
            Destroy(gameObject);
        }
    }
}
