using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathZone : MonoBehaviour
{

    public hurtPlayer hurt;

    public bearTame tameL;

    public bearTame tameR;

    public SpriteRenderer BearRSprite;

    public SpriteRenderer BearLSprite;


    public GameObject bearL;

    public GameObject bearR;


    public float bearRRespawn;

    public float bearLRespawn;

    bool bearLIsOut;
    bool bearRIsOut;



    private void OnTriggerEnter2D(Collider2D coll)
    {
	if (coll.gameObject.tag == "Player")
	{
		hurt.Damage();

	}
	
	else if (coll.gameObject.tag == "BearR")
	{

		StartCoroutine(BearRRespawn());

	}
	else if (coll.gameObject.tag == "BearL")
	{

		StartCoroutine(BearLRespawn());
	}

    }

    IEnumerator BearRRespawn()
    {

	BearRSprite.enabled = false;

	yield return new WaitForSeconds(bearRRespawn);

	tameR.Respawn();

	BearRSprite.enabled = true;

    }

    IEnumerator BearLRespawn()
    {

	BearLSprite.enabled = false;

	yield return new WaitForSeconds(bearLRespawn);

	tameL.Respawn();

	BearLSprite.enabled = true;
    }



}
