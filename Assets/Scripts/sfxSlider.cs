using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sfxSlider : MonoBehaviour
{
    
    public GameObject volumeIcon;

    public Slider volumeSlider;

    public float OriginalVolume;


    void Start()
    {

	volumeSlider.value = 0.7f;

    }

    // Update is called once per frame
    public void OnValueChanged()
    {
        AudioLibrary.AcquiredNotifiicationStartSource.volume = volumeSlider.value;
        AudioLibrary.AcquiredNotifiicationSource.volume = volumeSlider.value;
        AudioLibrary.BackButtonSource.volume = volumeSlider.value;
        AudioLibrary.BackButtonSFXSource.volume = volumeSlider.value;
        AudioLibrary.BearRoarSource.volume = volumeSlider.value;
        AudioLibrary.IceBreakSource.volume = volumeSlider.value;
        AudioLibrary.EquipSource.volume = volumeSlider.value;
        AudioLibrary.LandingSource.volume = volumeSlider.value;
        AudioLibrary.BearLandingSource.volume = volumeSlider.value;
        AudioLibrary.JumpingSource.volume = volumeSlider.value;
        AudioLibrary.walrusJumpingSource.volume = volumeSlider.value;
        AudioLibrary.OptionsSFXSource.volume = volumeSlider.value;
        AudioLibrary.PengiunSource.volume = volumeSlider.value;
        AudioLibrary.SnowballSource.volume = volumeSlider.value;
        AudioLibrary.CandySource.volume = volumeSlider.value;
        AudioLibrary.ultraCandySource.volume = volumeSlider.value;


	if(volumeSlider.value <= 0.2f)
	{

		volumeIcon.SetActive(false);

	}

	if(volumeSlider.value > 0)
	{

		volumeIcon.SetActive(true);

		OriginalVolume = volumeSlider.value;

	}

	
    }

    void Update()
    {

	if(ScoreSensor.gamePaused)
	{

		volumeSlider.value = 0f;

	}
	if(!ScoreSensor.gamePaused)
	{

		volumeSlider.value = OriginalVolume;

	}

    }
}
