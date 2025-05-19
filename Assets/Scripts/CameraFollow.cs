using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraFollow : MonoBehaviour
{
    private CinemachineVirtualCamera vcam;
    private GameObject player;
    private Transform followTarget;
    
    
    // Start is called before the first frame update
    void Start()
    {
        // Reference to the CinemachineVirtualCamera which is a component attached to
        //this gameobject
        vcam = GetComponent<CinemachineVirtualCamera>();    
    }

    // Update is called once per frame
    void Update()
    {
        // Looks for player gameObject if it in hierarchy
        if(player == null)
        {
            player = GameObject.FindWithTag("Player");
            // After finding gameobject with "Player" tag, vcam will follow this new gameObject.
            if(player != null)
            {
                followTarget = player.transform;
                vcam.Follow = followTarget;
            }
        }    
    }
}
