using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMountain : MonoBehaviour
{

    public buttonSetPos player;

    string PlayerMountainSpeed;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
   
	player.speed = PlayerPrefs.GetInt(PlayerMountainSpeed) / 10;
     
    }

}
