using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSlider : MonoBehaviour
{
    
    public GameObject volumeIcon;

    public Slider volumeSlider;


    void Start()
    {

	volumeSlider.value = 0.45f;

    }

    // Update is called once per frame
    public void OnValueChanged()
    {
        MusicControl.MenuMusic.volume = volumeSlider.value;
        MusicControl.InGameMusic.volume = volumeSlider.value;



	if(volumeSlider.value == 0)
	{

		volumeIcon.SetActive(false);

	}

	if(volumeSlider.value > 0)
	{

		volumeIcon.SetActive(true);

	}
    }
}