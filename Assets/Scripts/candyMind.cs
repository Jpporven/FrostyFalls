using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candyMind : MonoBehaviour
{
    public GameObject candy;

    public GameObject candySparkle;
    public GameObject candyBreak;

    public SpriteRenderer candySprite;

    Vector3 newScale = new Vector3(0, 0, 0);

    float scaleSpeed = 0.5f;

    private scoreMind score;
    
    public bool ultraCandy;

    private GameObject scoreboard;


    // Start is called before the first frame update
    void Start()
    {
	scoreboard = GameObject.FindWithTag("ScoreBoard");

	score = scoreboard.GetComponent<scoreMind>();


        StartCoroutine(particleShutOff());

	transform.localScale = Vector3.Lerp (transform.localScale, newScale, scaleSpeed * Time.deltaTime);

	StartCoroutine(candyFade());
    }

    public void OnTriggerEnter2D(Collider2D col)
    {

	if (col.gameObject.tag == "Player")
	{
		candySprite.enabled = false;

		StartCoroutine(destroyCandy());

	}
    }

    IEnumerator particleShutOff()
    {
	candyBreak.SetActive(false);

	yield return new WaitForSeconds(0.5f);

	candySparkle.SetActive(false);
    }

    IEnumerator destroyCandy()
    {
	candyBreak.SetActive(true);

	yield return new WaitForSeconds(0.5f);

	Destroy(gameObject);;
    }

    IEnumerator candyFade()
    {
	yield return new WaitForSeconds(5);

		StartCoroutine(candyFlash());

	yield return new WaitForSeconds(2);


	Destroy(gameObject);;
    }

    IEnumerator candyFlash()
    {

	yield return new WaitForSeconds(0.1f);

	candySprite.color = new Color (0.25f, 0.25f, 0.25f, 0.25f);

	yield return new WaitForSeconds(0.1f);

	candySprite.color = new Color (1, 1, 1, 1);

	yield return new WaitForSeconds(0.1f);

	candySprite.color = new Color (0.25f, 0.25f, 0.25f, 0.25f);

	yield return new WaitForSeconds(0.1f);

	candySprite.color = new Color (1, 1, 1, 1);

	yield return new WaitForSeconds(0.1f);

	candySprite.color = new Color (0.25f, 0.25f, 0.25f, 0.25f);

	yield return new WaitForSeconds(0.1f);

	candySprite.color = new Color (1, 1, 1, 1);

	yield return new WaitForSeconds(0.1f);

	candySprite.color = new Color (0.25f, 0.25f, 0.25f, 0.25f);

	yield return new WaitForSeconds(0.1f);

	candySprite.color = new Color (1, 1, 1, 1);

	yield return new WaitForSeconds(0.1f);

	candySprite.color = new Color (0.25f, 0.25f, 0.25f, 0.25f);

	yield return new WaitForSeconds(0.1f);

	candySprite.color = new Color (1, 1, 1, 1);

	yield return new WaitForSeconds(0.1f);

	candySprite.color = new Color (0.25f, 0.25f, 0.25f, 0.25f);

	yield return new WaitForSeconds(0.1f);

	candySprite.color = new Color (1, 1, 1, 1);

	yield return new WaitForSeconds(0.1f);

	candySprite.color = new Color (0.25f, 0.25f, 0.25f, 0.25f);

	yield return new WaitForSeconds(0.1f);

	candySprite.color = new Color (1, 1, 1, 1);

	yield return new WaitForSeconds(0.1f);

	candySprite.color = new Color (0.25f, 0.25f, 0.25f, 0.25f);

	yield return new WaitForSeconds(0.1f);

	candySprite.color = new Color (1, 1, 1, 1);

    }
}
