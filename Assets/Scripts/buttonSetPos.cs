using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonSetPos : MonoBehaviour
{

    public float speed;

    public Transform targetPos;


    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, targetPos.position, speed);
    }
}
