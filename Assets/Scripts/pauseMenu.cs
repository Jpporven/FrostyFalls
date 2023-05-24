using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class pauseMenu : MonoBehaviour
{

    

    public deathMenu menu;

    public playerHealth health;

    public scoreMind score;


    public void restartButton()
    {
	Time.timeScale = 1f;
	AudioLibrary.OptionsSFXSource.Play();

	score.Reset();

	SceneManager.LoadScene("SampleScene");


    }

    public void exitButton()
    {
	Time.timeScale = 1f;

	AudioLibrary.OptionsSFXSource.Play();

	menu.Exit();

	health.Health = 0;

	this.gameObject.SetActive(false);


    }
}
