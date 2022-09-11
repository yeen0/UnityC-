using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fullMovement : MonoBehaviour
{
    // Velocidades 
    private Rigidbody2D character;
    public float speed;
    private float moveInput;
    public float jumpForce;

    // Verificação de contato com o chão
    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;
    private bool isGrounded;

    // Timer de tempo no ar
    private float jumpTimeCounter;
    public float jumpTime;
    private bool isJumping;

    void Start()
    {
        character = GetComponent<Rigidbody2D> ();
        speed = 5;
        jumpForce = 5;
        checkRadius = 0.3f;
        jumpTime = 0.35f;

    }


    void Update()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);
        
        // Flipar sprite
        if(moveInput < 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        } else if(moveInput > 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        // Ação de pulo padrão
        if(isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
            character.velocity = Vector2.up * jumpForce;
            jumpTimeCounter = jumpTime;
        }

        // Segurar o botão de pulo
        if(Input.GetKey(KeyCode.Space) && isJumping)
        {
            if(jumpTimeCounter > 0)
            {
               character.velocity = Vector2.up * jumpForce;
               jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
        }

        if(Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
        }
    }


    void FixedUpdate()
    {
        character.velocity = new Vector2(moveInput * speed, character.velocity.y);
    }
}

