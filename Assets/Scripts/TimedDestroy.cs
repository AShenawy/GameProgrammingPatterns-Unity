﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDestroy : MonoBehaviour
{
    public float lifeInSeconds;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeInSeconds);
    }
}
