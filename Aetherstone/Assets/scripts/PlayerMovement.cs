using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;
    
        // Update is called once per frame
        void Update()
        {
       movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("moveX", movement.x);
        animator.SetFloat("moveY", movement.y);
        animator.SetFloat("speed" , movement.sqrMagnitude);
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}

















































































//why are you here 104 lines down? huh? i expect you to type a response...