using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour
{
    public Text highScoreText;
    private int score;
    private Text scoreText;
    private bool highScore;

    private void Awake()
    {
        highScoreText.text = "HI   " + PlayerPrefs.GetInt("highscore", 0).ToString("00000");
        score = 0;
        highScore = true;
        scoreText = GetComponent<Text>();
    }

    private void Start()
    {
        StartCoroutine(AddScore());
    }

    private void Update()
    {
        if(Time.timeScale == 0)
        {
            if(score > PlayerPrefs.GetInt("highscore", 0))
            {
                SetHighScore();
            }
        } 

        if (score > PlayerPrefs.GetInt("highscore", 0))
        {
            if(highScore)
            {
                SoundManager.Instance.Play(SoundManager.Sounds.HighScore);
                highScore = false;
            }
        }
    }

    private IEnumerator AddScore()
    {
        while(true)
        {
            yield return new WaitForSeconds(0.1f);
            score++;
            scoreText.text = score.ToString("00000");

            if (score % 100 == 0)
            {
                SoundManager.Instance.Play(SoundManager.Sounds.Switch);
                Time.timeScale += 0.1f;
            }

        }
    }

    private void SetHighScore()
    {      
        PlayerPrefs.SetInt("highscore", score);
        highScoreText.text = "HI   " + PlayerPrefs.GetInt("highscore", 0).ToString("00000");
    }
}
