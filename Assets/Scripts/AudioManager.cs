using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    public static AudioManager instance;
    public AudioSource audioSource;
    public AudioClip audioClip;
    public AudioClip endgameClip;
    public AudioClip scoreClip;
    private bool isMuted;



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

    public void PlayFlapBird()
    {
        if(!isMuted)
        {
            audioSource.PlayOneShot(audioClip);

        }
    }

    public void PlayEndGame()
    {
        if (!isMuted)
        {
            audioSource.PlayOneShot(endgameClip);
        }
    }

    public void PlayScoreAudio()
    {
        if (!isMuted)
        {
            audioSource.PlayOneShot(scoreClip);
        }

    }
    public void MuteAudio()
    {
        isMuted = !isMuted;
    }

}
