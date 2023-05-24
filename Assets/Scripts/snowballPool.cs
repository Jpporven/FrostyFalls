using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;


public class snowballPool : MonoBehaviour, IPointerDownHandler
{

    public float DeactivateDelay;

    public static snowballPool SharedInstance;
    public List<GameObject> pooledObjects;
    public GameObject objectToPool;
    public int amountToPool;

    void Awake()
    {

	SharedInstance = this;

    }

    void Start()
    {


	pooledObjects = new List<GameObject>();
	GameObject tmp;
	for(int i = 0; i < amountToPool; i++)
	{
		tmp = Instantiate(objectToPool);
		tmp.SetActive(false);
		pooledObjects.Add(tmp);
	}

    }


    public GameObject GetPooledObject()
    {

	for(int i = 0; i < amountToPool; i++)
	{
		if(!pooledObjects[i].activeInHierarchy)
		{
			return pooledObjects[i];
		}
	}

	return null;

    }

    public void OnPointerDown(PointerEventData eventData) {


		if(GetPooledObject() != null) {

			AudioLibrary.SnowballSource.Play();

			GetPooledObject().transform.position = eventData.position;

			GetPooledObject().SetActive(true);

			StartCoroutine(SnowballDeactivate());
		}

    	transform.position = eventData.position;

    }


    IEnumerator SnowballDeactivate()
    {

	yield return new WaitForSeconds(DeactivateDelay);

	

	GetPooledObject().SetActive(false);	

    }




}
  

