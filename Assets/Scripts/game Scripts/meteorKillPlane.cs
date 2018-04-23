using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class meteorKillPlane : MonoBehaviour
{

    [SerializeField] private Sprite deadAirplane;
    private Collider2D noteHitArea;
     private GameObject airplane;
    Transform airplaneTransform;

    private void Start()
    {
        airplane = GameObject.FindGameObjectWithTag("Player");
        noteHitArea = GameObject.FindGameObjectWithTag("reticle").GetComponent<Collider2D>() ;
         airplaneTransform = airplane.GetComponent<Transform>();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision == noteHitArea)
        {
             
            Vector2.MoveTowards(this.gameObject.transform.position, airplaneTransform.position, 150.0f);
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("deathScreen");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        //Spawn a dead airplane?
        if (collision.transform.gameObject == airplane)
        {

            airplane.GetComponent<SpriteRenderer>().sprite = deadAirplane;
            StartCoroutine(wait());

        }
    }
   
}
