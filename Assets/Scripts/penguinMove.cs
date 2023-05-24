using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class penguinMove : MonoBehaviour
{

    public Transform jumpPos;

    public Transform spawn;

    public Rigidbody2D penguinRB;

    public bool isGrounded;

    public float PenguinSpeed;
    public float PenguinJump;
 
    public Animator penguinAnim;

    public float penguinRespawnTime;

    public float distance; 

    private float respawnSpeed = 900;

    private bool isStarting;

    int i;

    // Start is called before the first frame update
    void Start()
    {
        isGrounded = false;

	isStarting = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

	distance = Vector3.Distance(transform.position, jumpPos.position);

        if(isGrounded)
	{
	    penguinRB.AddForce(new Vector2(PenguinSpeed, 0f));

	    isStarting = false;
	}

	if(distance <= 6.0f)
	{

	    penguinRB.AddForce(new Vector2(0f, PenguinJump));

	    PenguinJumpSFX();

	    penguinAnim.SetBool("penguinWalk", false);
	    penguinAnim.SetBool("penguinSlide", true);

	}

	if(distance >= 9f)
	{

	    isGrounded = false;

	    i = i + 1;

	}


	if(distance >= 100f)
	{
		if(!isStarting)
		{

		    StartCoroutine(penguinSpawn());
		}
	}

    }


    private void OnCollisionEnter2D(Collision2D col)
    {
	if(col.gameObject.tag == "BearL")
	{
	    AudioLibrary.PengiunSource.Play();

	    penguinRB.AddForce(new Vector2(-100f, 400f));

	    penguinAnim.SetBool("penguinWalk", false);
	    penguinAnim.SetBool("penguinSlide", true);

	} else if(col.gameObject.tag == "BearR")
	{
	    penguinRB.AddForce(new Vector2(-100f, 400f));

	    penguinAnim.SetBool("penguinWalk", false);
	    penguinAnim.SetBool("penguinSlide", true);

	} else if(col.gameObject.tag == "platform")
	{
	    isGrounded = true;

	    penguinAnim.SetBool("penguinWalk", true);
	    penguinAnim.SetBool("penguinSlide", false);

	} 
    }


    IEnumerator penguinSpawn()
    {	

		isGrounded = true;

		yield return new WaitForSeconds(penguinRespawnTime);

transform.position = Vector3.Lerp(transform.position, spawn.position, respawnSpeed);

		yield return new WaitForSeconds(1);

		transform.position = transform.position;

		isStarting = true;


	    penguinAnim.SetBool("penguinWalk", true);
	    penguinAnim.SetBool("penguinSlide", false);

    }

     public void PenguinJumpSFX()
     {
	if(i >= 1)
	{
		AudioLibrary.JumpingSource.Play();

		i = i - i;
	}


     }
    
}
