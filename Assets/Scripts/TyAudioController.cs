using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TyAudioController : MonoBehaviour
{
    public PlayerController controller;
    
    // For both: Index 0 is grass, Index 1 is rock.
    [SerializeField]private AudioSource[] runningSounds; // Played when running.
    [SerializeField]private AudioSource[] splatSounds; // Played after falling back to the start of the level.
    
    ///<summary>Play a stepping sound that matches with the terrain.</summary>
    public void Step()
    {
        if (controller.grounded)
            runningSounds[controller.terrain].Play();
    }

    public void HardLanding()
    {
        splatSounds[controller.terrain].Play();
    }
}
