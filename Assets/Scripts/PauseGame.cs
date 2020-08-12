using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{

    public bool isPaused;

    public GameObject pauseMenu;



    void Start()
    {
        isPaused = false;
    }

    void Update()
    {
        if(isPaused) // Chekc if the game is paused through a boolean variable.
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0.0f; // This will freeze the game
        }
        else
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1.0f;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused; // If the escape key has been pressed, then negate the current boolean value.
        }



    }
}
