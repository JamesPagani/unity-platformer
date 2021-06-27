using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    public Timer timer;

    private void OnTriggerExit(Collider other)
    {
        timer.enabled = true;
    }
}
