using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hailMind : MonoBehaviour
{
    private GameObject[] spawnPoints;
    public GameObject[] hailPrefab;

    public GameObject ice1;
    public GameObject ice2;
    public GameObject ice3;
    public GameObject ice4;


    public bool isSpawningHail;

    private int index;
    private int hailIndex;
    private int lastSpawnedPos;


    public float spawnRate;

 
     void Start()
     {
         spawnPoints = GameObject.FindGameObjectsWithTag("hailSpawn");

       	 isSpawningHail = true;

	  hailPrefab = new GameObject[4];
          hailPrefab[0]=ice1;
          hailPrefab[1]=ice2;
          hailPrefab[2]=ice3;
          hailPrefab[3]=ice4;
 
	  StartCoroutine(hailSpawnAssistant());
     }

     void Update()
     {


        index = Random.Range (0, spawnPoints.Length);
        hailIndex = Random.Range (0, hailPrefab.Length);

	StartCoroutine(hailSpawnAssistant());


	if(isSpawningHail)
	{

		StartCoroutine(SpawnHailPrefab());

	}

     }

     IEnumerator SpawnHailPrefab()
     {
	isSpawningHail = false;

	yield return new WaitForSeconds(spawnRate);

	if(index == lastSpawnedPos)
	{

		index = Random.Range (0, hailPrefab.Length);
	}

	Vector3 spawnPointsPosition = spawnPoints[index].transform.position;

	Instantiate(hailPrefab[hailIndex], spawnPointsPosition, Quaternion.identity);


	yield return new WaitForSeconds(1);

	isSpawningHail = true;

     }

     IEnumerator hailSpawnAssistant()
     {

	yield return new WaitForSeconds(0.5f);

	lastSpawnedPos = index;
     }

 }