﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    // paddle speed
    public float paddleSpeed = 1f;
    // player initial position
    private Vector3 playerPos = new Vector3(0, -9.5f, 0);

    void Update()
    {
        float xPos = transform.position.x;
        // if Kinect is available 
        if (KM.instance.IsAvailable)
        {
            xPos = KM.instance.PaddlePosition;
        }
        else
        {
            xPos = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
        }
        // Keeps paddle within area
        playerPos = new Vector3(Mathf.Clamp(xPos, -8f, 8f), -9.5f, 0f);

        transform.position = playerPos;
    }
}// Update


