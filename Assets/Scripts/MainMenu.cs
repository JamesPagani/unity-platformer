using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioMixer masterMixer;

    private void Start()
    {
        masterMixer.SetFloat("BGMVol", PlayerPrefs.GetFloat("bgmVolume", 0));
        masterMixer.SetFloat("SFXVol", PlayerPrefs.GetFloat("sfxVolume", 0));
    }

    /* Loads a level, based on the build settings.
     * INDEX:
     *  0: Main Menu.
     *  1: Options.
     *  2 to 4: Levels 1 to 3.
     */
    public void LevelSelect(int level)
    {
        SceneManager.LoadScene(level);
    }

    // Loads the options.
    public void Options()
    {
        PlayerPrefs.SetInt("prevScene", SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene("Options");
    }

    // Quits the game.
    public void Exit()
    {
        Application.Quit();
    }
}
