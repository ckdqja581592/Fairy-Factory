using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SoundManager : MonoBehaviour
{
    public AudioSource musicsource;

    public AudioSource btnsource;

    public void SetMusicVolume(float volume)
    {
        musicsource.volume = volume;
    }

    public void MVOFF()
    {
        musicsource.volume = 0;
    }

    public void click()
    {
        btnsource.Play();
    }
}