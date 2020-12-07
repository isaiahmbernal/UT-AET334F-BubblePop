using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pauseMenu : MonoBehaviour
{
    public GameObject settings;

    public static bool GameIsPaused = false;

    void Start()
    {
        settings.SetActive(false);

        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused == true)
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                settings.SetActive(false);
                Time.timeScale = 1f;
                GameIsPaused = false;
            }
            else if (GameIsPaused == false)
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                settings.SetActive(true);
                Time.timeScale = 0f;
                GameIsPaused = true;
            }
        }
    }

    public void Quit()
    {
        SceneManager.LoadScene(0);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        settings.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        //taskbar.tasks = 0;
        //taskbar.counter = 0;
        //power.counter = 0;
        //prep.counter = 0;
    }

    public void Back()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        settings.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
}
