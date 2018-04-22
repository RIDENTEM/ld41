using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonManagerScript : MonoBehaviour {

    private KeyCode keyPressed;
    [SerializeField] private Rigidbody2D airplane; 
   [SerializeField] private float planeY;
    private void Start()
    {

        planeY = airplane.position.y;

    }
    public void onUpButtonPress()
    {
        planeY = 2.0f;
        airplane.MovePosition(new Vector2(airplane.position.x, planeY));

    }

    public void onRightButtonPress()
    {
        planeY = 1.0f;
        airplane.MovePosition(new Vector2(airplane.position.x, planeY));

    }

    public void onDownButtonPress()
    {
        planeY = 0.0f;
        airplane.MovePosition(new Vector2(airplane.position.x, planeY));

    }

    // Update is called once per frame
    void Update () {

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
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
    }

}
