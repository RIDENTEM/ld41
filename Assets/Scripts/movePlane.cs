using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlane : MonoBehaviour {

    private Rigidbody2D airplaneRB;
    [SerializeField] private float velocity = 0.0f;
	// Use this for initialization
	void Start () {
        airplaneRB = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        //if done with that intro sequence
        airplaneRB.velocity = new Vector3(velocity * Time.deltaTime, 0.0f, 0.0f);
	}
}
