using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBoundsFollow : MonoBehaviour
{

    public Transform player;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
    }
}
