using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour {

    private Rigidbody2D camRB;
    [SerializeField] private float velocity;
	// Use this for initialization
	void Start () {
        camRB = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        camRB.velocity = (new Vector2(velocity * Time.deltaTime, 0.0f));

	}
}
