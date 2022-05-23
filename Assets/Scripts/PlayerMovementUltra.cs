using UnityEngine;

public class PlayerMovementUltra : MonoBehaviour
{
    [SerializeField] private bool isWalking;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask ground;
    public float moveInput;
    public float walkSpeed;
    public float runSpeed;
    public float playerJumpForce;
    public float playerJetpackForce;

    private Rigidbody2D playerRigidbody2D;
    private Animator playerAnimator;

    private bool playerIsFacingRight = true;
    private bool playerIsJumping = false;
    private bool playerIsUsingJetpack = false;
    private bool playerIsGrounded = false;

    void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        playerIsGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, ground);

        moveInput = Input.GetAxis("Horizontal");

        if (playerIsGrounded)
        {
            playerAnimator.SetFloat("Velocity", Mathf.Abs(moveInput));
        }

        if (Input.GetButtonDown("Jump") && playerIsGrounded)
        {
            playerIsJumping = true;
            playerAnimator.SetTrigger("Jump");
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) && playerIsGrounded)
        {
            playerAnimator.SetBool("Run", true);
        }

        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            playerAnimator.SetBool("Run", false);
        }

        if (Input.GetKeyDown("1") && playerIsGrounded)
        {
            playerAnimator.SetTrigger("Special");
            playerIsUsingJetpack = true;
        }

        if (Input.GetKeyDown(KeyCode.S) && playerIsGrounded)
        {
            playerAnimator.SetBool("Crouch", true);
            walkSpeed = 1.6292f;
            runSpeed = 2.444f;
            playerJumpForce = 146.668f;
            playerJetpackForce = 0f;
        }

        else if (Input.GetKeyUp(KeyCode.S))
        {
            playerAnimator.SetBool("Crouch", false);
            walkSpeed = 2.444f;
            runSpeed = 3.666f;
            playerJumpForce = 220f;
            playerJetpackForce = 440f;
        }
    }

    private void FixedUpdate()
    {
        float speed;
        IsRunning(out speed);
        playerRigidbody2D.velocity = new Vector2(moveInput * speed, playerRigidbody2D.velocity.y);

        if (playerIsFacingRight == false && moveInput > 0)
        {
            FlipPlayer();
        }
        else if (playerIsFacingRight == true && moveInput < 0)
        {
            FlipPlayer();
        }

        if (playerIsJumping)
        {
            playerRigidbody2D.AddForce(new Vector2(0f, playerJumpForce));

            playerIsJumping = false;
        }

        if (playerIsUsingJetpack)
        {
            playerRigidbody2D.AddForce(new Vector2(0f, playerJetpackForce));

            playerIsUsingJetpack = false;
        }
    }

    private void FlipPlayer()
    {
        playerIsFacingRight = !playerIsFacingRight;

        Vector3 playerScale = transform.localScale;
        playerScale.x *= -1;

        transform.localScale = playerScale;
    }

    private void IsRunning(out float speed)
    {
        isWalking = !Input.GetKey(KeyCode.LeftShift);
        speed = isWalking ? walkSpeed : runSpeed;
    }
}