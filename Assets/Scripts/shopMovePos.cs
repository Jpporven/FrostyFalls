using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopMovePos : MonoBehaviour
{

    public float buyButtonDelay;

    public float menuSpeed;

    public float buyButtonSpeed;

    public Transform menuInPos;

    public Transform menuOutOfPos;

    public Transform buy;

    public Transform buyInPos;

    public Transform buyOutOfPos;

    string Shop;

    // Update is called once per frame
    void Update()
    {
	if(PlayerPrefs.GetInt(Shop) == 1)
	{
  	
	      transform.position = Vector3.Lerp(transform.position, menuInPos.position, menuSpeed);
	buy.position = Vector3.Lerp(buy.position, buyInPos.position, buyButtonSpeed);

	}

	if(PlayerPrefs.GetInt(Shop) == 0)
	{
	      AudioLibrary.BackButtonSource.Stop();
	      AudioLibrary.BackButtonSource.Stop();

	      transform.position = Vector3.Lerp(transform.position, menuOutOfPos.position, menuSpeed);

	      buy.position = Vector3.Lerp(buy.position, buyOutOfPos.position, 100f);

	}


    }

}
