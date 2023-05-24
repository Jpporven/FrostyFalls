using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSkinSensor : MonoBehaviour
{

    public buyandequip equip;

    public GameObject Costume1;
    public GameObject Costume2;
    public GameObject Costume3;
    public GameObject Costume4;
    public GameObject Costume5;
    public GameObject Costume6;
    public GameObject Costume7;
    public GameObject Costume8;
    public GameObject Costume9;
    public GameObject Costume10;
    public GameObject Costume11;
    public GameObject Costume12;



    // Start is called before the first frame update
    void Start()
    {
        MusicControl.inGame = false;
        MusicControl.isPlaying = false;


        MusicControl.InGameMusic.Stop();


        Costume1.SetActive(false);
        Costume2.SetActive(false);
        Costume3.SetActive(false);
        Costume4.SetActive(false);
        Costume5.SetActive(false);
        Costume6.SetActive(false);
        Costume7.SetActive(false);
        Costume8.SetActive(false);
        Costume9.SetActive(false);
        Costume10.SetActive(false);
        Costume11.SetActive(false);
        Costume12.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        equip = GameObject.Find("IAPSystem").GetComponent<buyandequip>();

        if (equip.costume1Equipped == 1)
        {

            Costume1.SetActive(true);
            Costume2.SetActive(false);
            Costume3.SetActive(false);
            Costume4.SetActive(false);
            Costume5.SetActive(false);
            Costume6.SetActive(false);
            Costume7.SetActive(false);
            Costume8.SetActive(false);
            Costume9.SetActive(false);
            Costume10.SetActive(false);
            Costume11.SetActive(false);
            Costume12.SetActive(false);

        }
        if (equip.costume2Equipped == 1)
        {

            Costume1.SetActive(false);
            Costume2.SetActive(true);
            Costume3.SetActive(false);
            Costume4.SetActive(false);
            Costume5.SetActive(false);
            Costume6.SetActive(false);
            Costume7.SetActive(false);
            Costume8.SetActive(false);
            Costume9.SetActive(false);
            Costume10.SetActive(false);
            Costume11.SetActive(false);
            Costume12.SetActive(false);

        }
        if (equip.costume3Equipped == 1)
        {

            Costume1.SetActive(false);
            Costume2.SetActive(false);
            Costume3.SetActive(true);
            Costume4.SetActive(false);
            Costume5.SetActive(false);
            Costume6.SetActive(false);
            Costume7.SetActive(false);
            Costume8.SetActive(false);
            Costume9.SetActive(false);
            Costume10.SetActive(false);
            Costume11.SetActive(false);
            Costume12.SetActive(false);

        }
        if (equip.costume4Equipped == 1)
        {

            Costume1.SetActive(false);
            Costume2.SetActive(false);
            Costume3.SetActive(false);
            Costume4.SetActive(true);
            Costume5.SetActive(false);
            Costume6.SetActive(false);
            Costume7.SetActive(false);
            Costume8.SetActive(false);
            Costume9.SetActive(false);
            Costume10.SetActive(false);
            Costume11.SetActive(false);
            Costume12.SetActive(false);

        }
        if (equip.costume5Equipped == 1)
        {

            Costume1.SetActive(false);
            Costume2.SetActive(false);
            Costume3.SetActive(false);
            Costume4.SetActive(false);
            Costume5.SetActive(true);
            Costume6.SetActive(false);
            Costume7.SetActive(false);
            Costume8.SetActive(false);
            Costume9.SetActive(false);
            Costume10.SetActive(false);
            Costume11.SetActive(false);
            Costume12.SetActive(false);

        }
        if (equip.costume6Equipped == 1)
        {

            Costume1.SetActive(false);
            Costume2.SetActive(false);
            Costume3.SetActive(false);
            Costume4.SetActive(false);
            Costume5.SetActive(false);
            Costume6.SetActive(true);
            Costume7.SetActive(false);
            Costume8.SetActive(false);
            Costume9.SetActive(false);
            Costume10.SetActive(false);
            Costume11.SetActive(false);
            Costume12.SetActive(false);

        }
        if (equip.costume7Equipped == 1)
        {

            Costume1.SetActive(false);
            Costume2.SetActive(false);
            Costume3.SetActive(false);
            Costume4.SetActive(false);
            Costume5.SetActive(false);
            Costume6.SetActive(false);
            Costume7.SetActive(true);
            Costume8.SetActive(false);
            Costume9.SetActive(false);
            Costume10.SetActive(false);
            Costume11.SetActive(false);
            Costume12.SetActive(false);

        }
        if (equip.costume8Equipped == 1)
        {

            Costume1.SetActive(false);
            Costume2.SetActive(false);
            Costume3.SetActive(false);
            Costume4.SetActive(false);
            Costume5.SetActive(false);
            Costume6.SetActive(false);
            Costume7.SetActive(false);
            Costume8.SetActive(true);
            Costume9.SetActive(false);
            Costume10.SetActive(false);
            Costume11.SetActive(false);
            Costume12.SetActive(false);

        }
        if (equip.costume9Equipped == 1)
        {

            Costume1.SetActive(false);
            Costume2.SetActive(false);
            Costume3.SetActive(false);
            Costume4.SetActive(false);
            Costume5.SetActive(false);
            Costume6.SetActive(false);
            Costume7.SetActive(false);
            Costume8.SetActive(false);
            Costume9.SetActive(true);
            Costume10.SetActive(false);
            Costume11.SetActive(false);
            Costume12.SetActive(false);

        }
        if (equip.costume10Equipped == 1)
        {

            Costume1.SetActive(false);
            Costume2.SetActive(false);
            Costume3.SetActive(false);
            Costume4.SetActive(false);
            Costume5.SetActive(false);
            Costume6.SetActive(false);
            Costume7.SetActive(false);
            Costume8.SetActive(false);
            Costume9.SetActive(false);
            Costume10.SetActive(true);
            Costume11.SetActive(false);
            Costume12.SetActive(false);

        }
        if (equip.costume11Equipped == 1)
        {

            Costume1.SetActive(false);
            Costume2.SetActive(false);
            Costume3.SetActive(false);
            Costume4.SetActive(false);
            Costume5.SetActive(false);
            Costume6.SetActive(false);
            Costume7.SetActive(false);
            Costume8.SetActive(false);
            Costume9.SetActive(false);
            Costume10.SetActive(false);
            Costume11.SetActive(true);
            Costume12.SetActive(false);

        }
        if (equip.costume12Equipped == 1)
        {

            Costume1.SetActive(false);
            Costume2.SetActive(false);
            Costume3.SetActive(false);
            Costume4.SetActive(false);
            Costume5.SetActive(false);
            Costume6.SetActive(false);
            Costume7.SetActive(false);
            Costume8.SetActive(false);
            Costume9.SetActive(false);
            Costume10.SetActive(false);
            Costume11.SetActive(false);
            Costume12.SetActive(true);

        }
    }
}
