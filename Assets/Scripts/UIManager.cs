using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
   public static UIManager instance;

    public Text textScore;

    private void Awake()
    {

        if (instance == null)
        {
    
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
   
            Destroy(gameObject);
        }
    }

    public void updateScore(float score)
    {
        textScore.text = score.ToString();
    }
}
