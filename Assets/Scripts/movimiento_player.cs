﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento_player : MonoBehaviour
{
    public float velocidad;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
