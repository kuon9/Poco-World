using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class SwitchCamera : MonoBehaviour
{
    
    public CinemachineVirtualCamera newCamera;
    public CinemachineVirtualCamera oldCamera;
  

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
