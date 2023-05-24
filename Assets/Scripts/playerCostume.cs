using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCostume : MonoBehaviour
{

    public float speed;

    public Transform targetCostumePos;

    public costumeMenu costume;


    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetCostumePos.position, speed);

	costume = GameObject.Find("costumeSelection").GetComponent<costumeMenu>();

	
    }
}
