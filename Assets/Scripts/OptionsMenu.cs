using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    [HideInInspector] public int previousScene;
    public Toggle invertYAxis;
    public Slider bgmSlider;
    public Slider sfxSlider;

    // Load ALL the PlayerPrefs
    public void Start()
    {
        previousScene = PlayerPrefs.GetInt("prevScene", 0);
        invertYAxis.isOn = PlayerPrefs.GetInt("yInverted", 0) == 1 ? true : false;
        bgmSlider.value = PlayerPrefs.GetFloat("bgmVolume", 0);
        sfxSlider.value = PlayerPrefs.GetFloat("sfxVolume", 0);
    }

    ///<summary>Save all changes done and return to the previous scene.</summary>
    public void Apply()
    {
        PlayerPrefs.SetInt("yInverted", invertYAxis.isOn ? 1 : 0);
        PlayerPrefs.SetFloat("bgmVolume", bgmSlider.value);
        PlayerPrefs.SetFloat("sfxVolume", sfxSlider.value);
        SceneManager.LoadScene(previousScene);
    }

    ///<summary>Return to the previous scene without saving the changes.</summary>
    public void Back()
    {
        SceneManager.LoadScene(previousScene);
    }
}
