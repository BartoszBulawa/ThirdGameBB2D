using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Player : MonoBehaviour
{
    [SerializeField]
    private float moveForce = 10f;
    [SerializeField]
    private float jumpForce = 11f;

    private float movementX;

    public static Rigidbody2D myBody;

    private SpriteRenderer sr;

    private Animator anim;

    private string WALK_ANIMATION = "Walk";

    private string JUMP_ANIMATION = "Jump";

    private bool isGrounded = true;

    private string groundTAG = "Ground";

    private string enemyTag = "Enemy";

    


    private void Awake()
    {
        
        myBody = GetComponent<Rigidbody2D>();
        
        anim = GetComponent<Animator>();

        sr = GetComponent<SpriteRenderer>();

    }
    void Start()
    {
        
    }

    void Update()
    {
        PlayerMoveKeyboard();
        AnimatePlayer();
        PlayerJump();
        PlayerHugeJump();

    }
    
    private void FixedUpdate()
    {
        
    }
    void PlayerMoveKeyboard()
    {
        movementX = Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;


    }
    void AnimatePlayer()
    {
        if (movementX > 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = false;
        }
        else if (movementX < 0)
        {
            anim.SetBool(WALK_ANIMATION, true);
            sr.flipX = true;
        }
        else
        {
            anim.SetBool(WALK_ANIMATION, false);
        }
        if (isGrounded == false)
        {
            anim.SetBool(JUMP_ANIMATION, true);
        }
        else
        {
            anim.SetBool(JUMP_ANIMATION, false);
        }



    }
    void PlayerJump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isGrounded = false;
            myBody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            

        }
    }
    void PlayerHugeJump()
    {
        
        if (HugeJump.HugeJumpColleced > 0 && Input.GetButtonDown("wKey") && isGrounded)
        {
            isGrounded = false;
            HugeJump.DoHugeJump();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(groundTAG))
        {
            isGrounded = true;
        }
        if ((collision.gameObject.CompareTag(enemyTag)))
        {
            HugeJump.HugeJumpColleced = 0;
            Destroy(gameObject);
        }
 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(enemyTag))
        {
            HugeJump.HugeJumpColleced = 0;
            Destroy(gameObject);
            
        }

        if (collision.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            FindObjectOfType<Score>().ScoreUp();
        }

    }
   
   
}
