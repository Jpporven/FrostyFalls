using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{

    public float Health;
    
    public float MaxHealth;

    public float penguinDistanceR;

    public float penguinDistanceL;

    public float penguinDamage;

    public float penguinAttackRange;

    public float OutOfBoundsRange;

    public bool isUltra;
 
    public bool isCandy;

    int i;

    
    public bool playerDead;
    public static bool playerDeadHighscore;


    public Transform penguinL;

    public Transform penguinR;


    public GameObject deathMenu;

    public GameObject OutOfBoundsScreen;


    public pauseButton pause;

    public PlayerMovement player;

    public hurtPlayer hailDamage;

    public deathMenu Menu;

    public scoreMind score;


    public SpriteRenderer playerSprite;


    string Shop;


    // Start is called before the first frame update
    void Start()
    {

	MusicControl.inGame = true;
	MusicControl.isPlaying = true;

	AdSensor.RetryCounter = AdSensor.RetryCounter + 1;

	PlayerPrefs.SetInt(Shop, 0);

	playerDeadHighscore = false;

	playerDead = false;

	deathMenu.SetActive(false);

	Time.timeScale = 1f;

	MaxHealth = Health;

	score.gamePlaying = true;
    }

    // Update is called once per frame
    void Update()
    {
	MusicControl.MenuMusic.Stop();

	if(Menu.exit)
	{

	    Time.timeScale = 1f;

	}

	penguinDistanceR = Vector3.Distance(transform.position, penguinR.position);

	penguinDistanceL = Vector3.Distance(transform.position, penguinL.position);

	if(transform.position.y >= OutOfBoundsRange)
	{

	    OutOfBoundsScreen.SetActive(true);

	}

	if(transform.position.y <= OutOfBoundsRange)
	{

	    OutOfBoundsScreen.SetActive(false);

	}

        if (Health <= 0f)
	{

	    playerDead = true;

	    Die();
	    pause.PauseButton.interactable = false;

	}

	if (penguinDistanceL <= penguinAttackRange)
	{
		PenguinSFX();

		AudioLibrary.PengiunSource.Play();

		Health = Health - penguinDamage;

		player.jump = true;

		playerSprite.color = Color.red;


		StartCoroutine(colorReset());

	}
	if (penguinDistanceR <= penguinAttackRange)
	{

		i = i + 1;

		Health = Health - penguinDamage;

		player.jump = true;

		playerSprite.color = Color.red;


		StartCoroutine(colorReset());

	}
	if (!Menu.menuOn)
	{

		deathMenu.SetActive(false);

	}

	if(isUltra)
	{
	   AudioLibrary.ultraCandySource.Play();
		
 	   score.ultraCandyScore();

	   isUltra = !isUltra;
	}

	if(isCandy)
	{
	   AudioLibrary.CandySource.Play();
		
 	   score.candyScore();

	   isCandy = !isCandy;
	}
    }

    

    public void OnTriggerEnter2D(Collider2D col)
    {

	if (col.gameObject.tag == "hail")
	{
		
 	   hailDamage.Damage();

	}

	if (col.gameObject.tag == "candy")
	{

	   isCandy = true;

	}

	if (col.gameObject.tag == "ultraCandy")
	{

	   isUltra = true;
	   

	}

	if (col.gameObject.tag == "Bird")
	{

			Health -= 1;


	}
	}

    public void OnCollisionEnter2D(Collision2D col)
    {

	if (col.gameObject.tag == "walrus")
	{	  
		AudioLibrary.walrusJumpingSource.Play();

		player.WalrusJump();	

	}
    }


    public void Die()
    {
	playerDeadHighscore = true;

	deathMenu.SetActive(true);

	Menu.menuOn = true;

	Time.timeScale = 0f;

	score.gamePlaying = false;

    }

    IEnumerator colorReset()
    {

	yield return new WaitForSeconds(0.5f);

	playerSprite.color = Color.white;

    }

     public void PenguinSFX()
     {
	if(i >= 1)
	{
		AudioLibrary.BearRoarSource.Play();

		i = i - i;
	}


    }

}
