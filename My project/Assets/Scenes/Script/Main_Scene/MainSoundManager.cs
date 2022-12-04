using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MainSoundManager : MonoBehaviour
{
    public AudioSource mmusicsource;

    public AudioSource btnsource;

    public void SSetMusicVolume(float volume)
    {
        mmusicsource.volume = volume;
    }

    public void MMVOFF()
    {
        mmusicsource.volume = 0;
    }

    public void cclick()
    {
        btnsource.Play();
    }
}
