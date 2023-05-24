using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BirdController : MonoBehaviour
{
    public GameObject BIRDSObj;
    public TextMeshProUGUI scoreText;

    // bird will spawn at a specific score "BirdSpawnScore"
    public int BirdSpawnScore;

    int scoreValue;


    
    void Update()
    {
        int.TryParse(scoreText.text, out scoreValue);

        if(scoreValue > BirdSpawnScore)
        {
            BIRDSObj.SetActive(true);
        }
    }
}
