using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioClip soundClip;
    [Range(0, 1)] public float volume = 1f;

    public void PlaySoundOnClick()
    {
        AudioManager.PlaySound(soundClip, volume);
        Debug.Log("Sound Button Clicked!");
    }
}
