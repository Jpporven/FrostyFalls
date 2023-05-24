using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToMainMenu : MonoBehaviour
{

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void backToMain()
    {

	anim.SetBool("isCredits", true);

    }
}
