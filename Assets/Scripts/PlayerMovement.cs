using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{

    public Animator anim;

    public CharacterController2D controller;

    public float runSpeed = 40f;

    public float staticRunSpeed;

    float horizontalMove = 0f;

    public bool jump = false;    

    bool crouch = false;

    public scoreMind score;

    PlayerControls controls;

    public Joystick joystick;



    void Start()
    {

	idleAnim();

	staticRunSpeed = runSpeed;

	AdSensor.RetryCounter = AdSensor.RetryCounter + 1;

    }

    // Update is called once per frame
    void Update()
    {

	controls = new PlayerControls();

        horizontalMove = joystick.Horizontal * runSpeed;


	if (VirtualButton.rotate )
	{
	    	jump = true;

	    	jumpAnim();
	}

	if (Input.GetButtonDown("Crouch"))
	{
	    crouch = true;

	    crouchAnim();


	} else if (Input.GetButtonUp("Crouch"))
	{
	    crouch = false;

	    idleAnim();


	}

	if(joystick.Horizontal == 0)
	{

		if (jump == false)
		{

			if (crouch == false)
			{
			idleAnim();

			}

		}

	}else if (joystick.Horizontal != 0)
	{

		if (jump == false)
		{

			runAnim();


		}

	}

    }


    void FixedUpdate()
    {
        // Move the player
	controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
	jump = false;
    }


    public void runAnim()
    {
	anim.SetBool("isRun", true);
	anim.SetBool("isIdle", false);
	anim.SetBool("isCrouch", false);
	anim.SetBool("isJump", false);
	anim.SetBool("isHurt", false);

    }

    void jumpAnim()
    {
	anim.SetBool("isRun", false);
	anim.SetBool("isIdle", false);
	anim.SetBool("isCrouch", false);
	anim.SetBool("isJump", true);
	anim.SetBool("isHurt", false);

    }

    void crouchAnim()
    {

	anim.SetBool("isRun", false);
	anim.SetBool("isIdle", false);
	anim.SetBool("isCrouch", true);
	anim.SetBool("isJump", false);
	anim.SetBool("isHurt", false);

    }

    void idleAnim()
    {

	anim.SetBool("isRun", false);
	anim.SetBool("isIdle", true);
	anim.SetBool("isCrouch", false);
	anim.SetBool("isJump", false);
	anim.SetBool("isHurt", false);

    }

    public void hurtAnim()
    {

	anim.SetBool("isRun", false);
	anim.SetBool("isIdle", false);
	anim.SetBool("isCrouch", false);
	anim.SetBool("isJump", false);
	anim.SetBool("isHurt", true);

    }

    public void WalrusJump()
    {

	controller.walrusJump();

    }

    public void Jump()
    {

	jump = !jump;

	jumpAnim();

    }

    public void Crouch()
    {

	    crouch = !crouch;

	    crouchAnim();

    }


}
