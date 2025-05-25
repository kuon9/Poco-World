using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLoader : MonoBehaviour
{
    public AudioManager AM;

    //Awake is highest priority in Unity's event function. Any code in this function will execute first before any other event functions.
    private void Awake()
    {
        // null means nothing.
        if(AudioManager.instance == null)
        {
            AudioManager newAM = Instantiate(AM);
            AudioManager.instance = newAM;
            DontDestroyOnLoad(newAM.gameObject);    
        }
    }
}
