using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{
    [SerializeField] float timetoDisappear;

    private void Destroy()
    {
        Destroy(this.gameObject, timetoDisappear);    
    }
}
