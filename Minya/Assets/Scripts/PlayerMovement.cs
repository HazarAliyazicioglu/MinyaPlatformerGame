using UnityEngine;
// ReSharper disable All

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D playerRB;
    AudioSource jumpSound;
    Vector2 move;
    Animator playerAnimator;
      
    public Transform groundCheckPosition;
    public LayerMask groundCheckLayer;
    
    public float groundCheckRadius;
    public float speed = 5;
    
    bool isFacingRight = true;
    bool isGrounded = true;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
        jumpSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        move = new Vector2(Input.GetAxisRaw("Horizontal"),playerRB.velocity.y);

        playerRB.freezeRotation = true;
        playerRB.velocity = new Vector2(move.x * speed , move.y );
        
        playerAnimator.SetFloat("playerSpeed",Mathf.Abs(move.x));
        
        OnGroundCheck();
        
        if (playerRB.velocity.x < 0 && isFacingRight)
        {
            TurnFace();
        }
        else if (playerRB.velocity.x > 0 && !isFacingRight)
        {
            TurnFace();
        }
        
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            jumpSound.Play(0);
            playerRB.AddForce(transform.up * 6f,ForceMode2D.Impulse);
        }
    }

    void TurnFace()
    {
        isFacingRight = !isFacingRight;
        Vector3 tempLocalScale = transform.localScale;
        tempLocalScale.x *= -1;
        transform.localScale = tempLocalScale;
    }

    void OnGroundCheck()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheckPosition.position, groundCheckRadius, groundCheckLayer);
        playerAnimator.SetBool("isplayerGrounded",isGrounded);
    }
    
}

