﻿
using UnityEngine;

using UnityEngine.UI;

using System.Collections;

public class ChangeVolume : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioSource volumeAudio;
    public void VolumeController()
    {
        volumeAudio.volume = volumeSlider.value;
    }
}