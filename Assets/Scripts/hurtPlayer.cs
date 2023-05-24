using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurtPlayer : MonoBehaviour
{

    public float damage;
    public playerHealth PlayerHealth;
    public SpriteRenderer playerSprite;

    public bool isPenguin;


    public void Damage()
    {

	PlayerHealth.Health = PlayerHealth.Health - damage;

	playerSprite.color = Color.red;

	StartCoroutine(colorReset());

    }

    IEnumerator colorReset()
    {

	yield return new WaitForSeconds(0.5f);

	playerSprite.color = Color.white;

    }
}
