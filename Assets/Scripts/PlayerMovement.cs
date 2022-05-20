using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private bool isWalking;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask ground;
    public float moveInput;
    public float walkSpeed;
    public float runSpeed;
    public float playerJumpForce;

    private Rigidbody2D playerRigidbody2D;
    private Animator playerAnimator;

    private bool playerIsFacingRight = true;
    private bool playerIsJumping = false;
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
            playerJumpForce = 1100f;
            playerIsJumping = true;
        }

        else if (Input.GetKeyUp("1"))
        {
            playerJumpForce = 550f;
        }

        if (Input.GetKeyDown(KeyCode.S) && playerIsGrounded)
        {
            playerAnimator.SetBool("Crouch", true);
            walkSpeed = 4.073f;
            runSpeed = 6.11f;
            playerJumpForce = 366.67f;
        }

        else if (Input.GetKeyUp(KeyCode.S))
        {
            playerAnimator.SetBool("Crouch", false);
            walkSpeed = 6.11f;
            runSpeed = 9.165f;
            playerJumpForce = 550f;
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