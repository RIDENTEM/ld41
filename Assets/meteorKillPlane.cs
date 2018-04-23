using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorKillPlane : MonoBehaviour
{

    [SerializeField] private Collider2D noteHitArea;
    [SerializeField] private GameObject airplane;
    [SerializeField] private Sprite deadAirplane;
    Transform airplaneTransform;

    private void Start()
    {
         airplaneTransform = airplane.GetComponent<Transform>();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (this.gameObject.GetComponent<Renderer>().isVisible && collision == noteHitArea)
        {
            //after its checked send it towards the plane to destroy it 
            Vector2.MoveTowards(this.gameObject.transform.position, airplaneTransform.position, 150.0f * Time.deltaTime);
        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(3.0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Spawn a dead airplane?
        if(collision.transform.gameObject == airplaneTransform.transform.gameObject)
        {

            airplane.GetComponent<SpriteRenderer>().sprite = deadAirplane;

        }
    }
}
