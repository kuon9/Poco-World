using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] Transform posA,posB;
    [SerializeField] float speed;
    Vector3 nextPos;
    public bool isActive;
    
    // Start is called before the first frame update
    void Start()
    {
        nextPos = posB.position;    
    }

    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        if(!isActive) {return;}
        if(transform.position == posA.position)
        {
            nextPos = posB.position;
        }    
        if(transform.position == posB.position)
        {
            nextPos = posA.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, 
                                                 nextPos,
                                                 speed * Time.deltaTime);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(posA.position, posB.position);
    }
}
