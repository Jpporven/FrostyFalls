using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class deathMenu : MonoBehaviour
{

    public GameObject playerButtons;

    public GameObject player;

    public GameObject playerSpawn;

    public GameObject backdrop;

    public GameObject menu;

    public GameObject sceneTransitionRight;

    public GameObject sceneTransitionRightPos;

    public GameObject sceneTransitionLeft;

    public GameObject sceneIntroTransitionRight;

    public GameObject sceneIntroTransitionLeft;

    public GameObject sceneIntroTransitionImage;

    public GameObject sceneOutroTransitionImage;


    public Transform TransitionStartPos;

    public Transform TransitionEndPos;


    public bool exit;    

    public bool restart;    

    public bool menuOn;

    public bool buttonInCam;

    
    public float exitDelayTime;

    public float transitionDistance;

    public float introTransitionDistance;

    public float ExitDelay;

    public float RestartDelay;
  

    public playerHealth health;

    public platformMind platform1;

    public platformMind platform2;

    public platformMind platform3;

    public scoreMind score;

    void Start()
    {

	sceneTransitionRight.SetActive(false);

	sceneTransitionLeft.SetActive(false);

	sceneIntroTransitionRight.SetActive(true);

	sceneIntroTransitionLeft.SetActive(true);

	sceneIntroTransitionImage.SetActive(true);

	sceneOutroTransitionImage.SetActive(false);

	playerButtons.SetActive(true);

	restart = false;

	restart = false;

    }

    public void Awake()
    {

	menuOn = true;

	platform1.isContinuing = true;
	platform2.isContinuing = true;
	platform3.isContinuing = true;

    }

    public void Update()
    {

	if(transitionDistance <= 0.009f)
	{
		if(exit)
		{
			SceneManager.LoadScene("MainMenu");
		}

		if(restart)
		{
			SceneManager.LoadScene("SampleScene");
		}

	}

	if(introTransitionDistance <= 0.009f)
	{

		sceneIntroTransitionRight.SetActive(false);

		sceneIntroTransitionLeft.SetActive(false);

		sceneIntroTransitionImage.SetActive(false);


	}

	transitionDistance = Vector3.Distance(TransitionStartPos.position, TransitionEndPos.position);

	introTransitionDistance = Vector3.Distance(sceneIntroTransitionRight.transform.position, sceneTransitionRightPos.transform.position);

    }

    public void Restart()
    {
	AudioLibrary.OptionsSFXSource.Play();

	Time.timeScale = 1f;

	menuOn = false;

	restart = true;

	score.Reset();

	sceneTransitionRight.SetActive(true);

	sceneTransitionLeft.SetActive(true);

	sceneOutroTransitionImage.SetActive(true);
    }

    public void Exit()
    {
	AudioLibrary.OptionsSFXSource.Play();

	AudioLibrary.PengiunSource.Stop();
	AudioLibrary.BearRoarSource.Stop();
	AudioLibrary.CandySource.Stop();
	AudioLibrary.ultraCandySource.Stop();
	AudioLibrary.LandingSource.Stop();
	AudioLibrary.JumpingSource.Stop();
	AudioLibrary.LandingSource.Stop();
	AudioLibrary.IceBreakSource.Stop();


	Time.timeScale = 1f;

	exit = true;	

	restart = false;

	score.Reset();

	sceneTransitionRight.SetActive(true);

	sceneTransitionLeft.SetActive(true);

	sceneOutroTransitionImage.SetActive(true);
    }

}
