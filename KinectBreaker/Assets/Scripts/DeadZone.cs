using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {   // player loses a life if the ball comes into contact with the ground
        GM.instance.LoseLife();
    }
}
