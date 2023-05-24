using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CostumeNotificationToggler : MonoBehaviour, IDataPersistence
{
	public GameObject[] Notification;
	public int[] skipped = new int[12];

	void Update()
	{
		for (int i = 0; i < 12; i++)
		{
			if (skipped[i] == 1)
			{
				Destroy(Notification[i]);
			}
		}
	}


	public void LoadData(GameData data)
	{

		this.skipped[0] = data.c1;
		this.skipped[1] = data.c2;
		this.skipped[2] = data.c3;
		this.skipped[3] = data.c4;
		this.skipped[4] = data.c5;
		this.skipped[5] = data.c6;
		this.skipped[6] = data.c7;
		this.skipped[7] = data.c8;
		this.skipped[8] = data.c9;
		this.skipped[9] = data.c10;
		this.skipped[10] = data.c11;
		this.skipped[11] = data.c12;

	}

	public void SaveData(ref GameData data)
	{


	}
}