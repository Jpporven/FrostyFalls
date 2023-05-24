using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optionsMenuMove : MonoBehaviour
{

    public Transform InCam;

    public Transform OutOfCam;

    public float menuSpeed;

    public static int OptionsMenuValue;


    // Update is called once per frame
    void Update()
    {
        
	if(OptionsMenuValue == 1)
	{
  	
	      transform.position = Vector3.Lerp(transform.position, InCam.position, menuSpeed);

	}

	if(OptionsMenuValue == 0)
	{

	      transform.position = Vector3.Lerp(transform.position, OutOfCam.position, menuSpeed);

	}

    }
}
