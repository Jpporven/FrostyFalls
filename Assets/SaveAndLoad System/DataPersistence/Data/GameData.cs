using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class GameData
{

    // Highscore data

    public int numberForSaving;

    // IAP data

    public int NoAds;

    public int TutorialComplete;

    public int c1;
    public int c2;
    public int c3;
    public int c4;
    public int c5;
    public int c6;
    public int c7;
    public int c8;
    public int c9;
    public int c10;
    public int c11;
    public int c12;


    public int e1;
    public int e2;
    public int e3;
    public int e4;
    public int e5;
    public int e6;
    public int e7;
    public int e8;
    public int e9;
    public int e10;
    public int e11;
    public int e12;


    // the values defined in this constructor will be default values
    // the game starts when theres no data to load


    public GameData()
    {
        this.c1 = 0;

        this.numberForSaving = 0;

        this.NoAds = 1;

        this.TutorialComplete = 1;


    }
}
