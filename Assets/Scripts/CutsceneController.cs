using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;

public class CutsceneController : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private GameObject player;
    [SerializeField] private Canvas timerCanvas;
    private Animator cameraAnimator;
    private void Start()
    {
        cameraAnimator = GetComponent<Animator>();
        cameraAnimator.SetInteger("level", SceneManager.GetActiveScene().buildIndex);
    }

    public void StartGameplay()
    {
        // Activate normal gameplay.
        mainCamera.gameObject.SetActive(true);
        player.GetComponent<PlayerController>().enabled = true;
        timerCanvas.gameObject.SetActive(true);

        // Disable this camera.
        gameObject.SetActive(false);
    }
}
