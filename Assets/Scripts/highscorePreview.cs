using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class highscorePreview : MonoBehaviour, IDataPersistence
{
	public TextMeshProUGUI score;

	public static int Highscore;

	public GameObject CostumeAcquired1;
	public GameObject CostumeAcquired2;
	public GameObject CostumeAcquired3;
	public GameObject CostumeAcquired4;
	public GameObject CostumeAcquired5;
	public GameObject CostumeAcquired6;
	public GameObject CostumeAcquired7;
	public GameObject CostumeAcquired8;
	public GameObject CostumeAcquired9;
	public GameObject CostumeAcquired10;
	public GameObject CostumeAcquired11;
	public GameObject CostumeAcquired12;

	public buyandequip buy;

	bool[] skippedNotification = new bool[12] { false, false, false, false, false, false, false, false, false, false, false, false };


	// Update is called once per frame
	void Update()
	{
		score.text = ("" + Highscore);


		if (playerHealth.playerDeadHighscore)
		{
			if (scoreMind.Score > Highscore)
			{
				Highscore = scoreMind.Score;
			}

			if (scoreMind.Score >= 500)
			{
				CostumeAcquired1.SetActive(true);

				buy.costume1Purchased = 1;
			}
			else if (scoreMind.Score >= 1000)
			{
				CostumeAcquired2.SetActive(true);

				buy.costume2Purchased = 1;

			}
			else if (scoreMind.Score >= 2000)
			{
				CostumeAcquired3.SetActive(true);

				buy.costume3Purchased = 1;

			}
			else if (scoreMind.Score >= 3000)
			{

				CostumeAcquired4.SetActive(true);

				buy.costume4Purchased = 1;

			}
			else if (scoreMind.Score >= 4000)
			{
				CostumeAcquired5.SetActive(true);

				buy.costume5Purchased = 1;
			}
			else if (scoreMind.Score >= 4000)
			{
				CostumeAcquired6.SetActive(true);

				buy.costume6Purchased = 1;
			}
			else if (scoreMind.Score >= 5000)
			{
				CostumeAcquired7.SetActive(true);

				buy.costume7Purchased = 1;
			}
			else if (scoreMind.Score >= 6000)
			{
				CostumeAcquired8.SetActive(true);

				buy.costume8Purchased = 1;
			}
			else if (scoreMind.Score >= 7000)
			{
				CostumeAcquired9.SetActive(true);

				buy.costume9Purchased = 1;
			}
			else if (scoreMind.Score >= 8000)
			{
				CostumeAcquired10.SetActive(true);

				buy.costume10Purchased = 1;
			}
			else if (scoreMind.Score >= 9000)
			{
				CostumeAcquired11.SetActive(true);

				buy.costume11Purchased = 1;
			}
			else if (scoreMind.Score >= 10000)
			{
				CostumeAcquired12.SetActive(true);

				buy.costume12Purchased = 1;
			}
		}
	}

	public void LoadData(GameData data)
	{

		highscorePreview.Highscore = data.numberForSaving;

		if (scoreMind.Score >= 500 || scoreMind.Score < 1000)
		{

			skippedNotification[0] = true;
		}
		else if (scoreMind.Score >= 1000 || scoreMind.Score < 2000)
		{

			skippedNotification[1] = true;

		}
		else if (scoreMind.Score >= 2000 || scoreMind.Score < 3000)
		{

			skippedNotification[2] = true;

		}
		else if (scoreMind.Score >= 3000 || scoreMind.Score < 4000)
		{

			skippedNotification[3] = true;

		}
		else if (scoreMind.Score >= 4000 || scoreMind.Score < 5000)
		{

			skippedNotification[4] = true;

		}
		else if (scoreMind.Score >= 4000 || scoreMind.Score < 5000)
		{

			skippedNotification[5] = true;

		}
		else if (scoreMind.Score >= 5000 || scoreMind.Score < 6000)
		{

			skippedNotification[6] = true;

		}
		else if (scoreMind.Score >= 6000 || scoreMind.Score < 7000)
		{

			skippedNotification[7] = true;

		}
		else if (scoreMind.Score >= 7000 || scoreMind.Score < 8000)
		{

			skippedNotification[8] = true;

		}
		else if (scoreMind.Score >= 8000 || scoreMind.Score < 9000)
		{

			skippedNotification[9] = true;

		}
		else if (scoreMind.Score >= 9000 || scoreMind.Score < 10000)
		{

			skippedNotification[10] = true;

		}
		else if (scoreMind.Score >= 10000)
		{

			skippedNotification[11] = true;

		}

	}

	public void SaveData(ref GameData data)
	{

		data.numberForSaving = highscorePreview.Highscore;

	}
}
