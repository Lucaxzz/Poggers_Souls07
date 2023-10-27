using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player1 : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 5f;
private bool isFacingRight = true;
private Rigidbody2D rb;
private SpriteRenderer spriteRenderer;

    public Animator animator;

    void Start()
{
    rb = GetComponent<Rigidbody2D>();
    spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        
}


   void Update()
{
        if(Input.GetAxis("Horizontal") != 0)
        {
            animator.SetBool("taCorrendo", true);
        }
        else
        {
            animator.SetBool("taCorrendo", false);
        }

    float moveInput = Input.GetAxis("Horizontal");
    rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

    if (moveInput > 0 && !isFacingRight)
    {
        Flip();
    }
    else if (moveInput < 0 && isFacingRight)
    {
        Flip();
    }
}

void Flip()
{
    isFacingRight = !isFacingRight;
    Vector3 scale = transform.localScale;
    scale.x *= -1;
    transform.localScale = scale;
}

}
