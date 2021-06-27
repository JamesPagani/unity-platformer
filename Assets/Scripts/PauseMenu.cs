using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    // Is the game currently paused?
    private bool _isPaused;
    // Reference to the current scene.
    private Scene currentScene;

    ///<summary>The pause menu interface.</summary>
    public Canvas pauseMenu;
    ///<summary>Audio Mixer configuration when the game is paused.</summary>
    public AudioMixerSnapshot paused;

    ///<summary>Audio Mixer configuration when the game is not paused.</summary>
    public AudioMixerSnapshot unpaused;

    // Called at the start of the scene's lifespan.
    private void Start()
    {
        _isPaused = false;
        currentScene = SceneManager.GetActiveScene();
    }

    ///<summary></summary>
    public void Pause()
    {
        Time.timeScale = 0;
        _isPaused = true;
        pauseMenu.gameObject.SetActive(true);
        paused.TransitionTo(.1f);
    }

    // Returns to the game
    public void Resume()
    {
        pauseMenu.gameObject.SetActive(false);
        Time.timeScale = 1;
        _isPaused = false;
        unpaused.TransitionTo(.1f);
    }

    // Restart the current scene
    public void Restart()
    {
        unpaused.TransitionTo(.1f);
        SceneManager.LoadScene(currentScene.buildIndex);
        Resume();
    }

    // Go back to the main menu
    public void MainMenu()
    {
        Time.timeScale = 1;
        _isPaused = false;

        SceneManager.LoadScene("MainMenu");
        unpaused.TransitionTo(.1f);
    }

    // Go to the options menu
    public void Options()
    {
        Time.timeScale = 1;
        _isPaused = false;
        PlayerPrefs.SetInt("prevScene", currentScene.buildIndex);
        unpaused.TransitionTo(.1f);
        SceneManager.LoadScene("Options");
    }

    // Handling pausing
    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (!_isPaused)
                Pause();
            else
                Resume();
        }
    }
}
