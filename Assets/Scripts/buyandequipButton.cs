using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyandequipButton : MonoBehaviour
{

	public costumeMenu menu;
	public buyandequip buy;

	public GameObject CostumeBUY1;
	public GameObject CostumeBUY2;
	public GameObject CostumeBUY3;
	public GameObject CostumeBUY4;
	public GameObject CostumeBUY5;
	public GameObject CostumeBUY6;
	public GameObject CostumeBUY7;
	public GameObject CostumeBUY8;
	public GameObject CostumeBUY9;
	public GameObject CostumeBUY10;
	public GameObject CostumeBUY11;
	public GameObject CostumeBUY12;

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


	public GameObject CostumeEQUIP;

	public bool equipOn;
	public bool LoadedData = true;

	public static bool AcquiredSkipped1;
	public static bool AcquiredSkipped2;
	public static bool AcquiredSkipped3;
	public static bool AcquiredSkipped4;
	public static bool AcquiredSkipped5;
	public static bool AcquiredSkipped6;
	public static bool AcquiredSkipped7;
	public static bool AcquiredSkipped8;
	public static bool AcquiredSkipped9;
	public static bool AcquiredSkipped10;
	public static bool AcquiredSkipped11;
	public static bool AcquiredSkipped12;

	void Start()
	{

		AcquiredSkipped1 = false;
		AcquiredSkipped2 = false;
		AcquiredSkipped3 = false;
		AcquiredSkipped4 = false;
		AcquiredSkipped5 = false;
		AcquiredSkipped6 = false;
		AcquiredSkipped7 = false;
		AcquiredSkipped8 = false;
		AcquiredSkipped9 = false;
		AcquiredSkipped10 = false;
		AcquiredSkipped11 = false;
		AcquiredSkipped12 = false;


	}

	// Update is called once per frame
	void Update()
	{
		//costume 1
		if (menu.selectedCostume == 0)
		{
			if (buy.costume1Purchased == 1)
			{
				if (LoadedData)
				{
					AcquiredSkipped1 = false;
				}

				CostumeEQUIP.SetActive(true);
				CostumeBUY1.SetActive(false);

				CostumeBUY2.SetActive(false);
				CostumeBUY3.SetActive(false);
				CostumeBUY4.SetActive(false);
				CostumeBUY5.SetActive(false);
				CostumeBUY6.SetActive(false);
				CostumeBUY7.SetActive(false);
				CostumeBUY8.SetActive(false);
				CostumeBUY9.SetActive(false);
				CostumeBUY10.SetActive(false);
				CostumeBUY11.SetActive(false);
				CostumeBUY12.SetActive(false);

				equipOn = true;

				if (CostumeAcquired1 != null || !AcquiredSkipped1)
				{

					CostumeAcquired1.SetActive(true);

				}

			}
			else
			{

				CostumeEQUIP.SetActive(false);
				CostumeBUY1.SetActive(true);

				CostumeBUY2.SetActive(false);
				CostumeBUY3.SetActive(false);
				CostumeBUY4.SetActive(false);
				CostumeBUY5.SetActive(false);
				CostumeBUY6.SetActive(false);
				CostumeBUY7.SetActive(false);
				CostumeBUY8.SetActive(false);
				CostumeBUY9.SetActive(false);
				CostumeBUY10.SetActive(false);
				CostumeBUY11.SetActive(false);
				CostumeBUY12.SetActive(false);

				equipOn = false;


			}
		}
		//costume 2
		else if (menu.selectedCostume == 1)
		{

			if (buy.costume2Purchased == 1)
			{
				if (LoadedData)
				{
					AcquiredSkipped2 = false;
				}

				CostumeEQUIP.SetActive(true);
				CostumeBUY2.SetActive(false);

				CostumeBUY1.SetActive(false);
				CostumeBUY3.SetActive(false);
				CostumeBUY4.SetActive(false);
				CostumeBUY5.SetActive(false);
				CostumeBUY6.SetActive(false);
				CostumeBUY7.SetActive(false);
				CostumeBUY8.SetActive(false);
				CostumeBUY9.SetActive(false);
				CostumeBUY10.SetActive(false);
				CostumeBUY11.SetActive(false);
				CostumeBUY12.SetActive(false);

				equipOn = true;

				if (CostumeAcquired2 != null || !AcquiredSkipped2)
				{

					CostumeAcquired2.SetActive(true);

				}

			}
			else
			{
				if (CostumeAcquired2 != null)
				{
					CostumeAcquired2.SetActive(false);
				}

				CostumeEQUIP.SetActive(false);
				CostumeBUY2.SetActive(true);

				CostumeBUY1.SetActive(false);
				CostumeBUY3.SetActive(false);
				CostumeBUY4.SetActive(false);
				CostumeBUY5.SetActive(false);
				CostumeBUY6.SetActive(false);
				CostumeBUY7.SetActive(false);
				CostumeBUY8.SetActive(false);
				CostumeBUY9.SetActive(false);
				CostumeBUY10.SetActive(false);
				CostumeBUY11.SetActive(false);
				CostumeBUY12.SetActive(false);

				equipOn = false;

			}
		}
		//costume 3
		else if (menu.selectedCostume == 2)
		{

			if (buy.costume3Purchased == 1)
			{
				if (LoadedData)
				{
					AcquiredSkipped3 = false;
				}


				CostumeEQUIP.SetActive(true);
				CostumeBUY3.SetActive(false);

				CostumeBUY1.SetActive(false);
				CostumeBUY2.SetActive(false);
				CostumeBUY4.SetActive(false);
				CostumeBUY5.SetActive(false);
				CostumeBUY6.SetActive(false);
				CostumeBUY7.SetActive(false);
				CostumeBUY8.SetActive(false);
				CostumeBUY9.SetActive(false);
				CostumeBUY10.SetActive(false);
				CostumeBUY11.SetActive(false);
				CostumeBUY12.SetActive(false);


				equipOn = true;

				if (CostumeAcquired3 != null || !AcquiredSkipped3)
				{

					CostumeAcquired3.SetActive(true);

				}

			}
			else
			{
				if (CostumeAcquired3 != null)
				{
					CostumeAcquired3.SetActive(false);
				}

				CostumeEQUIP.SetActive(false);
				CostumeBUY3.SetActive(true);

				CostumeBUY1.SetActive(false);
				CostumeBUY2.SetActive(false);
				CostumeBUY4.SetActive(false);
				CostumeBUY5.SetActive(false);
				CostumeBUY6.SetActive(false);
				CostumeBUY7.SetActive(false);
				CostumeBUY8.SetActive(false);
				CostumeBUY9.SetActive(false);
				CostumeBUY10.SetActive(false);
				CostumeBUY11.SetActive(false);
				CostumeBUY12.SetActive(false);

				equipOn = false;



			}
		}
		//costume 4
		else if (menu.selectedCostume == 3)
		{

			if (buy.costume4Purchased == 1)
			{
				if (LoadedData)
				{
					AcquiredSkipped4 = false;
				}

				CostumeEQUIP.SetActive(true);
				CostumeBUY4.SetActive(false);

				CostumeBUY1.SetActive(false);
				CostumeBUY2.SetActive(false);
				CostumeBUY3.SetActive(false);
				CostumeBUY5.SetActive(false);
				CostumeBUY6.SetActive(false);
				CostumeBUY7.SetActive(false);
				CostumeBUY8.SetActive(false);
				CostumeBUY9.SetActive(false);
				CostumeBUY10.SetActive(false);
				CostumeBUY11.SetActive(false);
				CostumeBUY12.SetActive(false);

				equipOn = true;

				if (CostumeAcquired4 != null || !AcquiredSkipped4)
				{

					CostumeAcquired4.SetActive(true);

				}

			}
			else 
			{
				CostumeAcquired4.SetActive(false);

				CostumeEQUIP.SetActive(false);
				CostumeBUY4.SetActive(true);

				CostumeBUY1.SetActive(false);
				CostumeBUY2.SetActive(false);
				CostumeBUY3.SetActive(false);
				CostumeBUY5.SetActive(false);
				CostumeBUY6.SetActive(false);
				CostumeBUY7.SetActive(false);
				CostumeBUY8.SetActive(false);
				CostumeBUY9.SetActive(false);
				CostumeBUY10.SetActive(false);
				CostumeBUY11.SetActive(false);
				CostumeBUY12.SetActive(false);


				equipOn = false;

			}
		}
		//costume 5
		else if (menu.selectedCostume == 4)
		{

			if (buy.costume5Purchased == 1)
			{
				if (!AcquiredSkipped5)
				{

					CostumeAcquired5.SetActive(true);

				}

				CostumeEQUIP.SetActive(true);
				CostumeBUY5.SetActive(false);

				CostumeBUY1.SetActive(false);
				CostumeBUY2.SetActive(false);
				CostumeBUY3.SetActive(false);
				CostumeBUY4.SetActive(false);
				CostumeBUY6.SetActive(false);
				CostumeBUY7.SetActive(false);
				CostumeBUY8.SetActive(false);
				CostumeBUY9.SetActive(false);
				CostumeBUY10.SetActive(false);
				CostumeBUY11.SetActive(false);
				CostumeBUY12.SetActive(false);


				equipOn = true;

				if (CostumeAcquired5 != null || !AcquiredSkipped5)
				{

					CostumeAcquired5.SetActive(true);

				}

			}
			else
			{


				CostumeAcquired5.SetActive(false);

				CostumeEQUIP.SetActive(false);
				CostumeBUY5.SetActive(true);

				CostumeBUY1.SetActive(false);
				CostumeBUY2.SetActive(false);
				CostumeBUY3.SetActive(false);
				CostumeBUY4.SetActive(false);
				CostumeBUY6.SetActive(false);
				CostumeBUY7.SetActive(false);
				CostumeBUY8.SetActive(false);
				CostumeBUY9.SetActive(false);
				CostumeBUY10.SetActive(false);
				CostumeBUY11.SetActive(false);
				CostumeBUY12.SetActive(false);

				equipOn = false;

			}
		}
		//costume 6
		else if (menu.selectedCostume == 5)
		{

			if (buy.costume6Purchased == 1)
			{
				if (LoadedData)
				{
					AcquiredSkipped6 = false;
				}


				CostumeEQUIP.SetActive(true);
				CostumeBUY6.SetActive(false);

				CostumeBUY1.SetActive(false);
				CostumeBUY2.SetActive(false);
				CostumeBUY3.SetActive(false);
				CostumeBUY4.SetActive(false);
				CostumeBUY5.SetActive(false);
				CostumeBUY7.SetActive(false);
				CostumeBUY8.SetActive(false);
				CostumeBUY9.SetActive(false);
				CostumeBUY10.SetActive(false);
				CostumeBUY11.SetActive(false);
				CostumeBUY12.SetActive(false);


				equipOn = true;

				if (CostumeAcquired6 != null || !AcquiredSkipped6)
				{

					CostumeAcquired6.SetActive(true);

				}

			}
			else
			{

				CostumeAcquired6.SetActive(false);

				CostumeEQUIP.SetActive(false);
				CostumeBUY6.SetActive(true);

				equipOn = false;

				CostumeBUY1.SetActive(false);
				CostumeBUY2.SetActive(false);
				CostumeBUY3.SetActive(false);
				CostumeBUY4.SetActive(false);
				CostumeBUY5.SetActive(false);
				CostumeBUY7.SetActive(false);
				CostumeBUY8.SetActive(false);
				CostumeBUY9.SetActive(false);
				CostumeBUY10.SetActive(false);
				CostumeBUY11.SetActive(false);
				CostumeBUY12.SetActive(false);


			}
		}
		//costume 7
		else if (menu.selectedCostume == 6)
		{

			if (buy.costume7Purchased == 1)
			{
				if (LoadedData)
				{
					AcquiredSkipped7 = false;
				}


				CostumeEQUIP.SetActive(true);

				CostumeBUY1.SetActive(false);
				CostumeBUY2.SetActive(false);
				CostumeBUY3.SetActive(false);
				CostumeBUY4.SetActive(false);
				CostumeBUY5.SetActive(false);
				CostumeBUY6.SetActive(false);
				CostumeBUY7.SetActive(false);
				CostumeBUY8.SetActive(false);
				CostumeBUY9.SetActive(false);
				CostumeBUY10.SetActive(false);
				CostumeBUY11.SetActive(false);
				CostumeBUY12.SetActive(false);

				equipOn = true;

				if (CostumeAcquired7 != null || !AcquiredSkipped7)
				{

					CostumeAcquired7.SetActive(true);

				}

			}
			else
			{

				CostumeAcquired7.SetActive(false);

				CostumeEQUIP.SetActive(false);

				CostumeBUY7.SetActive(true);

				CostumeBUY1.SetActive(false);
				CostumeBUY2.SetActive(false);
				CostumeBUY3.SetActive(false);
				CostumeBUY4.SetActive(false);
				CostumeBUY5.SetActive(false);
				CostumeBUY6.SetActive(false);
				CostumeBUY8.SetActive(false);
				CostumeBUY9.SetActive(false);
				CostumeBUY10.SetActive(false);
				CostumeBUY11.SetActive(false);
				CostumeBUY12.SetActive(false);

				equipOn = false;

			}
		}
		//costume 8
		else if (menu.selectedCostume == 7)
		{

			if (buy.costume8Purchased == 1)
			{
				if (LoadedData)
				{
					AcquiredSkipped8 = false;
				}


				CostumeEQUIP.SetActive(true);

				CostumeBUY1.SetActive(false);
				CostumeBUY2.SetActive(false);
				CostumeBUY3.SetActive(false);
				CostumeBUY4.SetActive(false);
				CostumeBUY5.SetActive(false);
				CostumeBUY6.SetActive(false);
				CostumeBUY7.SetActive(false);
				CostumeBUY8.SetActive(false);
				CostumeBUY9.SetActive(false);
				CostumeBUY10.SetActive(false);
				CostumeBUY11.SetActive(false);
				CostumeBUY12.SetActive(false);

				equipOn = true;

				if (CostumeAcquired8 != null || !AcquiredSkipped8)
				{

					CostumeAcquired8.SetActive(true);

				}

			}
			else
			{

				CostumeAcquired8.SetActive(false);

				CostumeEQUIP.SetActive(false);

				CostumeBUY8.SetActive(true);

				CostumeBUY1.SetActive(false);
				CostumeBUY2.SetActive(false);
				CostumeBUY3.SetActive(false);
				CostumeBUY4.SetActive(false);
				CostumeBUY5.SetActive(false);
				CostumeBUY6.SetActive(false);
				CostumeBUY7.SetActive(false);
				CostumeBUY9.SetActive(false);
				CostumeBUY10.SetActive(false);
				CostumeBUY11.SetActive(false);
				CostumeBUY12.SetActive(false);

				equipOn = false;

			}
		}
		//costume 9
		else if (menu.selectedCostume == 8)
		{

			if (buy.costume9Purchased == 1)
			{
				if (LoadedData)
				{
					AcquiredSkipped9 = false;
				}


				CostumeEQUIP.SetActive(true);

				CostumeBUY1.SetActive(false);
				CostumeBUY2.SetActive(false);
				CostumeBUY3.SetActive(false);
				CostumeBUY4.SetActive(false);
				CostumeBUY5.SetActive(false);
				CostumeBUY6.SetActive(false);
				CostumeBUY7.SetActive(false);
				CostumeBUY8.SetActive(false);
				CostumeBUY9.SetActive(false);
				CostumeBUY10.SetActive(false);
				CostumeBUY11.SetActive(false);
				CostumeBUY12.SetActive(false);

				equipOn = true;

				if (CostumeAcquired9 != null || !AcquiredSkipped9)
				{

					CostumeAcquired9.SetActive(true);

				}

			}
			else
			{

				CostumeAcquired9.SetActive(false);

				CostumeEQUIP.SetActive(false);

				CostumeBUY9.SetActive(true);

				CostumeBUY1.SetActive(false);
				CostumeBUY2.SetActive(false);
				CostumeBUY3.SetActive(false);
				CostumeBUY4.SetActive(false);
				CostumeBUY5.SetActive(false);
				CostumeBUY6.SetActive(false);
				CostumeBUY7.SetActive(false);
				CostumeBUY8.SetActive(false);
				CostumeBUY10.SetActive(false);
				CostumeBUY11.SetActive(false);
				CostumeBUY12.SetActive(false);

				equipOn = false;

			}
		}
		//costume 10
		else if (menu.selectedCostume == 9)
		{

			if (buy.costume10Purchased == 1)
			{
				if (LoadedData)
				{
					AcquiredSkipped10 = false;
				}


				CostumeEQUIP.SetActive(true);

				CostumeBUY1.SetActive(false);
				CostumeBUY2.SetActive(false);
				CostumeBUY3.SetActive(false);
				CostumeBUY4.SetActive(false);
				CostumeBUY5.SetActive(false);
				CostumeBUY6.SetActive(false);
				CostumeBUY7.SetActive(false);
				CostumeBUY8.SetActive(false);
				CostumeBUY9.SetActive(false);
				CostumeBUY10.SetActive(false);
				CostumeBUY11.SetActive(false);
				CostumeBUY12.SetActive(false);

				equipOn = true;

				if (CostumeAcquired10 != null || !AcquiredSkipped10)
				{

					CostumeAcquired10.SetActive(true);

				}

			}
			else
			{
				CostumeAcquired10.SetActive(false);

				CostumeEQUIP.SetActive(false);

				CostumeBUY10.SetActive(true);

				CostumeBUY1.SetActive(false);
				CostumeBUY2.SetActive(false);
				CostumeBUY3.SetActive(false);
				CostumeBUY4.SetActive(false);
				CostumeBUY5.SetActive(false);
				CostumeBUY6.SetActive(false);
				CostumeBUY7.SetActive(false);
				CostumeBUY8.SetActive(false);
				CostumeBUY9.SetActive(false);
				CostumeBUY11.SetActive(false);
				CostumeBUY12.SetActive(false);

				equipOn = false;

			}
		}
		//costume 11
		else if (menu.selectedCostume == 10)
		{

			if (buy.costume11Purchased == 1)
			{
				if (LoadedData)
				{
					AcquiredSkipped11 = false;
				}

				CostumeEQUIP.SetActive(true);

				CostumeBUY1.SetActive(false);
				CostumeBUY2.SetActive(false);
				CostumeBUY3.SetActive(false);
				CostumeBUY4.SetActive(false);
				CostumeBUY5.SetActive(false);
				CostumeBUY6.SetActive(false);
				CostumeBUY7.SetActive(false);
				CostumeBUY8.SetActive(false);
				CostumeBUY9.SetActive(false);
				CostumeBUY10.SetActive(false);
				CostumeBUY11.SetActive(false);
				CostumeBUY12.SetActive(false);

				equipOn = true;

				if (CostumeAcquired11 != null || !AcquiredSkipped11)
				{

					CostumeAcquired11.SetActive(true);

				}

			}
			else
			{
				CostumeAcquired11.SetActive(false);

				CostumeEQUIP.SetActive(false);

				CostumeBUY11.SetActive(true);

				CostumeBUY1.SetActive(false);
				CostumeBUY2.SetActive(false);
				CostumeBUY3.SetActive(false);
				CostumeBUY4.SetActive(false);
				CostumeBUY5.SetActive(false);
				CostumeBUY6.SetActive(false);
				CostumeBUY7.SetActive(false);
				CostumeBUY8.SetActive(false);
				CostumeBUY9.SetActive(false);
				CostumeBUY10.SetActive(false);
				CostumeBUY12.SetActive(false);

				equipOn = false;

			}
		}
		//costume 12
		else if (menu.selectedCostume == 11)
		{


			if (buy.costume12Purchased == 1)
			{
				if (LoadedData)
				{
					AcquiredSkipped12 = false;
				}


				CostumeEQUIP.SetActive(true);

				CostumeBUY1.SetActive(false);
				CostumeBUY2.SetActive(false);
				CostumeBUY3.SetActive(false);
				CostumeBUY4.SetActive(false);
				CostumeBUY5.SetActive(false);
				CostumeBUY6.SetActive(false);
				CostumeBUY7.SetActive(false);
				CostumeBUY8.SetActive(false);
				CostumeBUY9.SetActive(false);
				CostumeBUY10.SetActive(false);
				CostumeBUY11.SetActive(false);
				CostumeBUY12.SetActive(false);


				equipOn = true;

				if (CostumeAcquired12 != null || !AcquiredSkipped12)
				{

					CostumeAcquired12.SetActive(true);

				}

			}
			else
			{

				CostumeAcquired12.SetActive(false);

				CostumeEQUIP.SetActive(false);

				CostumeBUY12.SetActive(true);

				CostumeBUY1.SetActive(false);
				CostumeBUY2.SetActive(false);
				CostumeBUY3.SetActive(false);
				CostumeBUY4.SetActive(false);
				CostumeBUY5.SetActive(false);
				CostumeBUY6.SetActive(false);
				CostumeBUY7.SetActive(false);
				CostumeBUY8.SetActive(false);
				CostumeBUY9.SetActive(false);
				CostumeBUY10.SetActive(false);
				CostumeBUY11.SetActive(false);

				equipOn = false;

			}
		}

	}

	public void BuyandEquipButton()
	{

		AudioLibrary.EquipSource.Play();

		if (menu.selectedCostume == 0)
		{
			buy.equipCostume1();

		}
		else if (menu.selectedCostume == 1)
		{
			buy.equipCostume2();

		}
		else if (menu.selectedCostume == 2)
		{
			buy.equipCostume3();

		}
		else if (menu.selectedCostume == 3)
		{
			buy.equipCostume4();

		}
		else if (menu.selectedCostume == 4)
		{
			buy.equipCostume5();

		}
		else if (menu.selectedCostume == 5)
		{
			buy.equipCostume6();

		}
		else if (menu.selectedCostume == 6)
		{
			buy.equipCostume7();

		}
		else if (menu.selectedCostume == 7)
		{
			buy.equipCostume8();

		}
		else if (menu.selectedCostume == 8)
		{
			buy.equipCostume9();

		}
		else if (menu.selectedCostume == 9)
		{
			buy.equipCostume10();

		}
		else if (menu.selectedCostume == 10)
		{
			buy.equipCostume11();

		}
		else if (menu.selectedCostume == 11)
		{
			buy.equipCostume12();

		}


	}

}
