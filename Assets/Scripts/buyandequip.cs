using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyandequip : MonoBehaviour, IDataPersistence
{


	public int costume1Purchased;
	public int costume2Purchased;
	public int costume3Purchased;
	public int costume4Purchased;
	public int costume5Purchased;
	public int costume6Purchased;
	public int costume7Purchased;
	public int costume8Purchased;
	public int costume9Purchased;
	public int costume10Purchased;
	public int costume11Purchased;
	public int costume12Purchased;

	public GameObject costume1Buy;
	public GameObject costume2Buy;
	public GameObject costume3Buy;
	public GameObject costume4Buy;
	public GameObject costume5Buy;
	public GameObject costume6Buy;
	public GameObject costume7Buy;
	public GameObject costume8Buy;
	public GameObject costume9Buy;
	public GameObject costume10Buy;
	public GameObject costume11Buy;
	public GameObject costume12Buy;

	public GameObject costume1Equip;
	public GameObject costume2Equip;
	public GameObject costume3Equip;
	public GameObject costume4Equip;
	public GameObject costume5Equip;
	public GameObject costume6Equip;
	public GameObject costume7Equip;
	public GameObject costume8Equip;
	public GameObject costume9Equip;
	public GameObject costume10Equip;
	public GameObject costume11Equip;
	public GameObject costume12Equip;

	public int costume1Equipped;
	public int costume2Equipped;
	public int costume3Equipped;
	public int costume4Equipped;
	public int costume5Equipped;
	public int costume6Equipped;
	public int costume7Equipped;
	public int costume8Equipped;
	public int costume9Equipped;
	public int costume10Equipped;
	public int costume11Equipped;
	public int costume12Equipped;


	// Update is called once per frame
	void Update()
	{


		if (costume1Purchased == 1)
		{


			costume1Buy.SetActive(false);
			costume1Equip.SetActive(true);
		}else if (costume1Purchased == 0)
		{

			costume1Buy.SetActive(true);
			costume1Equip.SetActive(false);

		}


		if (costume2Purchased == 1)
		{

			costume2Buy.SetActive(false);
			costume2Equip.SetActive(true);

		}else if (costume2Purchased == 0)
		{

			costume2Buy.SetActive(true);
			costume2Equip.SetActive(false);

		}



		if (costume3Purchased == 1)
		{

			costume3Buy.SetActive(false);
			costume3Equip.SetActive(true);


		}else if (costume3Purchased == 0)
		{

			costume3Buy.SetActive(true);
			costume3Equip.SetActive(false);
		}



		if (costume4Purchased == 1)
		{

			costume4Buy.SetActive(false);
			costume4Equip.SetActive(true);
		}else if (costume4Purchased == 0)
		{

			costume4Buy.SetActive(true);
			costume4Equip.SetActive(false);
		}



		if (costume5Purchased == 1)
		{

			costume5Buy.SetActive(false);
			costume5Equip.SetActive(true);
		}else if (costume5Purchased == 0)
		{

			costume5Buy.SetActive(true);
			costume5Equip.SetActive(false);
		}



		if (costume6Purchased == 1)
		{

			costume6Buy.SetActive(false);
			costume6Equip.SetActive(true);
		}else if (costume6Purchased == 0)
		{

			costume6Buy.SetActive(true);
			costume6Equip.SetActive(false);
		}



		if (costume7Purchased == 1)
		{

			costume7Buy.SetActive(false);
			costume7Equip.SetActive(true);
		}
		else if (costume7Purchased == 0)
		{

			costume7Buy.SetActive(true);
			costume7Equip.SetActive(false);
		}



		if (costume8Purchased == 1)
		{

			costume8Buy.SetActive(false);
			costume8Equip.SetActive(true);
		}else if (costume8Purchased == 0)
		{

			costume8Buy.SetActive(true);
			costume8Equip.SetActive(false);
		}



		if (costume9Purchased == 1)
		{

			costume9Buy.SetActive(false);
			costume9Equip.SetActive(true);
		}else if (costume9Purchased == 0)
		{

			costume9Buy.SetActive(true);
			costume9Equip.SetActive(false);
		}


		if (costume10Purchased == 1)
		{

			costume10Buy.SetActive(false);
			costume10Equip.SetActive(true);
		}else if (costume10Purchased == 0)
		{

			costume10Buy.SetActive(true);
			costume10Equip.SetActive(false);
		}



		if (costume11Purchased == 1)
		{

			costume11Buy.SetActive(false);
			costume11Equip.SetActive(true);
		}else if (costume11Purchased == 0)
		{

			costume11Buy.SetActive(true);
			costume11Equip.SetActive(false);
		}



		if (costume12Purchased == 1)
		{

			costume12Buy.SetActive(false);
			costume12Equip.SetActive(true);
		}else if (costume12Purchased == 0)
		{

			costume12Buy.SetActive(true);
			costume12Equip.SetActive(false);
		}


	}

	public void equipCostume1()
	{

		costume1Equipped = 1;
		costume2Equipped = 0;
		costume3Equipped = 0;
		costume4Equipped = 0;
		costume5Equipped = 0;
		costume6Equipped = 0;
		costume7Equipped = 0;
		costume8Equipped = 0;
		costume9Equipped = 0;
		costume10Equipped = 0;
		costume11Equipped = 0;
		costume12Equipped = 0;
	}
	public void equipCostume2()
	{

		costume1Equipped = 0;
		costume2Equipped = 1;
		costume3Equipped = 0;
		costume4Equipped = 0;
		costume5Equipped = 0;
		costume6Equipped = 0;
		costume7Equipped = 0;
		costume8Equipped = 0;
		costume9Equipped = 0;
		costume10Equipped = 0;
		costume11Equipped = 0;
		costume12Equipped = 0;
	}
	public void equipCostume3()
	{

		costume1Equipped = 0;
		costume2Equipped = 0;
		costume3Equipped = 1;
		costume4Equipped = 0;
		costume5Equipped = 0;
		costume6Equipped = 0;
		costume7Equipped = 0;
		costume8Equipped = 0;
		costume9Equipped = 0;
		costume10Equipped = 0;
		costume11Equipped = 0;
		costume12Equipped = 0;
	}
	public void equipCostume4()
	{

		costume1Equipped = 0;
		costume2Equipped = 0;
		costume3Equipped = 0;
		costume4Equipped = 1;
		costume5Equipped = 0;
		costume6Equipped = 0;
		costume7Equipped = 0;
		costume8Equipped = 0;
		costume9Equipped = 0;
		costume10Equipped = 0;
		costume11Equipped = 0;
		costume12Equipped = 0;
	}
	public void equipCostume5()
	{

		costume1Equipped = 0;
		costume2Equipped = 0;
		costume3Equipped = 0;
		costume4Equipped = 0;
		costume5Equipped = 1;
		costume6Equipped = 0;
		costume7Equipped = 0;
		costume8Equipped = 0;
		costume9Equipped = 0;
		costume10Equipped = 0;
		costume11Equipped = 0;
		costume12Equipped = 0;
	}
	public void equipCostume6()
	{

		costume1Equipped = 0;
		costume2Equipped = 0;
		costume3Equipped = 0;
		costume4Equipped = 0;
		costume5Equipped = 0;
		costume6Equipped = 1;
		costume7Equipped = 0;
		costume8Equipped = 0;
		costume9Equipped = 0;
		costume10Equipped = 0;
		costume11Equipped = 0;
		costume12Equipped = 0;
	}
	public void equipCostume7()
	{

		costume1Equipped = 0;
		costume2Equipped = 0;
		costume3Equipped = 0;
		costume4Equipped = 0;
		costume5Equipped = 0;
		costume6Equipped = 0;
		costume7Equipped = 1;
		costume8Equipped = 0;
		costume9Equipped = 0;
		costume10Equipped = 0;
		costume11Equipped = 0;
		costume12Equipped = 0;
	}
	public void equipCostume8()
	{

		costume1Equipped = 0;
		costume2Equipped = 0;
		costume3Equipped = 0;
		costume4Equipped = 0;
		costume5Equipped = 0;
		costume6Equipped = 0;
		costume7Equipped = 0;
		costume8Equipped = 1;
		costume9Equipped = 0;
		costume10Equipped = 0;
		costume11Equipped = 0;
		costume12Equipped = 0;
	}
	public void equipCostume9()
	{

		costume1Equipped = 0;
		costume2Equipped = 0;
		costume3Equipped = 0;
		costume4Equipped = 0;
		costume5Equipped = 0;
		costume6Equipped = 0;
		costume7Equipped = 0;
		costume8Equipped = 0;
		costume9Equipped = 1;
		costume10Equipped = 0;
		costume11Equipped = 0;
		costume12Equipped = 0;
	}
	public void equipCostume10()
	{

		costume1Equipped = 0;
		costume2Equipped = 0;
		costume3Equipped = 0;
		costume4Equipped = 0;
		costume5Equipped = 0;
		costume6Equipped = 0;
		costume7Equipped = 0;
		costume8Equipped = 0;
		costume9Equipped = 0;
		costume10Equipped = 1;
		costume11Equipped = 0;
		costume12Equipped = 0;
	}
	public void equipCostume11()
	{

		costume1Equipped = 0;
		costume2Equipped = 0;
		costume3Equipped = 0;
		costume4Equipped = 0;
		costume5Equipped = 0;
		costume6Equipped = 0;
		costume7Equipped = 0;
		costume8Equipped = 0;
		costume9Equipped = 0;
		costume10Equipped = 0;
		costume11Equipped = 1;
		costume12Equipped = 0;
	}
	public void equipCostume12()
	{

		costume1Equipped = 0;
		costume2Equipped = 0;
		costume3Equipped = 0;
		costume4Equipped = 0;
		costume5Equipped = 0;
		costume6Equipped = 0;
		costume7Equipped = 0;
		costume8Equipped = 0;
		costume9Equipped = 0;
		costume10Equipped = 0;
		costume11Equipped = 0;
		costume12Equipped = 1;
	}

	public void LoadData(GameData data)
	{

		this.costume1Purchased = data.c1;
		this.costume2Purchased = data.c2;
		this.costume3Purchased = data.c3;
		this.costume4Purchased = data.c4;
		this.costume5Purchased = data.c5;
		this.costume6Purchased = data.c6;
		this.costume7Purchased = data.c7;
		this.costume8Purchased = data.c8;
		this.costume9Purchased = data.c9;
		this.costume10Purchased = data.c10;
		this.costume11Purchased = data.c11;
		this.costume12Purchased = data.c12;

		this.costume1Equipped = data.e1;
		this.costume2Equipped = data.e2;
		this.costume3Equipped = data.e3;
		this.costume4Equipped = data.e4;
		this.costume5Equipped = data.e5;
		this.costume6Equipped = data.e6;
		this.costume7Equipped = data.e7;
		this.costume8Equipped = data.e8;
		this.costume9Equipped = data.e9;
		this.costume10Equipped = data.e10;
		this.costume11Equipped = data.e11;
		this.costume12Equipped = data.e12;


	}

	public void SaveData(ref GameData data)
	{
		data.c1 = this.costume1Purchased;
		data.c2 = this.costume2Purchased;
		data.c3 = this.costume3Purchased;
		data.c4 = this.costume4Purchased;
		data.c5 = this.costume5Purchased;
		data.c6 = this.costume6Purchased;
		data.c7 = this.costume7Purchased;
		data.c8 = this.costume8Purchased;
		data.c9 = this.costume9Purchased;
		data.c10 = this.costume10Purchased;
		data.c11 = this.costume11Purchased;
		data.c12 = this.costume12Purchased;


		data.e1 = this.costume1Equipped;
		data.e2 = this.costume2Equipped;
		data.e3 = this.costume3Equipped;
		data.e4 = this.costume4Equipped;
		data.e5 = this.costume5Equipped;
		data.e6 = this.costume6Equipped;
		data.e7 = this.costume7Equipped;
		data.e8 = this.costume8Equipped;
		data.e9 = this.costume9Equipped;
		data.e10 = this.costume10Equipped;
		data.e11 = this.costume11Equipped;
		data.e12 = this.costume12Equipped;



	}
}
