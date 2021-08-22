using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameOverWindow gameOverPanel;

    private void Awake()
    {
        Time.timeScale = 1;
        SoundManager.Instance.PlayMusic(SoundManager.Sounds.Music);
    }

    public void GameOver()
    {
        gameOverPanel.SetActive();
        Time.timeScale = 0;
    }
}
