using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHealth : MonoBehaviour
{
    public static BallHealth instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);    
        }
    }
}
