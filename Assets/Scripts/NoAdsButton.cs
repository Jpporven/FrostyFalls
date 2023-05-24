using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoAdsButton : MonoBehaviour, IDataPersistence
{

	public GameObject activeButton;

	public static int noAd = 1;


	public static void NoAds()
	{

		noAd = 0;
	}

	public void NoAdsFAILED()
	{

		noAd = 1;
	}

	void Update()
	{

		if (noAd == 0)
		{
			if (!AdSensor.adsOn)
			{
				activeButton.SetActive(false);
			}
		}
		if (noAd == 1)
		{
			activeButton.SetActive(true);
		}

	}


	public void LoadData(GameData data)
	{
		if (data.NoAds == 0)
		{
			AdSensor.adsOn = false;
		}

		NoAdsButton.noAd = data.NoAds;

	}

	public void SaveData(ref GameData data)
	{

		data.NoAds = NoAdsButton.noAd;

	}
}
