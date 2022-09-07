using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float speed;
    private float Move;

    public float jump;
    private int extraJumps;
    public int extraJumpsValue;

    public bool isGrounded;

    private bool facingRight = true;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
    }
    void Update(){

        Move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        if(isGrounded == true){
            extraJumps = extraJumpsValue;
        }
        if(Input.GetKeyDown(KeyCode.W) && extraJumps > 0){
            rb.velocity = Vector2.up * jump;
            extraJumps--;
        } else if(Input.GetKeyDown(KeyCode.W) && extraJumps == 0 && isGrounded == true){
            rb.velocity = Vector2.up * jump;
        }
        // if(facingRight == false && Move > 0){
        //     Flip();
        // } else if(facingRight == true && Move < 0) {
        //     Flip();
        // }
    }
    // void Flip(){

    //     facingRight = !facingRight;
    //     Vector3 Scaler = transform.localScale;
    //     Scaler.x *= -1;
    //     transform.localScale = Scaler;

    // }
}
