using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMind : MonoBehaviour
{

    public int maxPlatformHealth;
    public int minPlatformHealth = 1;
    public int platformHealth;
    public float timeToBreak;

    public float platformRespawnTime;
    
    public SpriteRenderer newPlatform;
    public SpriteRenderer brokenPlatform;

    public GameObject iceBreak;

    public BoxCollider2D boxCollider;

    public penguinMove penguinL;

    public penguinMove penguinR;

    public CharacterController2D controller;

    public bool isContinuing;

    public bool isBroken;

    


    private void OnCollisionEnter2D(Collision2D col)
    {

	if (col.gameObject.tag == "Player")
	{

		platformHealth = platformHealth - 1;

		AudioLibrary.LandingSource.Play();

		if(platformHealth <= 0)
		{

			AudioLibrary.IceBreakSource.Play();

		}

		controller.platformEffect();

	}

	if (col.gameObject.tag == "penguin")
	{

		penguinR.isGrounded = true;
		penguinL.isGrounded = true;

		platformHealth = platformHealth - 1;

		AudioLibrary.LandingSource.Play();

	}
	if (col.gameObject.tag == "BearR")
	{

		AudioLibrary.BearLandingSource.Play();


	}
	if (col.gameObject.tag == "BearL")
	{

		AudioLibrary.BearLandingSource.Play();

	}


    }

    void Start()
    {

	maxPlatformHealth = platformHealth;

	isContinuing = false;

    }

    void Update()
    {

	if(isBroken)
	{

		brokenPlatform.enabled = false;

		newPlatform.enabled = false;

	}

	if (platformHealth == 1)
	{

		if (!isContinuing)
		{
		    brokenPlatform.enabled = true;
		    newPlatform.enabled = false;

		    StartCoroutine(platformBrokenReset());
		}

    	}

	if (platformHealth <= 0)
	{
		if (!isContinuing)
		{
			StartCoroutine(platformReset());

			isBroken = true;

			iceBreak.SetActive(true);

		}
	}


    }

    IEnumerator platformReset()
    {

		yield return new WaitForSeconds(0.1f);

	boxCollider.enabled = false;
	
		yield return new WaitForSeconds(platformRespawnTime);

	iceBreak.SetActive(false);

	newPlatform.enabled = true;

	boxCollider.enabled = true;

	platformHealth =  maxPlatformHealth;
	
	isBroken = false;




    }

    IEnumerator platformBrokenReset()
    {

		yield return new WaitForSeconds(timeToBreak);


	platformHealth = platformHealth - 1;

		yield return new WaitForSeconds(2.5f);

	platformHealth =  maxPlatformHealth;


    }

    void PlatformReset()
    {

	isContinuing = false;

	platformHealth =  maxPlatformHealth;

	iceBreak.SetActive(false);

	brokenPlatform.enabled = false;

	newPlatform.enabled = true;

	boxCollider.enabled = true;

    }


}
