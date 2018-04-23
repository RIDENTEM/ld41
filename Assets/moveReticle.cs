using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveReticle : MonoBehaviour {

	 
	void Update () {
        this.gameObject.GetComponent<Rigidbody2D>().velocity = (new Vector2(100.0f * Time.deltaTime, 0.0f));	
	}
}
