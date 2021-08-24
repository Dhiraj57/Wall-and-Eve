using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    public GameOverWindow2 gameOverPanel;
    public GameObject score;
    public GameObject highscore;
    public GameObject startWindow;
    public GameObject obstacle1;

    public bool gameStarted;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            GameStart();
        }
    }

    private void Awake()
    {
        Time.timeScale = 1;
        SoundManager.Instance.PlayMusic(SoundManager.Sounds.Music);
    }

    public void GameOver()
    {
        gameOverPanel.SetActive();
        Time.timeScale = 0;
        gameStarted = false;
    }

    public void GameStart()
    {
        startWindow.SetActive(false);
        score.SetActive(true);
        highscore.SetActive(true);
        obstacle1.SetActive(true);
        //obstacle2.SetActive(true);
        gameStarted = true;
    }
}
