using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnAwakeAudioPlay : MonoBehaviour
{

    public bool iceBreakAudio;
   
    public bool AcquiredNotifAudio;


    void Awake()
    {
        if(iceBreakAudio)
	{
		IceBreakAudioPlay();
	}
        if(AcquiredNotifAudio)
	{
		AcquiredAudioPlay();
	}
    }

    public void IceBreakAudioPlay()
    {

	AudioLibrary.IceBreakSource.Play();

    }

    public void AcquiredAudioPlay()
    {

	AudioLibrary.AcquiredNotifiicationStartSource.Play();

    }
}
