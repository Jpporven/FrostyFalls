using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScreen : MonoBehaviour
{
    public GameObject TutorialObject1;
    public GameObject TutorialObject2;
    public GameObject TutorialObject3;
    int i = 0;

    public void SkipTutorial()
    {
        AudioLibrary.OptionsSFXSource.Play();

        if (i == 0)
        {
            TutorialObject1.SetActive(false);
            i++;
        }
        else if (i == 1)
        {
            TutorialObject2.SetActive(false);
            i++;
        }
        else if (i == 2)
        {
            TutorialObject3.SetActive(false);
            i=0;
        }

    }
}
