using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class durdurmaMenusu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool isPaused;
    public Button duraklatildi;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void duraklatildigindaButonu()
    {
        if (isPaused)
        {
            ResumeGame();

        }
        else
        {
            PauseGame();
        }
    }
    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 1f;
        isPaused = false;
    }
}
