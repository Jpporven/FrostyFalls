using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauseButton : MonoBehaviour
{

public deathMenu menu;

public GameObject pauseMenu;

public GameObject pauseSprite;

public GameObject playSprite;


public Button PauseButton;

public playerHealth health;


public bool paused = false;

	public void buttonPause()
	{
			AudioLibrary.BackButtonSFXSource.Play();

		if(!paused)
		{
			AudioLibrary.BackButtonSFXSource.pitch = 0.3f;

			health.playerDead = true;

			menu.menuOn = true;

			pauseMenu.SetActive(true);
			pauseSprite.SetActive(false);
			playSprite.SetActive(true);

			

			Time.timeScale = 0f;

			paused = true;


		}else if (paused)
		{

			AudioLibrary.BackButtonSFXSource.pitch = 0.4f;
	
			health.playerDead = false;

			menu.menuOn = false;

			pauseMenu.SetActive(false);
			playSprite.SetActive(false);
			pauseSprite.SetActive(true);

			StartCoroutine(unPauseSpeed());

			paused = false;

		}
	}

	IEnumerator unPauseSpeed()
	{

		Time.timeScale = 0.5f;

		yield return new WaitForSeconds(1);

		Time.timeScale = 1f;	

	}

	IEnumerator pauseButtonInteractivityReset()
	{
		
		PauseButton.interactable = !PauseButton.interactable;

		yield return new WaitForSeconds(1);

		PauseButton.interactable = !PauseButton.interactable;
	}
}
