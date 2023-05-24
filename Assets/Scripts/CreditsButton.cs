using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsButton : MonoBehaviour
{

    public GameObject CreditsTransition;
    public GameObject Tutorial;
    public GameObject TutorialScreen1;
    public GameObject TutorialScreen2;


    void Start()
    {
	CreditsTransition.SetActive(false);
    }

    void Update()
    {

		Scene currentScene = SceneManager.GetActiveScene ();
 
         	string sceneName = currentScene.name;
 
         if (sceneName == "Credits") 
         {
             	CreditsTransition.SetActive(false);

         }

    }

    public void Creditsbutton()
    {

	optionsMenuMove.OptionsMenuValue = 0;
	CreditsTransition.SetActive(true);

	StartCoroutine(loadCredits());

    }

    public void Tutorialbutton()
    {
        Tutorial.SetActive(true);
        TutorialScreen1.SetActive(true);
        TutorialScreen2.SetActive(true);
    }


    IEnumerator loadCredits()
    {

	yield return new WaitForSeconds(2.5f);

	SceneManager.LoadScene("Credits");
	

    }
}
