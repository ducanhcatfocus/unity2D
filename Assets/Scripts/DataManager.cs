using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static DataManager instance;
    public int score;

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

        if (!PlayerPrefs.HasKey("FirstPlay"))
        {
            score = 0;
            PlayerPrefs.SetInt("BestScore", 0);

            PlayerPrefs.SetInt("FirstPlay", 0);
        }
    }
  
    public void SetBestScore()
    {
        int bestScore = PlayerPrefs.GetInt("BestScore");
        if(score > bestScore)
        {
            PlayerPrefs.SetInt("BestScore", score);
        }
    }

    public void AddScore()
    {
        score++;
    }

    public int GetScore()
    {
        return score;
    }
}
