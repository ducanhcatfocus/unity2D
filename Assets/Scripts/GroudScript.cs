using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroudScript : MonoBehaviour
{

    [SerializeField] float _speed;

    public Transform groundStart, groundEnd;

    void Update()
    {
        transform.Translate(_speed * Time.deltaTime * Vector2.left);

        if(transform.position.x < groundEnd.position.x)
        {
            transform.position = groundStart.position;
        }
        
    }
}
