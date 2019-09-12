﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projMove : MonoBehaviour
{
    private Rigidbody2D rb2d_proj;

    private float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d_proj = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2d_proj.velocity = transform.right * speed;
    }
}
