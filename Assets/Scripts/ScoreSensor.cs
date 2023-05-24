using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSensor : MonoBehaviour
{

public static bool gamePaused;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
	if(Time.deltaTime > 0f)
	{

        gamePaused = false;

	}else{

	gamePaused = true;

	}

    }
}
