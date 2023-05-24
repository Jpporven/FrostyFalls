using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLibrary : MonoBehaviour
{

    public AudioClip AcquiredNotifiication;
    public AudioClip AcquiredNotifiicationStart;
    public AudioClip BackButton;
    public AudioClip BackButtonSFX;
    public AudioClip BearRoar;
    public AudioClip IceBreak;
    public AudioClip Equip;
    public AudioClip Landing;
    public AudioClip BearLanding;
    public AudioClip Jumping;
    public AudioClip walrusJumping;
    public AudioClip OptionsSFX;
    public AudioClip Pengiun;
    public AudioClip Purchased;
    public AudioClip Snowball;
    public AudioClip Candy;
    public AudioClip ultraCandy;
    public AudioClip tame;

    public static AudioSource AcquiredNotifiicationStartSource;
    public static AudioSource AcquiredNotifiicationSource;
    public static AudioSource BackButtonSource;
    public static AudioSource BackButtonSFXSource;
    public static AudioSource BearRoarSource;
    public static AudioSource IceBreakSource;
    public static AudioSource EquipSource;
    public static AudioSource LandingSource;
    public static AudioSource BearLandingSource;
    public static AudioSource JumpingSource;
    public static AudioSource walrusJumpingSource;
    public static AudioSource OptionsSFXSource;
    public static AudioSource PengiunSource;
    public static AudioSource PurchasedSource;
    public static AudioSource SnowballSource;
    public static AudioSource CandySource;
    public static AudioSource ultraCandySource;



    public AudioSource AcquiredNotifiicationStartSourceRef;
    public AudioSource AcquiredNotifiicationSourceRef;
    public AudioSource BackButtonSourceRef;
    public AudioSource BackButtonSFXSourceRef;
    public AudioSource BearRoarSourceRef;
    public AudioSource IceBreakSourceRef;
    public AudioSource EquipSourceRef;
    public AudioSource LandingSourceRef;
    public AudioSource BearLandingSourceRef;
    public AudioSource JumpingSourceRef;
    public AudioSource walrusJumpingSourceRef;
    public AudioSource OptionsSFXSourceRef;
    public AudioSource PengiunSourceRef;
    public AudioSource PurchasedSourceRef;
    public AudioSource SnowballSourceRef;
    public AudioSource CandySourceRef;
    public AudioSource ultraCandySourceRef;



    void Start()
    {

	AcquiredNotifiicationStartSource = AcquiredNotifiicationStartSourceRef;
	AcquiredNotifiicationSource = AcquiredNotifiicationSourceRef;
	BackButtonSource = BackButtonSourceRef;
	BackButtonSFXSource = BackButtonSFXSourceRef;
	BearRoarSource = BearRoarSourceRef;
	IceBreakSource = IceBreakSourceRef;
	EquipSource = EquipSourceRef;
	LandingSource = LandingSourceRef;
	BearLandingSource = BearLandingSourceRef;
	JumpingSource = JumpingSourceRef;
	walrusJumpingSource = walrusJumpingSourceRef;
	OptionsSFXSource = OptionsSFXSourceRef;
	PengiunSource = PengiunSourceRef;
	PurchasedSource = PurchasedSourceRef;
	SnowballSource = SnowballSourceRef;
	CandySource = CandySourceRef;
	ultraCandySource = ultraCandySourceRef;

   
    }

    // Update is called once per frame
    void Update()
    {
        AcquiredNotifiicationStartSource.clip = AcquiredNotifiicationStart;
        AcquiredNotifiicationSource.clip = AcquiredNotifiication;
        BackButtonSource.clip = BackButton;
        BackButtonSFXSource.clip = BackButtonSFX;
        BearRoarSource.clip = BearRoar;
        IceBreakSource.clip = IceBreak;
        EquipSource.clip = Equip;
        LandingSource.clip = Landing;
	BearLandingSource.clip = BearLanding;
        JumpingSource.clip = Jumping;
        walrusJumpingSource.clip = walrusJumping;
        OptionsSFXSource.clip = OptionsSFX;
        PengiunSource.clip = Pengiun;
        PurchasedSource.clip = Purchased;
        SnowballSource.clip = Snowball;
	CandySource.clip = Candy;
	ultraCandySource.clip = ultraCandy;

        PengiunSource.pitch = Random.Range(0.8f, 1.2f);
        BearRoarSource.pitch = Random.Range(0.8f, 5f);


    }

    

}
