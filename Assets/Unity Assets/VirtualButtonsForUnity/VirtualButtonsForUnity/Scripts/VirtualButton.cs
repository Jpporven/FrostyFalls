using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class VirtualButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public static bool rotate = false;

    public void OnPointerDown(PointerEventData pointerEventData)
    {
        rotate = true;
    }

    public void OnPointerUp(PointerEventData pointerEventData)
    {
        rotate = false;
    }
}
