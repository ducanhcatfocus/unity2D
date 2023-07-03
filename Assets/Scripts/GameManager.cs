using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
  public static GameManager instance;


    public bool isGameOver;
    public float score = 0;


    private void Awake()
    {
        // Kiểm tra xem đã có một phiên bản GameManager khác tồn tại chưa
        if (instance == null)
        {
            // Nếu chưa, gán phiên bản hiện tại cho instance
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // Nếu đã có, hủy đối tượng GameManager hiện tại
            Destroy(gameObject);
        }
    }

    public void EndGame()
    {
        if(isGameOver == false)
        {
            isGameOver = true;
            AudioManager.instance.PlayEndGame();
        }
       
    }


    public void AddScore()
    {
        score++;
        Debug.Log(score);

        UIManager.instance.updateScore(score);
        AudioManager.instance.PlayScoreAudio();
    }
}
