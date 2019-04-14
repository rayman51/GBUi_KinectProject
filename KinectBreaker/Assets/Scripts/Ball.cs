using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    // initial velocity of ball
    public float ballInitialVelocity = 600f;


    private Rigidbody rb;
    private bool ballInPlay;

    // Use this for initialization
    void Awake () {
        rb = GetComponent<Rigidbody>();
    }// Awake
	
	// Update is called once per frame
	void Update () {
        // is the ball in play
        if ((Input.GetButtonDown("Fire1") || KM.instance.IsFire) && ballInPlay == false)
        {
            transform.parent = null;
            ballInPlay = true;
            rb.isKinematic = false;
            rb.AddForce(new Vector3(ballInitialVelocity, ballInitialVelocity, 0));
            //KM.instance.IsFire = false;
        }// if

    }// Update
}// Ball
