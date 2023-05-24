using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputButton : MonoBehaviour
{

public PlayerMovement move;

public static bool mouseDown;

	void Update(){
    		if(mouseDown)
		{
			move.Jump();
		}
	}

	void OnMouseDown(){
      		mouseDown = true;
	}

	void OnMouseUp(){
      		mouseDown = false;

	}
}