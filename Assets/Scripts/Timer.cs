using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public Text finalTime;
    
    private float timer;
    private int minutes;
    private int seconds;
    private int hundreths;
    

    private void Start()
    {
        timer = 0f;
    }

    public void Win()
    {
        finalTime.text = timerText.text;
        timerText.gameObject.SetActive(false);
    }

    private void Update()
    {
        timer += Time.deltaTime;
        minutes = (int)timer / 60;
        seconds = (int)timer % 60;
        hundreths = (int)((timer % 1) * 100);
        timerText.text = $"{minutes}:{seconds:D2}.{hundreths:D2}";
    }
}
