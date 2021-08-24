using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    public GameObject info;
    public GameObject menu;

    private void Awake()
    {
        Time.timeScale = 1;
    }

    public void Mode1()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Mode2()
    {
        SceneManager.LoadScene("GameScene2");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Info()
    {
        menu.SetActive(false);
        info.SetActive(true);
    }

    public void InfoBack()
    {
        menu.SetActive(true);
        info.SetActive(false);
    }
}
