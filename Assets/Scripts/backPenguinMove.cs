using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backPenguinMove : MonoBehaviour
{

    public Transform BackPenguin;
    public int speed;

    // Update is called once per frame
    void Update()
    {
	   Vector3 a = transform.position;
	   Vector3 b = BackPenguin.position;

	   transform.position = Vector3.Lerp(a, b, speed);    
    }
}
