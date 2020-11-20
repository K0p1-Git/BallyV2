using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;
    public float jumpforce;
    private float moveInput;
    private bool isRight = true;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private int extraJumps;
    public int extraJumpValue;

    private Rigidbody2D rb;
    private Transform tr;

    public float idleTime = 5f;
    private float counter = 0f;
    private bool isIdle = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if (Mathf.Abs(moveInput) == 0 && isGrounded)
        {
            counter += Time.deltaTime;

            if (counter > idleTime && !isIdle)
            {
                isIdle = true;
            }
        }
        else
        {
            counter = 0f;
            isIdle = false;
        }

        if (isRight == false && moveInput > 0)
            flip();
        else if (isRight == true && moveInput < 0)
            flip();


    }
    private void Update()
    {
        if(isGrounded == true)
        {
            extraJumps = extraJumpValue;
        }

        if(Input.GetButtonDown("Jump") && extraJumps == 0 && isGrounded)
        {
            FindObjectOfType<AudioManager>().Play("jumpSFX");
            rb.velocity = Vector2.up * jumpforce;
        }
        else if (Input.GetButtonDown("Jump") && extraJumps > 0)
        {
            FindObjectOfType<AudioManager>().Play("jumpSFX");
            rb.velocity = Vector2.up * jumpforce;
            extraJumps--;
        }


    }
    void flip()
    {
        isRight = !isRight;
        transform.Rotate(0f, 180f, 0f);
    }
}
