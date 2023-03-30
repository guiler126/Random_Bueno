
using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float walkspeed = 6f;
    private float moveInput;
    public bool isGrounded;
    private Rigidbody2D rb;
    public LayerMask GroundMask;
    public SpriteRenderer SpriteRenderer;
    public Animator Animator;
    private Vector2 actualPos;

    public bool canJump = true;
    public float jumpValue = 0.0f;
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
        Animator.Play("respawn");
    }

   
    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");

        isGrounded = Physics2D.OverlapCircle(transform.position, 0.2f, GroundMask);

        if (isGrounded)
        {
            Animator.SetBool("fall", false);
        }
        else
        {
            Animator.SetBool("fall",true);
        }
        
        if (Input.GetKey(KeyCode.Space) && isGrounded && canJump)
        {
            
            jumpValue += 0.1f;
        }

        if (Input.GetKey(KeyCode.Space) && isGrounded && canJump)
        {
            rb.velocity = new Vector2(0.0f, rb.velocity.y);
        }
        
        if (jumpValue >= 20f && isGrounded)
        {
            Animator.SetTrigger("jump");
            float tempx = moveInput * walkspeed;
            float tempy = jumpValue;
            rb.velocity = new Vector2(tempx, tempy);
            Invoke("resetjump", 0.2f);
        }
        

        
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Animator.SetTrigger("jump");
            if (isGrounded)
            {
                rb.velocity = new Vector2(moveInput * walkspeed, jumpValue);
                jumpValue = 0.0f;
            }
            canJump = true;
        }
        
                
        
        if (moveInput == 0)
        {
            Animator.SetBool("walk",false);
            rb.velocity = new Vector2(moveInput * walkspeed, rb.velocity.y);

            return;
        }
        
        
        if (jumpValue == 0.0f && isGrounded)
        {
            if (moveInput > 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                rb.velocity = new Vector2(moveInput * walkspeed, rb.velocity.y);
            }
            else
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
                rb.velocity = new Vector2(moveInput * walkspeed, rb.velocity.y);
            }
            Animator.SetBool("walk", true);

        }
        




    }

    void resetjump()
    {
        canJump = false;
        jumpValue = 0;
    }

    
    
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawCube(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 0.5f), new Vector2(0.9f, 0.2f));
    }
    
}
