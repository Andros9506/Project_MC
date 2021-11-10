using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Player_Movements : MonoBehaviour
{
    // public
    public float movVel = 1f;
    public float MovementSpeed;
    public float JumpForce = 1;
    public Animator animator;
    //public float JumpSpeed = 1;

    //[SerializeField] private LayerMask platforms;
    //private 

    private Rigidbody2D _rigidbody;
    private float scale;
    private bool IsJump;
    private bool IsRun;
    private BoxCollider2D boxCollider2D;
    private Player_Stats stats;
    private bool rightFace = true;
    private bool onGround = true;
    private bool isFalling;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody2D>();
        scale = transform.localScale.x;
        boxCollider2D = transform.GetComponent<BoxCollider2D>();
        stats = gameObject.GetComponent<Player_Stats>();
        MovementSpeed = movVel;
    }

    // Update is called once per frame
    void Update()
    {
        var movement_x = Input.GetAxisRaw("Horizontal");
        var movement_y = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(movement_x, 0, 0) * Time.deltaTime * MovementSpeed;
        animator.SetFloat("Speed", Mathf.Abs(movement_x));
        //Run animation
        if (movement_x == 0 && movement_y == 0)
        {
            animator.SetBool("IsRun", false);
        }
        else
        {
            animator.SetBool("IsRun", true);
        }
        // Flip Sprite
        if (movement_x < 0 && rightFace)
        {
            Flip();
        }
        if (movement_x > 0 && !rightFace)
        {
            Flip();
        }

        //Jump animation
        if (Input.GetButtonDown("Jump") && animator.GetBool("IsJump") == false && _rigidbody.velocity.y == 0)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            animator.SetBool("IsJump", true);
            
        }
            //Fall animation
            if (_rigidbody.velocity.y < 0)
        {
            animator.SetBool("isFall", true);
            animator.SetBool("IsJump", false);
        }
        else
        {
            animator.SetBool("isFall", false);
        }

    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name == "Ground");
        if(collision.gameObject.name == "Ground")
        {
            //animator.SetBool("IsJump", false);
            animator.SetBool("onGround", true);
        }


    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name == "Ground");
        if (collision.gameObject.name == "Ground")
        {
           // animator.SetBool("IsJump", true);
            animator.SetBool("onGround", false);
        }
    }

    void Flip()
    {
        rightFace = !rightFace;
        transform.Rotate(0f, 180f, 0f);
    }
}
