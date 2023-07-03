using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Script : MonoBehaviour
{

    [SerializeField] float _speed = 4f;
    public Animator _animator;
    public bool isMove;


    private void Start()
    {
        _animator = GetComponent<Animator>();

    }
    // Update is called once per frame
    void Update()
    {
      float move = Input.GetAxisRaw("Horizontal");
      transform.position +=  new Vector3(move * _speed * Time.deltaTime, 0, 0);

        if(move == 0)
        {
            isMove = false;
        }else
        {

            Debug.Log(move);

            transform.localScale = new Vector3(move, 1, 1);

            isMove = true;
        }


        _animator.SetBool("move", isMove);
    }
}
