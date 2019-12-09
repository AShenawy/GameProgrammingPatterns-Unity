using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBall : PowerBall
{
    public AudioClip ballSound;
    public GameObject particleEffect;
    private GameObject ballObject;
    public GameObject spawnLocation;
    public List<GameObject> ballList;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Activate();
    }

    protected override void Activate()
    {
        base.Activate();
        ballObject =  ballList[Random.Range(0, ballList.Count)];
        MakeParticles(particleEffect, spawnLocation.transform.position);
        CreateBall(ballObject, spawnLocation.transform.position);
        PlaySound(ballSound);
    }
}
