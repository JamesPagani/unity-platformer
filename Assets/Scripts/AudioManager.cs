using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioMixer mixer;

    public void SetSFXVol(float sfxVol)
    {
        mixer.SetFloat("SFXVol", sfxVol);
    }
    public void SetBGMVol(float bgmVol)
    {
        mixer.SetFloat("BGMVol", bgmVol);
    }
}
