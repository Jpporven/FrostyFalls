using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsSensor : MonoBehaviour
{
    public bool isProtected;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] OPT;
        OPT = GameObject.FindGameObjectsWithTag("Options");

        if(ScoreSensor.gamePaused)
	{
		Destroy(this);

	}
        if(!ScoreSensor.gamePaused)
	{

		if (OPT.Length == 1)
        	{


			isProtected = true;
	
        	}

		if (OPT.Length >= 2)
        	{
			if(!isProtected)
			{

				Destroy(this.gameObject);

			}
	
        	}
	}
    }

}
