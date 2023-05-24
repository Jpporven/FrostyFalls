using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicControl : MonoBehaviour
{
    public static bool inGame = false;

    public static AudioSource MenuMusic;
    public static AudioSource InGameMusic;

    public AudioSource MenuMusicRef;
    public AudioSource InGameMusicRef;

	public GameObject InGameMusicObj;

    public static bool isPlaying = false;


    // Update is called once per frame
    void Update()
    {

        InGameMusic = InGameMusicRef;
        MenuMusic = MenuMusicRef;

        if (!inGame && !isPlaying)
        {
            InGameMusicObj.SetActive(false);


            MenuMusic.Play();


            isPlaying = true;
        }
        else if (scoreMind.Score > 0)
        {
            MenuMusic.Stop();

            InGameMusicObj.SetActive(true);
        }

    }
}
