using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopMenu : MonoBehaviour
{
	public costumeMenu menu;

    public SpriteRenderer costume1;

    public SpriteRenderer costume2;

    public SpriteRenderer costume3;

    public SpriteRenderer costume4;

    public SpriteRenderer costume5;

    public SpriteRenderer costume6;

    public SpriteRenderer costume7;

    public SpriteRenderer costume8;

    public SpriteRenderer costume9;

    public SpriteRenderer costume10;

    public SpriteRenderer costume11;

    public SpriteRenderer costume12;

    public GameObject costume1Preview;

    public GameObject costume2Preview;

    public GameObject costume3Preview;

    public GameObject costume4Preview;

    public GameObject costume5Preview;

    public GameObject costume6Preview;

    public GameObject costume7Preview;

    public GameObject costume8Preview;

    public GameObject costume9Preview;

    public GameObject costume10Preview;

    public GameObject costume11Preview;

    public GameObject costume12Preview;


    
    private SpriteRenderer selectedSpritePreview;

    public SpriteRenderer spritePreview;


    public Transform selectedCostume;

   
    public bool costume1PreviewOn;

    public bool costume2PreviewOn;

    public bool costume3PreviewOn;

    public bool costume4PreviewOn;

    public bool costume5PreviewOn;

    public bool costume6PreviewOn;

    public bool costume7PreviewOn;

    public bool costume8PreviewOn;

    public bool costume9PreviewOn;

    public bool costume10PreviewOn;

    public bool costume11PreviewOn;

    public bool costume12PreviewOn;




    void Start()
    {
		
		costume1Preview.SetActive(true);

		costume2Preview.SetActive(false);	
		costume3Preview.SetActive(false);	
		costume4Preview.SetActive(false);	
		costume5Preview.SetActive(false);	
		costume6Preview.SetActive(false);	
		costume7Preview.SetActive(false);
		costume8Preview.SetActive(false);	
		costume9Preview.SetActive(false);	
		costume10Preview.SetActive(false);	
		costume11Preview.SetActive(false);	
		costume12Preview.SetActive(false);

		costume1PreviewOn = true;

		costume2PreviewOn = false;
		costume3PreviewOn = false;
		costume4PreviewOn = false;
		costume5PreviewOn = false;
		costume6PreviewOn = false;
		costume7PreviewOn = false;
		costume8PreviewOn = false;
		costume9PreviewOn = false;
		costume10PreviewOn = false;
		costume11PreviewOn = false;
		costume12PreviewOn = false;
    }


    // Update is called once per frame
    void Update()
    {

	spritePreview = selectedSpritePreview;



	if(menu.selectedCostume == 0)
	{
		
		costume1Preview.SetActive(true);

		costume2Preview.SetActive(false);	
		costume3Preview.SetActive(false);	
		costume4Preview.SetActive(false);	
		costume5Preview.SetActive(false);	
		costume6Preview.SetActive(false);	
		costume7Preview.SetActive(false);
		costume8Preview.SetActive(false);	
		costume9Preview.SetActive(false);	
		costume10Preview.SetActive(false);	
		costume11Preview.SetActive(false);	
		costume12Preview.SetActive(false);

		costume1PreviewOn = true;

		costume2PreviewOn = false;
		costume3PreviewOn = false;
		costume4PreviewOn = false;
		costume5PreviewOn = false;
		costume6PreviewOn = false;
		costume7PreviewOn = false;
		costume8PreviewOn = false;
		costume9PreviewOn = false;
		costume10PreviewOn = false;
		costume11PreviewOn = false;
		costume12PreviewOn = false;

	}else if(menu.selectedCostume == 1)
	{
	
		costume1Preview.SetActive(false);

		costume2Preview.SetActive(true);
	
		costume3Preview.SetActive(false);	
		costume4Preview.SetActive(false);	
		costume5Preview.SetActive(false);	
		costume6Preview.SetActive(false);	
		costume7Preview.SetActive(false);
		costume8Preview.SetActive(false);	
		costume9Preview.SetActive(false);	
		costume10Preview.SetActive(false);	
		costume11Preview.SetActive(false);	
		costume12Preview.SetActive(false);

		costume1PreviewOn = false;

		costume2PreviewOn = true;

		costume3PreviewOn = false;
		costume4PreviewOn = false;
		costume5PreviewOn = false;
		costume6PreviewOn = false;
		costume7PreviewOn = false;
		costume8PreviewOn = false;
		costume9PreviewOn = false;
		costume10PreviewOn = false;
		costume11PreviewOn = false;
		costume12PreviewOn = false;

	}else if(menu.selectedCostume == 2)
	{
	
		costume1Preview.SetActive(false);
		costume2Preview.SetActive(false);

		costume3Preview.SetActive(true);	

		costume4Preview.SetActive(false);	
		costume5Preview.SetActive(false);	
		costume6Preview.SetActive(false);	
		costume7Preview.SetActive(false);
		costume8Preview.SetActive(false);	
		costume9Preview.SetActive(false);	
		costume10Preview.SetActive(false);	
		costume11Preview.SetActive(false);	
		costume12Preview.SetActive(false);

		costume1PreviewOn = false;
		costume2PreviewOn = false;

		costume3PreviewOn = true;

		costume4PreviewOn = false;
		costume5PreviewOn = false;
		costume6PreviewOn = false;
		costume7PreviewOn = false;
		costume8PreviewOn = false;
		costume9PreviewOn = false;
		costume10PreviewOn = false;
		costume11PreviewOn = false;
		costume12PreviewOn = false;

	}else if(menu.selectedCostume == 3)
	{
	
		costume1Preview.SetActive(false);
		costume2Preview.SetActive(false);
		costume3Preview.SetActive(false);	

		costume4Preview.SetActive(true);
	
		costume5Preview.SetActive(false);	
		costume6Preview.SetActive(false);	
		costume7Preview.SetActive(false);
		costume8Preview.SetActive(false);	
		costume9Preview.SetActive(false);	
		costume10Preview.SetActive(false);	
		costume11Preview.SetActive(false);	
		costume12Preview.SetActive(false);

		costume1PreviewOn = false;
		costume2PreviewOn = false;
		costume3PreviewOn = false;

		costume4PreviewOn = true;

		costume5PreviewOn = false;
		costume6PreviewOn = false;
		costume7PreviewOn = false;
		costume8PreviewOn = false;
		costume9PreviewOn = false;
		costume10PreviewOn = false;
		costume11PreviewOn = false;
		costume12PreviewOn = false;

	}else if(menu.selectedCostume == 4)
	{
	
		costume1Preview.SetActive(false);
		costume2Preview.SetActive(false);
		costume3Preview.SetActive(false);	
		costume4Preview.SetActive(false);
	
		costume5Preview.SetActive(true);	

		costume6Preview.SetActive(false);	
		costume7Preview.SetActive(false);
		costume8Preview.SetActive(false);	
		costume9Preview.SetActive(false);	
		costume10Preview.SetActive(false);	
		costume11Preview.SetActive(false);	
		costume12Preview.SetActive(false);

		costume1PreviewOn = false;
		costume2PreviewOn = false;
		costume3PreviewOn = false;
		costume4PreviewOn = false;

		costume5PreviewOn = true;

		costume6PreviewOn = false;
		costume7PreviewOn = false;
		costume8PreviewOn = false;
		costume9PreviewOn = false;
		costume10PreviewOn = false;
		costume11PreviewOn = false;
		costume12PreviewOn = false;

	} else if(menu.selectedCostume == 5)
	{
	
		costume1Preview.SetActive(false);
		costume2Preview.SetActive(false);
		costume3Preview.SetActive(false);	
		costume4Preview.SetActive(false);
		costume5Preview.SetActive(false);	

		costume6Preview.SetActive(true);
	
		costume7Preview.SetActive(false);
		costume8Preview.SetActive(false);	
		costume9Preview.SetActive(false);	
		costume10Preview.SetActive(false);	
		costume11Preview.SetActive(false);	
		costume12Preview.SetActive(false);

		costume1PreviewOn = false;
		costume2PreviewOn = false;
		costume3PreviewOn = false;
		costume4PreviewOn = false;
		costume5PreviewOn = false;

		costume6PreviewOn = true;

		costume7PreviewOn = false;
		costume8PreviewOn = false;
		costume9PreviewOn = false;
		costume10PreviewOn = false;
		costume11PreviewOn = false;
		costume12PreviewOn = false;

	}else if(menu.selectedCostume == 6)
	{
	
		costume1Preview.SetActive(false);
		costume2Preview.SetActive(false);
		costume3Preview.SetActive(false);	
		costume4Preview.SetActive(false);
		costume5Preview.SetActive(false);	
		costume6Preview.SetActive(false);
	
		costume7Preview.SetActive(true);

		costume8Preview.SetActive(false);	
		costume9Preview.SetActive(false);	
		costume10Preview.SetActive(false);	
		costume11Preview.SetActive(false);	
		costume12Preview.SetActive(false);

		costume1PreviewOn = false;
		costume2PreviewOn = false;
		costume3PreviewOn = false;
		costume4PreviewOn = false;
		costume5PreviewOn = false;
		costume6PreviewOn = false;

		costume7PreviewOn = true;

		costume8PreviewOn = false;
		costume9PreviewOn = false;
		costume10PreviewOn = false;
		costume11PreviewOn = false;
		costume12PreviewOn = false;

	}else if(menu.selectedCostume == 7)
	{
	
		costume1Preview.SetActive(false);
		costume2Preview.SetActive(false);
		costume3Preview.SetActive(false);	
		costume4Preview.SetActive(false);
		costume5Preview.SetActive(false);	
		costume6Preview.SetActive(false);
		costume7Preview.SetActive(false);

		costume8Preview.SetActive(true);
	
		costume9Preview.SetActive(false);	
		costume10Preview.SetActive(false);	
		costume11Preview.SetActive(false);	
		costume12Preview.SetActive(false);

		costume1PreviewOn = false;
		costume2PreviewOn = false;
		costume3PreviewOn = false;
		costume4PreviewOn = false;
		costume5PreviewOn = false;
		costume6PreviewOn = false;
		costume7PreviewOn = false;

		costume8PreviewOn = true;

		costume9PreviewOn = false;
		costume10PreviewOn = false;
		costume11PreviewOn = false;
		costume12PreviewOn = false;

	}else if(menu.selectedCostume == 8)
	{
	
		costume1Preview.SetActive(false);
		costume2Preview.SetActive(false);
		costume3Preview.SetActive(false);	
		costume4Preview.SetActive(false);
		costume5Preview.SetActive(false);	
		costume6Preview.SetActive(false);
		costume7Preview.SetActive(false);
		costume8Preview.SetActive(false);
	
		costume9Preview.SetActive(true);
	
		costume10Preview.SetActive(false);	
		costume11Preview.SetActive(false);	
		costume12Preview.SetActive(false);

		costume1PreviewOn = false;
		costume2PreviewOn = false;
		costume3PreviewOn = false;
		costume4PreviewOn = false;
		costume5PreviewOn = false;
		costume6PreviewOn = false;
		costume7PreviewOn = false;
		costume8PreviewOn = false;

		costume9PreviewOn = true;

		costume10PreviewOn = false;
		costume11PreviewOn = false;
		costume12PreviewOn = false;

	}else if(menu.selectedCostume == 9)
	{
	
		costume1Preview.SetActive(false);
		costume2Preview.SetActive(false);
		costume3Preview.SetActive(false);	
		costume4Preview.SetActive(false);
		costume5Preview.SetActive(false);	
		costume6Preview.SetActive(false);
		costume7Preview.SetActive(false);
		costume8Preview.SetActive(false);
		costume9Preview.SetActive(false);
	
		costume10Preview.SetActive(true);
	
		costume11Preview.SetActive(false);	
		costume12Preview.SetActive(false);

		costume1PreviewOn = false;
		costume2PreviewOn = false;
		costume3PreviewOn = false;
		costume4PreviewOn = false;
		costume5PreviewOn = false;
		costume6PreviewOn = false;
		costume7PreviewOn = false;
		costume8PreviewOn = false;
		costume9PreviewOn = false;

		costume10PreviewOn = true;

		costume11PreviewOn = false;
		costume12PreviewOn = false;

	}else if(menu.selectedCostume == 10)
	{
	
		costume1Preview.SetActive(false);
		costume2Preview.SetActive(false);
		costume3Preview.SetActive(false);	
		costume4Preview.SetActive(false);
		costume5Preview.SetActive(false);	
		costume6Preview.SetActive(false);
		costume7Preview.SetActive(false);
		costume8Preview.SetActive(false);
		costume9Preview.SetActive(false);
		costume10Preview.SetActive(false);
	
		costume11Preview.SetActive(true);
	
		costume12Preview.SetActive(false);

		costume1PreviewOn = false;
		costume2PreviewOn = false;
		costume3PreviewOn = false;
		costume4PreviewOn = false;
		costume5PreviewOn = false;
		costume6PreviewOn = false;
		costume7PreviewOn = false;
		costume8PreviewOn = false;
		costume9PreviewOn = false;
		costume10PreviewOn = false;

		costume11PreviewOn = true;

		costume12PreviewOn = false;

	}else if(menu.selectedCostume == 11)
	{
	
		costume1Preview.SetActive(false);
		costume2Preview.SetActive(false);
		costume3Preview.SetActive(false);	
		costume4Preview.SetActive(false);
		costume5Preview.SetActive(false);	
		costume6Preview.SetActive(false);
		costume7Preview.SetActive(false);
		costume8Preview.SetActive(false);
		costume9Preview.SetActive(false);
		costume10Preview.SetActive(false);
		costume11Preview.SetActive(false);
	
		costume12Preview.SetActive(true);

		costume1PreviewOn = false;
		costume2PreviewOn = false;
		costume3PreviewOn = false;
		costume4PreviewOn = false;
		costume5PreviewOn = false;
		costume6PreviewOn = false;
		costume7PreviewOn = false;
		costume8PreviewOn = false;
		costume9PreviewOn = false;
		costume10PreviewOn = false;
		costume11PreviewOn = false;

		costume12PreviewOn = true;

	}
   }
}
