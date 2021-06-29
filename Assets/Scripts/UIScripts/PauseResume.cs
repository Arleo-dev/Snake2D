using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseResume : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;

    public static bool gameIsPaused = false;
    public void PauseGame()
    {
        _pauseMenu.SetActive(true);
        Time.timeScale = 0;
        gameIsPaused = true;
    }

    public void ResumeGame()
    {
        _pauseMenu.SetActive(false);
        Time.timeScale = 1;
        gameIsPaused = false;
    }
}
