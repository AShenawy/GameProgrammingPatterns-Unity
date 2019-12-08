using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerBall : MonoBehaviour
{
    protected GameObject ball;
    protected virtual void Activate() { }

    protected void MakeParticles(GameObject particles, Vector3 location)
    {
        GameObject particleInstance = Instantiate(particles, location, transform.rotation);
        Destroy(particleInstance, 2f);
    }

    protected void CreateBall (GameObject ballObject, Vector3 location)
    {
        ball = Instantiate(ballObject, location, transform.rotation);
        Destroy(ball, 2f);
    }
    protected void PlaySound(AudioClip audio)
    {
        if (audio)
        {
            ball.AddComponent<AudioSource>();
            ball.GetComponent<AudioSource>().clip = audio;
            ball.GetComponent<AudioSource>().PlayOneShot(audio);
        }
    }
}
