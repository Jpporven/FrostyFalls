using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdMove : MonoBehaviour
{

    public Transform birdSpawn;

    public Transform targetPos;

    public float speed;

    float originalSpeed;

    public float birdRespawn;



    void Start()
    {

	originalSpeed = speed;

    }

    // Update is called once per frame
    void FixedUpdate()
    {


        transform.position = Vector3.MoveTowards(transform.position, Vector3.Lerp(transform.position, targetPos.position, speed), speed);

        float distance = Vector3.Distance (targetPos.position, transform.position);

	if (distance <= 1f)
	{

		StartCoroutine(birdReset());

	}else if (distance >= 1.1f)
	{
	
		StopCoroutine(birdReset());

	}
    }

    IEnumerator birdReset()
    {

	yield return new WaitForSeconds(birdRespawn);

	transform.position = birdSpawn.position;
    }



}
