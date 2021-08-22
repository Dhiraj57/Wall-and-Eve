using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverWindow : MonoBehaviour
{
    public GameObject gameOverPanel;

    public void SetActive()
    {
        SoundManager.Instance.Play(SoundManager.Sounds.PlayerDeath);
        gameOverPanel.SetActive(true);
    }

    public void Replay()
    {
        SoundManager.Instance.Play(SoundManager.Sounds.ButtonClick);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
