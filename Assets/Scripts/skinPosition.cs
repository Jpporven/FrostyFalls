using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skinPosition : MonoBehaviour
{
    public Joystick joystick;

    public Transform notRunning;
    public Transform Running;

    public float skinSpeed;

    // Update is called once per frame
    void Update()
    {
        if(joystick.Horizontal != 0)
	{
	      transform.position = Vector3.Lerp(transform.position, Running.position, skinSpeed);
	}
        if(joystick.Horizontal == 0)
	{
	      transform.position = Vector3.Lerp(transform.position, notRunning.position, skinSpeed);
	}
    }
}
