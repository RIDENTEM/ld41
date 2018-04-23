﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlane : MonoBehaviour
{

    private Rigidbody2D airplaneRB;
    [SerializeField] private AudioSource pilotMonologue;
    [SerializeField] private float velocity = 0.0f;
    public static bool goodToFly = false;
    private void Awake()
    {

        //  pilotMonologue.playOnAwake = true;
    }
    void Start()
    {
        airplaneRB = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        //if done with that intro sequence
        // if(!pilotMonologue.isPlaying)
        {
            airplaneRB.velocity = new Vector3(velocity * Time.deltaTime, 0.0f, 0.0f);
            goodToFly = true;

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "tilt")
        {
            Debug.Log("hit collider for rotating");

            //airplaneRB. = Quaternion.LookRotation(new Vector3(0.0f, 0.0f, 25.0f)).eulerAngles;
        }
    }

}
