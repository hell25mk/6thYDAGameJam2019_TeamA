﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{

    private float minPosition;
    private float maxPosition;
    private bool waveDire;

    // Start is called before the first frame update
    void Start()
    {
        waveDire = true;
        minPosition = 0.0f;
        maxPosition = 1900.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(waveDire) {
            this.transform.position = new Vector3(-1.0f, 0.0f);
        } else {
            this.transform.position = new Vector3(1.0f, 0.0f);
        }

        if(this.transform.position.x > maxPosition) {
            waveDire = !waveDire;
        } else if(this.transform.position.x < minPosition){
            waveDire = !waveDire;
        }

    }
}
