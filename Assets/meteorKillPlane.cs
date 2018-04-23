using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorKillPlane : MonoBehaviour
{

    [SerializeField] private Collider2D noteHitArea;
    [SerializeField] private Transform airplaneTransform;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (this.gameObject.GetComponent<Renderer>().isVisible && collision == noteHitArea)
        {
            //after its checked send it towards the plane to destroy it 
            Vector2.MoveTowards(this.gameObject.transform.position, airplaneTransform.position, 150.0f * Time.deltaTime);
        }
    }

}
