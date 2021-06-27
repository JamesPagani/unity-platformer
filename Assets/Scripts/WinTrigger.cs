using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    private Timer timer;
    public Canvas winCanvas;
    public AudioSource bgm;
    public AudioSource victoryJingle;
  
    private void OnTriggerEnter(Collider other)
    {
        // Stopping the BGM
        bgm.Stop();
        victoryJingle.Play();

        // Stopping the timer.
        timer = other.GetComponent<Timer>();
        timer.Win();
        winCanvas.gameObject.SetActive(true);
    }
}
