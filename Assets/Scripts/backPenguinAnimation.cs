using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backPenguinAnimation : MonoBehaviour
{
 
    public Animator penguinAnim;

    public float walkSlideDelay;


    // Update is called once per frame
    void Update()
    {

	StartCoroutine(PenguinAnim());

    }

    IEnumerator PenguinAnim()
    {

	    penguinAnim.SetBool("penguinWalk", true);
	    penguinAnim.SetBool("penguinSlide", false);

		yield return new WaitForSeconds(walkSlideDelay);

	    penguinAnim.SetBool("penguinWalk", false);
	    penguinAnim.SetBool("penguinSlide", true);

		yield return new WaitForSeconds(walkSlideDelay);
    }
}