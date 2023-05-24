using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowpos : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, 16f);
    }
}
