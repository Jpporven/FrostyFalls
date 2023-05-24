using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candySpawn : MonoBehaviour
{
    private GameObject[] spawnPoints;
    private GameObject[] spawnedCandy;
    public GameObject candyPrefab;

    private GameObject[] ultraSpawnPoints;
    private GameObject[] spawnedUltraCandy;
    public GameObject candyUltraPrefab;

    public bool isSpawningCandy;
    public bool isSpawningUltraCandy;

    private int index;
    private int indexUltra;

    public float spawnRate;
    public float spawnRateUltra;

 
     void Start()
     {
         spawnPoints = GameObject.FindGameObjectsWithTag("candySpawn");
         spawnedCandy = GameObject.FindGameObjectsWithTag("candy");

         ultraSpawnPoints = GameObject.FindGameObjectsWithTag("ultraCandySpawn");
         spawnedUltraCandy = GameObject.FindGameObjectsWithTag("ultraCandy");

	 isSpawningUltraCandy = true;

       	 isSpawningCandy = true;
 

     }

     void Update()
     {

        index = Random.Range (0, spawnPoints.Length);

        indexUltra = Random.Range (0, ultraSpawnPoints.Length);




	if(spawnedCandy.Length < 1)
	{

		if(isSpawningCandy)
		{

			StartCoroutine(SpawnCandyPrefab());

		}
	}

	if(spawnedUltraCandy.Length < 1)
	{

		if(isSpawningUltraCandy)
		{

			StartCoroutine(SpawnUltraCandyPrefab());

		}

	}

     }

     IEnumerator SpawnCandyPrefab()
     {
	isSpawningCandy = false;

	yield return new WaitForSeconds(spawnRate);


	Vector3 spawnPointsPosition = spawnPoints[index].transform.position;

	Instantiate(candyPrefab, spawnPointsPosition, Quaternion.identity);


	yield return new WaitForSeconds(10 - spawnRate);

	isSpawningCandy = true;

     }
     IEnumerator SpawnUltraCandyPrefab()
     {
	isSpawningUltraCandy = false;

	yield return new WaitForSeconds(spawnRateUltra);


	Vector3 ultraSpawnPointsPosition = ultraSpawnPoints[indexUltra].transform.position;

	Instantiate(candyUltraPrefab, ultraSpawnPointsPosition, Quaternion.identity);


	yield return new WaitForSeconds(10 - spawnRateUltra);

	isSpawningUltraCandy = true;

     }

 }
 