using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bearAttack : MonoBehaviour
{

    public GameObject spit;

    public GameObject Attack;


    public Transform player;

    public hurtPlayer hurt;

    public Animator bear;

    public float range;

    int i;

    void Update()
    {
	float distance = Vector3.Distance (player.position, transform.position);

	if (distance <= range)
	{
		BearRoar();

		spit.SetActive(true);

		hurt.Damage();

		bear.SetBool("bearIdle", false);
		bear.SetBool("bearAttack", true);
		
	}else if (distance >= range)
		{

		
		spit.SetActive(false);

		bear.SetBool("bearIdle", true);
		bear.SetBool("bearAttack", false);

		i = i + 1;

	}

     }

     public void BearRoar()
     {
	if(i >= 1)
	{
		AudioLibrary.BearRoarSource.Play();

		i = i - i;
	}


     }



  

}
