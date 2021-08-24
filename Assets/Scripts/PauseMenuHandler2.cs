using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuHandler2 : MonoBehaviour
{
    public GameObject pauseWindow;
    public GameManager2 manager;

    public bool isPaused = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && manager.gameStarted)
        {
            if (!isPaused)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
        }
    }

    public void PauseGame()
    {
        SoundManager.Instance.Play(SoundManager.Sounds.ButtonClick);
        isPaused = true;
        pauseWindow.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        SoundManager.Instance.Play(SoundManager.Sounds.ButtonClick);
        isPaused = false;
        Time.timeScale = 1f;
        pauseWindow.SetActive(false);
    }

    public void Menu()
    {
        SceneManager.LoadScene("Start");
    }
}
