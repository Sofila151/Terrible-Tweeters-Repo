using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Debug.Log("Loading Menu...");
        SceneManager.LoadScene("Menu");
        Time.timeScale = 0f;

    }

    public void QuitGame()
    {
        Debug.Log("Quitting Game...");
        SceneManager.LoadScene("Quit");
    }

    public void Restart()
    {
        Debug.Log("Restarting Game..");
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Level 1");
    }
    }

