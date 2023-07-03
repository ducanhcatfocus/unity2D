using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        IsDie(collision);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        IsScore(collision);

    }

    protected void IsDie(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            GameManager.instance.EndGame();
       
        }
    }

    protected void IsScore(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("scoreDetect"))
        {
            GameManager.instance.AddScore();
        }
    }
}
