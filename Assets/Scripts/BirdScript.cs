using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D rb;
    [SerializeField] float _JumpForce = 1f;
    [SerializeField] float _rotateForce = 2f;


    private void Start()
    {
        Debug.Log("dsadsd");
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {

        if (GameManager.instance.isGameOver) return;
        bool isJump = Input.GetKeyDown(KeyCode.Space);


        if(isJump)
        {
          
            Jump();
        }

        RotateHead();
    }

    protected void RotateHead()
    {
       
        transform.eulerAngles -= new Vector3(0, 0, _rotateForce * Time.deltaTime);
     

    }

    protected void Jump()
    {
        rb.velocity = _JumpForce * Vector2.up;
        transform.eulerAngles = new Vector3(0, 0, 30);
        AudioManager.instance.PlayFlapBird();
    }



}
