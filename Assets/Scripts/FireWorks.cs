using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWorks : MonoBehaviour
{
    [SerializeField] GameObject [] fireworks;
    [SerializeField] GameObject UI;
     
    

    void OnTriggerEnter2D(Collider2D other)
    {
        for(int i = 0; i < fireworks.Length; i++)
        {
            if(other.gameObject.tag =="Player")
            {
                fireworks[i].SetActive(true);
            }
        }
        UI.SetActive(true);
    }
}
