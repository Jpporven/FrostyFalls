using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class creditsEnd : MonoBehaviour
{

    public Animator anim;

    public int transitionDelay;

    public GameObject transOut;

    void Start()
    {

	StartCoroutine(waitForCredits());

    }


    // Update is called once per frame
    void Update()
    {
        if(anim.GetBool("isCredits"))
	{
		StartCoroutine(changeScene());

		transOut.SetActive(true);
	}
    }

    IEnumerator changeScene(){

	yield return new WaitForSeconds(transitionDelay);

		SceneManager.LoadScene("MainMenu");

    }

    IEnumerator waitForCredits(){

	yield return new WaitForSeconds(34f / 0.3f);

		anim.SetBool("isCredits", true);
    }
    
}
