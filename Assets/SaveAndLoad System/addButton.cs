using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class addButton : MonoBehaviour, IDataPersistence
{
    public int number;
    public Text text; 

    public void Add()
    {
	text.text = number.ToString();

	number++;
    }

    public void LoadData(GameData data)
    {

	this.number = data.numberForSaving;

    }

    public void SaveData(ref GameData data)
    {

	data.numberForSaving = this.number;

    }
}
