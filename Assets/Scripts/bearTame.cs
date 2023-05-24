using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bearTame : MonoBehaviour
{

    public GameObject hearts;

    public Transform player;

    public Transform tamePos;

    public Transform spawn;


    void Update()
    {

	float distance = Vector3.Distance (tamePos.position, player.position);
	

	if (distance <= 1f)
	{

		hearts.SetActive(true);

	}else if (distance >= 1.1f)
	{
	
		hearts.SetActive(false);

	}


    }


    public void Respawn()
    {

	transform.position = spawn.position;

    }

}
