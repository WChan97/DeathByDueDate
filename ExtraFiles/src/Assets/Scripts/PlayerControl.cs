using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public float moveSpeed;
    public float jumpPower;
    private float moveVelocity;

    public Transform groundCheck;
    private float groundCheckRadius = 0.1f;
    public LayerMask whatIsGround;
    private bool grounded;

    private bool crouched;

    public GameManager theGameManager;
    private Animator myAnimator;

	// Use this for initialization
	void Start () {
        myAnimator = GetComponent<Animator>();
	}

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }
	
	// Update is called once per frame
	void Update () {
        
        //MOVEMENT
        moveVelocity = 0f;
		if(Input.GetKey(KeyCode.A))
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
            moveVelocity = -moveSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
            moveVelocity = moveSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            myAnimator.SetBool("Crouched", crouched);
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(moveVelocity, GetComponent<Rigidbody2D>().velocity.y);

        if (Input.GetKey(KeyCode.Space) && grounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpPower);
        }

        //ANIMATION
        myAnimator.SetFloat("Speed", GetComponent<Rigidbody2D>().velocity.x);

        myAnimator.SetBool("Grounded", grounded);

    }

   
}
