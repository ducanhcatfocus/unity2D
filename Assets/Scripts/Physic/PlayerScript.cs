using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField] float _speed;
    [SerializeField] float _jumpForce;



    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Movement();
        Jump();
    }

    protected void Movement()
    {
        float isMove = Input.GetAxisRaw("Horizontal");
        //transform.position += new Vector3(_speed * Time.deltaTime * isMove, 0, 0);

        rb.velocity = new Vector2(isMove * _speed, rb.velocity.y);    
    }

    protected void Jump()
    {
        bool isJump = Input.GetKeyDown(KeyCode.Space);

        if (isJump)
        {
            //rb.AddForce(new Vector2(0,  _jumpForce), ForceMode2D.Force);
            rb.velocity += new Vector2(0, _jumpForce);
        }
    }
}
