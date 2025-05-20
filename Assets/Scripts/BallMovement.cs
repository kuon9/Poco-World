using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class BallMovement : MonoBehaviour
{
    [Header("Players' Attributes")]
    [SerializeField] float moveSpeed;
    [SerializeField] float jumpForce;




    //public GameObject player;
    public BoxCollider2D feetCollider;
    public Animator ballanim;
    Vector2 movementInput;
    Rigidbody2D rigidbody;
    public bool isAlive = true;
    bool isJumping;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(!isAlive) {return;}
        Roll();
        FlipDirection();    
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
        // if ball is moving then it has horizontal speed meaning the rolling animation will always
        // be in effect
        ballanim.SetBool("Rolling", ballhasHorizontalSpeed);
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if(!isAlive) {return;}
        bool isTouchingGround = feetCollider.IsTouchingLayers(LayerMask.GetMask("Ground"));
        if(context.started && isTouchingGround)
        {
            //rigidbody.AddForce(Vector2.up* jumpForce, ForceMode2D.Impulse);
            rigidbody.velocity = new Vector3(rigidbody.velocity.x, jumpForce);
            Debug.Log("Jumping");
            isJumping = true;
        }
    }


    void FlipDirection()
    {
        if(rigidbody.velocity.x < 0)
        {
            transform.localScale = new Vector3(-1f,1f,1f);
        }
        else if(rigidbody.velocity.x > 0)
        {
            transform.localScale = new Vector3(1f,1f,1f);
        }
    }
}
