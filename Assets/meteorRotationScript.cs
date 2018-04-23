using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorRotationScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.GetComponent<Rigidbody2D>().transform.Rotate(new Vector3(0.0f, 0.0f, 150.0f * Time.deltaTime));
	}
}
