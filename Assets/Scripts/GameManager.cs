using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

  public static GameManager instance;
    public BirdScript bird;

    public bool isStartGame;
    public bool isGameOver;
    //public int score = 0;


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
            DataManager.instance.SetBestScore();
            isGameOver = true;
            AudioManager.instance.PlayEndGame();
            UIManager.instance.GameOverPanel();
        }
       
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        AudioManager.instance.MuteAudio();
    }
    public void UnPauseGame()
    {
        Time.timeScale = 1;
        AudioManager.instance.MuteAudio();

    }

    public void StartGame()
    {
        isStartGame = true;
        bird.StartGame();

    }


    public void AddScore()
    {
        DataManager.instance.AddScore();
        int score = DataManager.instance.GetScore();
       

        UIManager.instance.updateScore(score);
        AudioManager.instance.PlayScoreAudio();
    }

    public int GetScore()
    {
        return DataManager.instance.GetScore();
    }
}
