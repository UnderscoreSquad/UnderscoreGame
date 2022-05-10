/*
 * Rawr~
 *
 * x3 Nuzzles, pounces on you, OwO you're so warm!
 * Couldn't help but notice your bulge from across the floor...
 * Nuzzles your necky wecky~ murr~ hehe!
 * Unzips your baggy ass pants, baby you so musky...
 * Take me home, pet me and make me yours and don't forget to stuff me!
 * See me wag my wittle baby tail all for yo' bulgy-wulgy...
 * Kissies and lickies you neck I hope daddy likies!
 * Nuzzle and wuzzles your chest, yuh...
 * I be gettin' thirsty!
 *
 * Hey I got a little itch, you think you can help me?
 * Only seven inches long OwO please adopt me!
 * Paws on your bulge as I lick my lips, OwO punish me please!
 * Gotta hit em' with this furry shit, they don't see it coming...
 */

using UnityEngine;

public class CattoMovement : MonoBehaviour
{
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask ground;
    public float moveInput;
    public float playerSpeed;
    public float playerJumpForce;

    private Rigidbody2D playerRigidbody2D;
    private Animator playerAnimator;

    private bool cattoIsFacingRight = true;
    private bool cattoIsJumping = false;
    private bool cattoIsGrounded = false;

    void Start()
    {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        cattoIsGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, ground);

        moveInput = Input.GetAxis("Horizontal");

        if (cattoIsGrounded)
        {
            playerAnimator.SetFloat("Velocity", Mathf.Abs(moveInput));
        }

        if (Input.GetButtonDown ("Jump") && cattoIsGrounded)
        {
            cattoIsJumping = true;
            playerAnimator.SetTrigger("Jump");
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) && cattoIsGrounded)
        {
            playerSpeed = 9.165f;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            playerSpeed = 6.11f;
        }

        if (Input.GetKeyDown(KeyCode.S) && cattoIsGrounded)
        {
            playerAnimator.SetBool("Crouch", true);
            playerSpeed = 4.073f;
        }

        else if (Input.GetKeyUp(KeyCode.S))
        {
            playerAnimator.SetBool("Crouch", false);
            playerSpeed = 6.11f;
        }
    }

    private void FixedUpdate()
    {
        playerRigidbody2D.velocity = new Vector2(moveInput * playerSpeed, playerRigidbody2D.velocity.y);

        if (cattoIsFacingRight == false && moveInput > 0)
        {
            FlipCatto();
        }
        else if (cattoIsFacingRight == true && moveInput < 0)
        {
            FlipCatto();
        }

        if (cattoIsJumping)
        {
            playerRigidbody2D.AddForce(new Vector2(0f, playerJumpForce));

            cattoIsJumping = false;
        }
    }

    private void FlipCatto()
    {
        cattoIsFacingRight = !cattoIsFacingRight;
        
        Vector3 cattoScale = transform.localScale;
        cattoScale.x *= -1;

        transform.localScale = cattoScale;
    }
}