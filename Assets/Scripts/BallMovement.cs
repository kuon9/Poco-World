using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class BallMovement : MonoBehaviour
{
    [Header("Players' Attributes")]
    [SerializeField] float moveSpeed;




    Vector2 movementInput;
    
    Rigidbody2D rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        Roll();    
    }

    public void Move(InputAction.CallbackContext context)
    {
        movementInput = context.ReadValue<Vector2>();    
    }


    void Roll()
    {
        Vector2 ballVelocity = new Vector2(movementInput.x * moveSpeed, rigidbody.velocity.y);
        rigidbody.velocity = ballVelocity;
        bool ballhasHorizontalSpeed = Mathf.Abs(rigidbody.velocity.x) > Mathf.Epsilon;
    }

}
