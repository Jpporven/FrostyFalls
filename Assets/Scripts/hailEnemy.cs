using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hailEnemy : MonoBehaviour
{

    public GameObject hailBreak;

    public SpriteRenderer hailSprite;

    public float hailLifeTime; 

    // Start is called before the first frame update
    void Start()
    {
        hailBreak.SetActive(false);

	StartCoroutine(hailDeath());
    }

    public void OnTriggerEnter2D(Collider2D col)
    {

	if (col.gameObject.tag == "Player")
	{

		hailSprite.enabled = false;
		hailBreak.SetActive(true);

		StartCoroutine(hailDeath());

	}
	if (col.gameObject.tag == "platform")
	{

		hailSprite.enabled = false;
		hailBreak.SetActive(true);

		StartCoroutine(hailDeath());

	}

    }


    IEnumerator hailDeath()
    {

	yield return new WaitForSeconds(hailLifeTime);


	Destroy(gameObject);
    }
}
