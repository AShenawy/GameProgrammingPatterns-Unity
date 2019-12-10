using System.Collections;
using System.Collections.Generic;
using UnityEngine;

struct PlayMessage
{
    public AudioClip clip;
    public float volume;
}

public class AudioManager : MonoBehaviour
{
    private const int maxPending = 16;
    private static PlayMessage[] pending = new PlayMessage[maxPending];
    private static int numPending;
    private static AudioSource audioSource;

    private void Start()
    {
        numPending = 0;
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {

        for (int i = 0; i < numPending; i++)
        {
            AudioSource.PlayClipAtPoint(pending[i].clip, Camera.main.transform.position, pending[i].volume);
        }

        numPending = 0;
    }

    public static void PlaySound(AudioClip audio, float vol)
    {
        // if number of sound requests reached the max then do not play sound
        if (numPending >= maxPending)
            return;

        pending[numPending].clip = audio;
        pending[numPending].volume = vol;
        numPending++;
    }

}

