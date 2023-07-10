using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
   public static UIManager instance;

    public TextMeshProUGUI textScore;


    public GameObject buttonStart;
    public GameObject buttonPause;
    public GameObject buttonUnPause;
    public PanelScript gamePanel;
    public GameObject flashScreenOnDie;
   

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
    public void StartGameOnClick()
    {
        GameManager.instance.StartGame();
        buttonStart.SetActive(false);
    }

    public void PauseGameOnClick()
    {
        GameManager.instance.PauseGame();
      
        buttonPause.SetActive(false);
        buttonUnPause.SetActive(true);
    }

    public void UnPauseGameOnClick()
    {
        GameManager.instance.UnPauseGame();
       

        buttonUnPause.SetActive(false);
        buttonPause.SetActive(true) ;
    }

    public void updateScore(int score)
    {
        textScore.text = score.ToString();
    }

  

    public void GameOverPanel()
    {
        StartCoroutine(WaitForDisplay());
        buttonUnPause.SetActive(false);
        buttonPause.SetActive(false);
    }

    private IEnumerator WaitForDisplay()
    {
        flashScreenOnDie.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        flashScreenOnDie.SetActive(false);
        yield return new WaitForSeconds(0.5f);


        gamePanel.Show();
        int score = GameManager.instance.GetScore();
        gamePanel.DisplayPlayerScore(score);
        gamePanel.setMedalImage(score);
        int bestScore = PlayerPrefs.GetInt("BestScore");
        gamePanel.DisplayBestScore(bestScore);
    }
}
