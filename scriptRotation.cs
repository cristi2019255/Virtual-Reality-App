﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate() {

        this.transform.Rotate(0, Time.deltaTime*100, 0);
    }
}
