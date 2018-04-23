using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonManagerScript : MonoBehaviour
{

    private KeyCode keyPressed;
    [SerializeField] private Rigidbody2D airplane;
    [SerializeField] private float planeY;
    [SerializeField] private LineRenderer airplaneLaser;
    bool laserOn = false;
    private void Start()
    {

        planeY = airplane.position.y;

    }
    private void Update()
    {
        if (laserOn == true)
            airplaneLaser.enabled = true;
        else
            airplaneLaser.enabled = false;
            

    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.5f);
        laserOn = false;
    }
    public void onUpButtonPress()
    {
        planeY = 5.0f;
        airplane.MovePosition(new Vector2(airplane.position.x, planeY));
        if (laserOn == false)
        {
            laserOn = true; 
            StartCoroutine(wait());
        }
    }

    public void onRightButtonPress()
    {
        planeY = 1.5f;
        airplane.MovePosition(new Vector2(airplane.position.x, planeY));
        if (laserOn == false)
        {
            laserOn = true; 
            StartCoroutine(wait());

        }
    }

    public void onDownButtonPress()
    {
        planeY = -2.0f;
        airplane.MovePosition(new Vector2(airplane.position.x, planeY));
        if (laserOn == false)
        {
            laserOn = true;
            StartCoroutine(wait());

        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "meteor")
        {
            if (collision.gameObject.transform.position.y > 4.0f)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    //play animation to move the plane up a bit
                    onUpButtonPress();
                    Destroy(collision.gameObject);
                    
                }
            }
            else if (collision.gameObject.transform.position.y > 0.0f && collision.gameObject.transform.position.y < 2.0f)
            {
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    //play animation to stretch out the plane I guess to break a meteor or something
                    onRightButtonPress();
                    Destroy(collision.gameObject);

                }
            }
            else if (collision.gameObject.transform.position.y < 0.0f)
            {
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {

                    onDownButtonPress();
                    Destroy(collision.gameObject);

                }
            }

        }
    }

}
