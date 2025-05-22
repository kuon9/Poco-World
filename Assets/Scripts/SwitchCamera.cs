using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class SwitchCamera : MonoBehaviour
{
    
    public CinemachineVirtualCamera newCamera;
    public CinemachineVirtualCamera oldCamera;
    // private CinemachineVirtualCamera vcam;
    // private GameObject player;
    // private Transform followTarget;
    private bool isActivated;

    
    // void Start()
    // {
    //     // Reference to the CinemachineVirtualCamera which is a component attached to
    //     //this gameobject
    //     vcam = GetComponent<CinemachineVirtualCamera>();    
    // }
    
    // void Update()
    // {
    //     if(!isActivated) {return;}
    //     // Looks for player gameObject if it in hierarchy
    //     if(player == null)
    //     {
    //         player = GameObject.FindWithTag("Player");
    //         // After finding gameobject with "Player" tag, vcam will follow this new gameObject.
    //         if(player != null)
    //         {
    //             followTarget = player.transform;
    //             vcam.Follow = followTarget;
    //         }
    //     }    
    // }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Switched to this camera");
            newCamera.Priority = 15;
            oldCamera.Priority = 1;
            //isActivated = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Back to Main Camera");
            newCamera.Priority = 0;
            oldCamera.Priority = 11;
            //isActivated = false;
        }
    }
}
