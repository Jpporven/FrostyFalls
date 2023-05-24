using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdEnemy : MonoBehaviour
{
 	public Transform[] checkpoint;
	public float BirdSpeed;
	public int CurrentBirdPosition;	
	public bool birdDirSwitch;

	float distance;
	int i;
	int d;

    void Start()
    {
	d = 0;
	birdDirSwitch = true;
    }


    // Update is called once per frame
    void FixedUpdate()
    {

	CurrentBirdPosition = d;


	if(distance <= 0.5f)
	{
		if(d < checkpoint.Length)
		{
			if(birdDirSwitch)
			{
				++d;
			}

			if(d == checkpoint.Length)
			{
				birdDirSwitch = false;

				transform.localScale = new Vector3( 0.8f,0.8f ,0f);
			}
		}
		if(d >= 1)
		{
			if(!birdDirSwitch)
			{
				--d;
			}

			if(d == 0)
			{
				birdDirSwitch = true;

				transform.localScale = new Vector3( -0.8f,0.8f ,0f);
			}
		}
	}
	
	transform.position = Vector3.MoveTowards(transform.position, Vector3.Lerp(transform.position, checkpoint[d].position, BirdSpeed), BirdSpeed);

	if(d == 0)
	{
		birdDirSwitch = true;
	}


	distance = Vector3.Distance (checkpoint[d].position, transform.position);

      
    }


}
