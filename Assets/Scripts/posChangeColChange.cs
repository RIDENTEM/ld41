using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posChangeColChange : MonoBehaviour {

    GameObject hero;
    Transform heroTransform;
    Color heroColor;
    float randomHeroNumber;


	// Use this for initialization
	void Start () {

        hero = this.gameObject;
        heroTransform = hero.transform;
        hero.GetComponent<MeshRenderer>().material.color = heroColor;


    }
	
    void changeColor()
    {
        float[] finalRGB = giveRandomRGBVals();
        Color heroColor = new Color(finalRGB[0], finalRGB[1], finalRGB[2]);
        hero.GetComponent<MeshRenderer>().material.SetColor("posColor", heroColor);


    }

    float[] giveRandomRGBVals()
    {
        float[] returnVals = new float[3];

        //3 for R AND G AND B
        for(int i = 0; i < 3; i++)
        {
            randomHeroNumber = Random.value * 255.0f;
            returnVals[i] = randomHeroNumber;

        }
        
        return returnVals;
    }

	// Update is called once per frame
	void Update () {

        //THE NUMBER WON'T CHANGE IF IT ISN'T REASSIGNED A NEW RANDOM VALUE
       // Debug.Log(randomHeroNumber.ToString());

        if(heroTransform.hasChanged)
        {
            changeColor();
        }

	}
}
