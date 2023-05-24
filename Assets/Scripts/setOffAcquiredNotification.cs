using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class setOffAcquiredNotification : MonoBehaviour, IPointerDownHandler
{

    public bool A1;
    public bool A2;
    public bool A3;
    public bool A4;
    public bool A5;
    public bool A6;
    public bool A7;
    public bool A8;
    public bool A9;
    public bool A10;
    public bool A11;
    public bool A12;


    public void OnPointerDown(PointerEventData eventData) {

	gameObject.SetActiveRecursively(false);

							
	AudioLibrary.AcquiredNotifiicationSource.Play();


			if(A1)
			{
				buyandequipButton.AcquiredSkipped1 = true;

				A1 = false;
			}

			if(A2)
			{
				buyandequipButton.AcquiredSkipped2 = true;

				A2 = false;
			}

			if(A3)
			{
				buyandequipButton.AcquiredSkipped3 = true;

				A3 = false;
			}

			if(A4)
			{
				buyandequipButton.AcquiredSkipped4 = true;

				A4 = false;
			}

			if(A5)
			{
				buyandequipButton.AcquiredSkipped5 = true;

				A5 = false;
			}

			if(A6)
			{
				buyandequipButton.AcquiredSkipped6 = true;

				A6 = false;
			}

			if(A7)
			{
				buyandequipButton.AcquiredSkipped7 = true;

				A7 = false;
			}

			if(A8)
			{
				buyandequipButton.AcquiredSkipped8 = true;

				A8 = false;
			}

			if(A9)
			{
				buyandequipButton.AcquiredSkipped9 = true;

				A9 = false;
			}

			if(A10)
			{
				buyandequipButton.AcquiredSkipped10 = true;

				A10 = false;
			}

			if(A11)
			{
				buyandequipButton.AcquiredSkipped11 = true;

				A11 = false;
			}

			if(A12)
			{
				buyandequipButton.AcquiredSkipped12 = true;

				A12 = false;
			}
    }

}
