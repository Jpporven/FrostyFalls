using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class mainMenuController : MonoBehaviour, IDataPersistence
{
	public GameObject[] TutorialSlides;
	public GameObject SnowStorm;

    public GameObject shop;
    public GameObject start;
    public GameObject options;
    public GameObject back;

    public GameObject titleFadeIn;
    public GameObject titleFadeOut;

    public GameObject fadeInTransition;
    public GameObject fadeOutTransition;


    public Transform shopButton;
    public Transform startButton;
    public Transform optionsButton;
    public Transform backButton;

    public bool isOutOfCam;
    public bool isInCam;

    public bool shopButtonOn;
    public bool optionsButtonOn;
    public bool backButtonOn;

    public bool shopIsOn;
    public bool optionsIsOn;

    public Transform shopOutOfCam;
    public Transform shopInCam;

    public Transform startOutOfCam;
    public Transform startInCam;

    public Transform optionsOutOfCam;
    public Transform optionsInCam;

    public Transform backOutOfCam;
    public Transform backInCam;

    public float buttonSpeed;
    public float sceneTransTime;
    public float MainMenuButtonShutOffDelay;
    public float BackButtonShutOffDelay;
    public int PlayerSpeed;
	public int tutComplete;

	string PlayerMountainSpeed;
    string Shop;
    
    


    void Start()
    {
	Time.timeScale = 1f;

	PlayerPrefs.SetInt(PlayerMountainSpeed, 0);

	if(tutComplete == 0)
    {

	}

	isInCam = true;

	isOutOfCam = false;


	shopButtonOn = true;

	optionsButtonOn = true;

	SnowStorm.SetActive(false);

	fadeInTransition.SetActive(true);
	fadeOutTransition.SetActive(false);

	ScoreSensor.gamePaused = false;

    }

    void Update()
    {
	if(isOutOfCam)
	{
	   shopButtonOn = false;

	   optionsButtonOn = false;

	   backButtonOn = true;

	   back.SetActive(true);

	   SnowStorm.SetActive(false);



     	   startButton.position = Vector3.Lerp(startButton.position, startOutOfCam.position, buttonSpeed);

     	   shopButton.position = Vector3.Lerp(shopButton.position, shopOutOfCam.position, buttonSpeed);

     	   optionsButton.position = Vector3.Lerp(optionsButton.position, optionsOutOfCam.position, buttonSpeed);

     	   backButton.position = Vector3.Lerp(backButton.position, backInCam.position, buttonSpeed);

	   if(!shopIsOn)
	   {

		PlayerPrefs.SetInt(Shop, 0);

	   }
	}

	if(isInCam)
	{

	   PlayerPrefs.SetInt(Shop, 0);

	   PlayerPrefs.SetInt(PlayerMountainSpeed, 0);
	
	   shopButtonOn = true;

	   optionsButtonOn = true;

	   backButtonOn = false;

	   shopIsOn = false;

	   shop.SetActive(true);
	   start.SetActive(true);
	   options.SetActive(true);


	   startButton.position = Vector3.Lerp(startButton.position, startInCam.position, buttonSpeed);

	   shopButton.position = Vector3.Lerp(shopButton.position, shopInCam.position, buttonSpeed);

	   optionsButton.position = Vector3.Lerp(optionsButton.position, optionsInCam.position, buttonSpeed);

	   backButton.position = Vector3.Lerp(backButton.position, backOutOfCam.position, buttonSpeed);
	}

    }
    
    public void startButtonFunction()
    {

	AudioLibrary.OptionsSFXSource.Play();

	AudioLibrary.BackButtonSource.Stop();

	PlayerPrefs.SetInt(Shop, 0);

	Time.timeScale = 1f;


	SnowStorm.SetActive(true);

	titleFadeIn.SetActive(false);

	titleFadeOut.SetActive(true);

	fadeOutTransition.SetActive(true);


	backInCam.position = backOutOfCam.position;
	
	StartCoroutine(BackButtonShutOff());


	    isInCam = false;

	    isOutOfCam = true;

	    StartCoroutine(StartGame());
    }

    public void shopButtonFunction()
    {
	if(shopButtonOn)
	{
	AudioLibrary.BackButtonSource.Stop();
	AudioLibrary.OptionsSFXSource.Play();

	    PlayerPrefs.SetInt(Shop, 1);

	    shopIsOn = true;

	    isInCam = false;

	    isOutOfCam = true;
	}
    }

    public void optionsButtonFunction()
    {
	if(optionsButtonOn)
	{
	AudioLibrary.OptionsSFXSource.Play();

	    optionsIsOn = true;

	    isInCam = false;

	    isOutOfCam = true;

	    optionsMenuMove.OptionsMenuValue = 1;
	}

    }

    public void backButtonFunction()
    {
	if(backButtonOn)
	{
	    optionsMenuMove.OptionsMenuValue = 0;

	    AudioLibrary.BackButtonSFXSource.pitch = 0.5f;
	    AudioLibrary.BackButtonSFXSource.Play();
	    
	    shopIsOn = false;

	    optionsIsOn = false;

	    isInCam = true;

	    isOutOfCam = false;

	    StartCoroutine(BackButtonShutOff());
	}

    }

	public void TutorialMenu(int size)
	{
		AudioLibrary.BackButtonSFXSource.pitch = 1.5f;
		AudioLibrary.BackButtonSFXSource.Play();
		TutorialSlides[size].SetActive(false);
	}


	IEnumerator StartGame()
    {
	PlayerPrefs.SetInt(PlayerMountainSpeed, 1);

	isOutOfCam = true;

	isInCam = false;

	yield return new WaitForSeconds(sceneTransTime);

	SceneManager.LoadScene("SampleScene");
    }

    IEnumerator MainMenuButtonShutOff()
    {

	yield return new WaitForSeconds(MainMenuButtonShutOffDelay);

	shop.SetActive(false);
	start.SetActive(false);
	options.SetActive(false);

    }

    IEnumerator BackButtonShutOff()
    {
	AudioLibrary.BackButtonSource.Play();

	yield return new WaitForSeconds(0.3f);

	back.SetActive(true);

	backButtonOn = false;


    }


	public void LoadData(GameData data)
	{


	}

	public void SaveData(ref GameData data)
	{

	}

}

