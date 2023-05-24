using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class scoreMind : MonoBehaviour
{

    public playerHealth health;

    public static int Score;

    public TextMeshProUGUI text;
    public TextMeshProUGUI BackText;

    public bool gamePlaying;

    public GameObject NewHighscore;

    highscorePreview highscore;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ScoreCounter");

	NewHighscore.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {


        text.text = ("" + Score);
	
        BackText.text = ("" + Score);

	if (!gamePlaying)
	{

	    Score = Score;

	}

	if(Score > highscorePreview.Highscore)
	{
	
		if(!gamePlaying)
		{
			NewHighscore.SetActive(true);
		}
	}

    }

    IEnumerator ScoreCounter()
    {

	while(true)
	{
	 yield return new WaitForSeconds(0.1f);
	 Score++;
	}

    }

    
    public void Reset()
    {

	Score = 0;


    }
    

    public void ultraCandyScore()
    {
	AudioLibrary.CandySource.Play();

	Score = Score + 50;

    }

    public void candyScore()
    {

	AudioLibrary.CandySource.Play();

	Score = Score + 100;

    }
}
