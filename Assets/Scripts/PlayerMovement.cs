using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask ground;
    public float moveInput;
    public float playerSpeed;
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
            playerSpeed = 9.165f;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            playerSpeed = 6.11f;
        }

        if (Input.GetKeyDown(KeyCode.S) && playerIsGrounded)
        {
            playerAnimator.SetBool("Special", true);
        }

        else if (Input.GetKeyUp(KeyCode.S))
        {
            playerAnimator.SetBool("Special", false);
        }
    }

    private void FixedUpdate()
    {
        playerRigidbody2D.velocity = new Vector2(moveInput * playerSpeed, playerRigidbody2D.velocity.y);

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
}