using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introductionScreen : MonoBehaviour
{

    public buttonSetPos leftTransScreen;

    public buttonSetPos rightTransScreen;

    public buttonSetPos imageTransScreen;

    public buttonSetPos titleImage;

    
    public float introDelay;

    // Start is called before the first frame update
    void Start()
    {
        imageTransScreen.speed = 0f;

        rightTransScreen.speed = 0f;

        leftTransScreen.speed = 0f;

        titleImage.speed = 0f;


	StartCoroutine(introTransitionDelay());
    }

    IEnumerator introTransitionDelay()
    {

	yield return new WaitForSeconds(introDelay);

        imageTransScreen.speed = 0.0025f;

        rightTransScreen.speed = 0.0025f;

        leftTransScreen.speed = 0.0025f;

	yield return new WaitForSeconds(0.5f);

        titleImage.speed = 0.1f;
	
    }
}
