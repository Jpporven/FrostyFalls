using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaleUpStartAnimation : MonoBehaviour
{

    public float scaleSize;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(0, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {

        transform.localScale = Vector3.Lerp (transform.localScale, new Vector3(scaleSize, scaleSize, scaleSize), 0.01f);

       
    }


}
