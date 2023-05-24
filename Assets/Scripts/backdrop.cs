using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backdrop : MonoBehaviour
{

    private SpriteRenderer backdropFaded;

    private Color backdropFull;


    public float fadeSpeed;

    // Start is called before the first frame update
    void Start()
    {
	backdropFull = new Color (103, 69, 181, 81);
	backdropFaded.color = new Color (103, 69, 181, 0);

    }

    void Update()
    {

	backdropFaded.color = Color.Lerp(backdropFaded.color, backdropFull, Mathf.PingPong(Time.time, fadeSpeed));

    }

}
