using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    private int currentLevel;
    private void Start()
    {
        currentLevel = SceneManager.GetActiveScene().buildIndex;
    }

    // Back to the main menu.
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Takes you to the next level.
    // If you've completed the last level, it sends you to the main menu instead.
    public void Next()
    {
        if (currentLevel < 4)
        {
            SceneManager.LoadScene(++currentLevel);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }
}
