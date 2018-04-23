using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorRotationScript : MonoBehaviour {

	  
	void Update () {
        this.gameObject.GetComponent<Rigidbody2D>().transform.Rotate(new Vector3(0.0f, 0.0f, 400.0f * Time.deltaTime));

        //this.gameObject.GetComponent<Rigidbody2D>().transform.RotateAround(transform.position, 150.0f * Time.deltaTime); 
    }
}
