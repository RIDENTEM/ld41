using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonManagerScript : MonoBehaviour {

    private KeyCode keyPressed;

    public void onUpButtonPress()
    {

    }

    public void onRightButtonPress()
    {

    }

    public void onDownButtonPress()
    {

    }
    
	// Update is called once per frame
	void Update () {
		
       

	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //play animation to move the plane up a bit
            onUpButtonPress();
            Debug.Log("Success on Up");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //play animation to stretch out the plane I guess to break a meteor or something
            onRightButtonPress();
            Debug.Log("Success on Right");

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //play animation to make the plane 
            onDownButtonPress();
            Debug.Log("Success on down");
        }
    }

}
