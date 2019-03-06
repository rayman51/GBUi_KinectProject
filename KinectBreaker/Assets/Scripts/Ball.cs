﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public float ballInitialVelocity = 600f;


    private Rigidbody rb;
    private bool ballInPlay;

    // Use this for initialization
    void Awake () {
        rb = GetComponent<Rigidbody>();
    }// Awake
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1") && ballInPlay == false)
        {
            transform.parent = null;
            ballInPlay = true;
            rb.isKinematic = false;
            rb.AddForce(new Vector3(ballInitialVelocity, ballInitialVelocity, 0));
        }// if

    }// Update
}// Ball
