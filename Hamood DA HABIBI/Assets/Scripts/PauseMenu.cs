using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject PauseMenuGUI;

    void Start()
    {
        
    }

    // Update is called once per frame
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
        Time.timeScale = 1;
        PauseMenuGUI.SetActive(false);
        GameIsPaused = false;
    }
    public void Pause()
    {
        Time.timeScale = 0;
        PauseMenuGUI.SetActive(true);
        GameIsPaused = true;
    }
    public void Back2Menu()
    {
        SceneManager.LoadScene(0);
    }
}
