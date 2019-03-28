using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    public float paddleSpeed = 1f;
    public bool turnLeft;
    public bool turnRight;
    private Vector3 playerPos = new Vector3(0, -9.5f, 0);


	// Update is called once per frame
	void Update () {

        if (turnLeft)
        {

            float xPos = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
            playerPos = new Vector3(Mathf.Clamp(xPos, -8f, 8f), -9.5f, 0f);// clamps paddle within walls
            transform.position = playerPos;
            // transform.Rotate(new Vector3(0, -20, 0) * Time.deltaTime);
            //transform.Rotate(Vector3.right * Time.deltaTime * rotatespeed);


        }
        if (turnRight)
        {
            float xPos = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
            playerPos = new Vector3(Mathf.Clamp(xPos, -8f, 8f), -9.5f, 0f);// clamps paddle within walls
            transform.position = playerPos;
            //transform.Rotate(new Vector3(0, 20, 0) * Time.deltaTime);
        }





        //float xPos = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
        //playerPos = new Vector3(Mathf.Clamp(xPos, -8f, 8f), -9.5f, 0f);// clamps paddle within walls
        //transform.position = playerPos;

    }// Update

}// Paddle
