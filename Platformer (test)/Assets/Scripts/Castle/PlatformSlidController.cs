using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSlidController : MonoBehaviour
{
    public float speed;

    private float up;
    private float down;

    public JointMotor2D motorX;

    private void Start()
    {                   
       
    }
    private void FixedUpdate()
    {
        motorX.motorSpeed = 5;

    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if(motorX.motorSpeed > 0)
    //    {
    //        Debug.Log("вверх");
    //        motorX.motorSpeed = -1;
    //    }
    //    if (motorX.motorSpeed < 0)
    //    {
    //        Debug.Log("вниз");
    //        motorX.motorSpeed = 1;
    //    }
    //}
}
