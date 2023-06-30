using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D rb;
    [SerializeField] float _JumpForce = 1f;

    private void Start()
    {
        Debug.Log("dsadsd");
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        bool isJump = Input.GetKeyDown(KeyCode.Space);


        if(isJump)
        {
            Jump();
        }


    }

    protected void Jump()
    {
        rb.velocity = _JumpForce * Vector2.up;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Game Over");
    }

}
