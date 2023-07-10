using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PanelScript : MonoBehaviour
{
    public TextMeshProUGUI playerScore;
    public TextMeshProUGUI bestScore;

    public Image medalImage;

    //public List<Sprite> medals;
    public Sprite goldMedal
     ,silverMedal
    ,bronzeMedal;

    public List<GameObject> listButtons = new List<GameObject>();



    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }
    public void DisplayPlayerScore(int score)
    {
        StartCoroutine(CoutingScore(score, 2));
    }

    private IEnumerator CoutingScore(int target, float duration)
    {
        playerScore.text = 0.ToString();
        yield return new WaitForSeconds(1f);
        if (target != 0)
        {
            for (int i = 0; i <= target; i++)
            {
                playerScore.text = i.ToString();
                yield return new WaitForSeconds(duration / target);
            }
        }

        for(int i =0; i< listButtons.Count; i++)
        {
            listButtons[i].SetActive(true);
        }
    
    }


    public void DisplayBestScore(int score)
    {
        bestScore.text = score.ToString();
    }

    public void setMedalImage(int score)
    {
        if (score >= 8)
        {
          
            medalImage.sprite = goldMedal;
            return;
        }
        if (score >= 4)
        {
            medalImage.sprite = silverMedal;
            return;

        }

        medalImage.sprite = bronzeMedal;


    }

    public void PlayAgainOnClick()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
